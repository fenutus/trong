using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace Translator
{
    public partial class VocabularyAdd : Form
    {
        public List<string[]> memoryDict = new List<string[]>();
        public string[][] memDict;
        bool alerted = false;

        public VocabularyAdd(string[][] m, List<string[]> d)
        {
            InitializeComponent();
            memDict = m;
            memoryDict = d;
        }

        private void VocabularyAdd_Load(object sender, EventArgs e)
        {

        }

        private void buttonKeyboard_Click(object sender, EventArgs e)
        {
            if ((dgWords.Rows[0].IsNewRow || dgWords.Rows.Count>1) && dgWords.CurrentCell.ColumnIndex == 2)
            {
                PhonemePopup p = new PhonemePopup(this);
                p.Location = new Point(MousePosition.X - 100, MousePosition.Y);
                p.ShowDialog();
            }
        }

        private void Paste(DataGridView d)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.StringFormat))
            {
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.StringFormat).ToString().TrimEnd("\r\n".ToCharArray()), "\r");
                int j = 0;
                try { j = d.CurrentRow.Index; } catch { }
                foreach (string pastedRow in pastedRows)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(d, pastedRow.Split(new char[] { '\t' }));
                    d.Rows.Insert(j, r);
                    j++;
                }
            }
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            buttonKeyboard.Enabled = false;
            try
            {
                Paste(dgWords);
            }
            catch { }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<string> listOfHits = new List<string>();
            buttonKeyboard.Enabled = false;
            SQLiteConnection con = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.dbLoc + @";Version=3;");
            con.Open();
            //---------------------checking-existing--------------------------
            foreach (DataGridViewRow r in dgWords.Rows)
            {
                if (!r.IsNewRow)
                {
                    SQLiteCommand c = new SQLiteCommand(String.Format("SELECT CAST(COUNT(*) AS INT) from main WHERE native LIKE \"{0}\" AND gloss LIKE \"{1}\"",r.Cells[0].Value,r.Cells[3].Value), con);
                    using (SQLiteDataReader s = c.ExecuteReader())
                    {
                        while (s.Read())
                        {
                            if (s.GetInt16(0) > 0)
                            {
                                listOfHits.Add((string)r.Cells[0].Value);
            } } } } }
            //-----------------------------------------------------------------
            if (listOfHits.Count > 0)
            {
                var x = MessageBox.Show(String.Format("{0} of the entries was found to exist in the lexicon:" + Environment.NewLine + String.Join(Environment.NewLine, listOfHits) +
                    Environment.NewLine + "These items will be added as new entries. Do you want to replace them instead?",
                    listOfHits.Count.ToString()), "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (x == DialogResult.No)
                {
                    foreach (DataGridViewRow r in dgWords.Rows)
                    {
                        if (!r.IsNewRow)
                        {
                            SQLiteInsert(r, con);
                        }
                    }
                    MessageBox.Show("Items successfully added to lexicon.", "Success");
                    dgWords.Rows.Clear();
                }
                else if (x == DialogResult.Yes)
                {
                    foreach (DataGridViewRow r in dgWords.Rows)
                    {
                        if (!r.IsNewRow)
                        {
                            if (listOfHits.Contains(r.Cells[0].Value))
                            {
                                SQLiteUpdate(r, con);
                            }
                            else
                            {
                                SQLiteInsert(r, con);
                            }
                        }
                    }
                    MessageBox.Show("Items successfully added to lexicon.", "Success");
                    dgWords.Rows.Clear();
                }
            }
            else
            {
                foreach (DataGridViewRow r in dgWords.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        SQLiteInsert(r, con);
                    }
                }
                MessageBox.Show("Items successfully added to lexicon.", "Success");
                dgWords.Rows.Clear();
            }
            con.Close();
            this.Close();
        }

        private void SQLiteInsert(DataGridViewRow r, SQLiteConnection con)
        {
            SQLiteCommand c = new SQLiteCommand("INSERT INTO main (native,con,ipa,gloss,comments) VALUES (@native,@con,@ipa,@gloss,@comments);", con);
            c.Parameters.AddRange(new SQLiteParameter[]{ new SQLiteParameter("@native", r.Cells[0].Value), new SQLiteParameter("@con",
                     r.Cells[1].Value), new SQLiteParameter("@ipa", r.Cells[2].Value), new SQLiteParameter("@gloss", r.Cells[3].Value),
                    new SQLiteParameter("@comments", r.Cells[4].Value) });
            c.ExecuteNonQuery();
        }

        private void SQLiteUpdate(DataGridViewRow r, SQLiteConnection con)
        {
            SQLiteCommand c = new SQLiteCommand(
                "UPDATE main SET con = :con,comments=:comments,ipa=:ipa WHERE native LIKE :native AND gloss LIKE :gloss " +
                "AND ROWID = (SELECT MIN(ROWID) FROM main WHERE native LIKE :native AND gloss LIKE :gloss)", con);
            //c.Parameters.AddRange(new SQLiteParameter[]{ new SQLiteParameter("@native", r.Cells[0].Value), new SQLiteParameter("@con",
            //         r.Cells[1].Value), new SQLiteParameter("@ipa", r.Cells[2].Value), new SQLiteParameter("@gloss", r.Cells[3].Value), new SQLiteParameter("@comments", r.Cells[4].Value) });
            c.Parameters.Add("native", DbType.String).Value = r.Cells[0].Value;
            c.Parameters.Add("con", DbType.String).Value = r.Cells[1].Value;
            c.Parameters.Add("ipa", DbType.String).Value = r.Cells[2].Value;
            c.Parameters.Add("gloss", DbType.String).Value = r.Cells[3].Value;
            c.Parameters.Add("comments", DbType.String).Value = r.Cells[4].Value;
            c.ExecuteNonQuery();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (alerted)
            { 
                string[] thing = FuzzyLookup.Search(textBox1.Text, false, false, memDict, memoryDict).Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (thing.Count() > 0 && thing.Count() < 7)
                {
                    dgWords.Rows.Clear();
                    foreach (string s in thing)
                    {
                        string[] brackets = s.Split('(')[1].Split(')')[0].Split(',');
                        string native = brackets[0];
                        string con = s.Split(' ')[0];
                        string ipa = "";
                        string gloss = "";
                        if (brackets.Count() >= 2)
                        { gloss = brackets[1].Replace(" gloss: ", "").ToUpper(); }
                        string comments = "";
                        dgWords.Rows.Add(new string[] { native, con, ipa, gloss, comments });
                    }
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            buttonKeyboard.Enabled = false;
            if (!alerted)
            {
                MessageBox.Show("Modifying this field will remove any entries from the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                alerted = true;
            }
        }

        private void dgWords_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==2)
            {
                buttonKeyboard.Enabled = true;
            }
            else
            {
                buttonKeyboard.Enabled = false;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            dgWords.Rows.Clear();
            textBox1.Clear();
        }
    }
}

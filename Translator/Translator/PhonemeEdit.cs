using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Translator
{
    public partial class PhonemeEdit : Form
    {
        static List<string[]> ipaList = new List<string[]>();

        public PhonemeEdit()
        {
            InitializeComponent();
        }

        private void PhonemeEdit_Load(object sender, EventArgs e)
        {
            SQLiteConnection m = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.dbLoc + @";Version=3;");
            SQLiteCommand command = new SQLiteCommand(@"SELECT * FROM ipa", m);
            m.Open();
            var reader = command.ExecuteReader(CommandBehavior.Default);
            while (reader.Read())
            {
                var results = reader.GetValues();
                if (results[0][0] != '[')
                {
                    ipaList.Add(new string[] { results[0], results[1] });
                }
            }

            foreach (string[] st in ipaList)
            {
                dgPhoneme.Rows.Add(new object[] { st[0], st[1] });
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<string> listOfHits = new List<string>();
            SQLiteConnection con = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.dbLoc + @";Version=3;");
            con.Open();
            SQLiteCommand c = new SQLiteCommand("SELECT * from ipa", con);
            using (SQLiteDataReader s = c.ExecuteReader())
            {
                while (s.Read())
                {
                    listOfHits.Add((string)s["grapheme"]);
                }
            }
            con.Close();
            List<string> dgv = new List<string>();
            foreach (DataGridViewRow r in dgPhoneme.Rows)
            {
                if (!r.IsNewRow)
                {
                    dgv.Add((string)r.Cells[0].Value);
                }
            }
            foreach (string l in listOfHits)
            {
                if (!dgv.Contains(l))
                {
                    con.Open();
                    c = new SQLiteCommand("DELETE FROM ipa WHERE grapheme LIKE @grapheme", con);
                    c.Parameters.Add(new SQLiteParameter("@grapheme", l));
                    c.ExecuteNonQuery();
                    con.Close();
                }
            }
            foreach (DataGridViewRow r in dgPhoneme.Rows)
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
            MessageBox.Show("Phonology updated.", "Success");
            this.Close();
        }

        private void SQLiteInsert(DataGridViewRow r, SQLiteConnection con)
        {
            SQLiteCommand c = new SQLiteCommand("INSERT INTO ipa (grapheme,phoneme) VALUES (@grapheme,@phoneme);", con);
            c.Parameters.AddRange(new SQLiteParameter[]{ new SQLiteParameter("@grapheme", r.Cells[0].Value),
                new SQLiteParameter("@phoneme", r.Cells[1].Value) });
            con.Open();
            c.ExecuteNonQuery();
            con.Close();
        }

        private void SQLiteUpdate(DataGridViewRow r, SQLiteConnection con)
        {
            SQLiteCommand c = new SQLiteCommand(
                "UPDATE ipa SET phoneme = :phoneme WHERE grapheme LIKE :grapheme AND ROWID = (SELECT MIN(ROWID) FROM ipa WHERE grapheme LIKE :grapheme)", con);
            c.Parameters.Add("phoneme", DbType.String).Value = r.Cells[1].Value;
            c.Parameters.Add("grapheme", DbType.String).Value = r.Cells[0].Value;
            con.Open();
            c.ExecuteNonQuery();
            con.Close();
        }

        private void showIPAPopupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhonemePopup p = new PhonemePopup(this);
            p.ShowDialog();
        }
    }
}

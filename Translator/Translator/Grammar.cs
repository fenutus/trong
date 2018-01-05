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
    public partial class Grammar : Form
    {

        Dictionary<string, Control> dict = new Dictionary<string, Control>() { { "Conjugation", new Verb()}, { "Declension", new Declension() } };

        public Grammar()
        {
            InitializeComponent();
        }

        private void Grammar_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (panel2.Controls.Count > 0 && panel2.Controls[0].Text != e.Node.Text)
                {
                    panel2.Controls.Clear();
                }
                Control c;
                dict.TryGetValue(e.Node.Text, out c);
                panel2.Controls.Add(c);
                c.Width = c.Parent.Width - 6;
            }
            catch { }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Declension")
            {
                Declension(((Declension)(panel2.Controls[0])).dataGridView1);
            }
        }

        private void Declension(DataGridView d)
        {
            List<string> listOfHits = new List<string>();
            SQLiteConnection con = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.dbLoc + @";Version=3;");
            con.Open();
            SQLiteCommand c = new SQLiteCommand("SELECT * from declension", con);
            using (SQLiteDataReader s = c.ExecuteReader())
            {
                while (s.Read())
                {
                    listOfHits.Add((string)s["gloss"]);
                }
            }
            con.Close();
            List<string> dgv = new List<string>();
            foreach (DataGridViewRow r in d.Rows)
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
                    c = new SQLiteCommand("DELETE FROM declension WHERE gloss LIKE @gloss", con);
                    c.Parameters.Add(new SQLiteParameter("@gloss", l));
                    c.ExecuteNonQuery();
                    con.Close();
                }
            }
            foreach (DataGridViewRow r in d.Rows)
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
            MessageBox.Show("Declensions updated.", "Success");
            this.Close();
            //PRELOAD
        }

        private void SQLiteInsert(DataGridViewRow r, SQLiteConnection con)
        {
            SQLiteCommand c = new SQLiteCommand("INSERT INTO declension (gloss,declension) VALUES (@gloss,@declension);", con);
            c.Parameters.AddRange(new SQLiteParameter[]{ new SQLiteParameter("@gloss", r.Cells[0].Value),
                new SQLiteParameter("@declension", r.Cells[1].Value) });
            con.Open();
            c.ExecuteNonQuery();
            con.Close();
        }

        private void SQLiteUpdate(DataGridViewRow r, SQLiteConnection con)
        {
            SQLiteCommand c = new SQLiteCommand(
                "UPDATE declension SET declension = :declension WHERE gloss LIKE :gloss AND ROWID = (SELECT MIN(ROWID) FROM declension WHERE gloss LIKE :gloss)", con);
            c.Parameters.Add("declension", DbType.String).Value = r.Cells[1].Value;
            c.Parameters.Add("gloss", DbType.String).Value = r.Cells[0].Value;
            con.Open();
            c.ExecuteNonQuery();
            con.Close();
        }
    }
}

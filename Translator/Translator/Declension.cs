using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Translator
{
    public partial class Declension : UserControl
    {
        public Declension()
        {
            InitializeComponent();
        }

        private void Verb_Load(object sender, EventArgs e)
        {
            /*foreach (string s in new string[] { "1.S", "1.PL.IN", "1.PL.EX", "2.S", "2.PL", "2.S.FORM", "2.PL.FORM", "3.S", "3.PL", "4" })
            {
                dataGridView1.Rows.Add(new object[] { s });
            }*/


            string dbLoc = Properties.Settings.Default.dbLoc;
            SQLiteConnection m = new SQLiteConnection(@"Data Source=" + dbLoc + @";Version=3;");
            SQLiteCommand command = new SQLiteCommand(@"SELECT * FROM declension", m);
            m.Open();

            using (var reader = command.ExecuteReader(CommandBehavior.Default))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var temp = reader.GetValues();
                        dataGridView1.Rows.Add(new object[] { temp[0], temp[1]});
                    }
                }
            }
            m.Close();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}

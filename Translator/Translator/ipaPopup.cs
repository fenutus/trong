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
    public partial class ipaPopup: Form
    {
        static Dictionary<string, string> id = new Dictionary<string, string>();
        static List<string[]> ipaList = new List<string[]>();
        string t;

        public ipaPopup(string text)
        {
            InitializeComponent();
            t = text;
        }

        private void ipaPopup_Load(object sender, EventArgs e)
        {
            textBox1.Font = Properties.Settings.Default.Font;
            if (id.Count < 1)
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

                    id.Add(st[0], st[1]);
                }
            }
            textBox1.Text = string.Concat(t.Select(x =>
            {
                if (id.ContainsKey(Convert.ToString(x)))
                { return Convert.ToString(id[Convert.ToString(x)]); }
                else { return Convert.ToString(x); };
            }));
            textBox1.SelectionStart = textBox1.Text.Length;
        }
    }
}

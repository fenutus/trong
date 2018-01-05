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
using System.IO;
using System.Globalization;


namespace Translator
{
    public partial class DictionaryDisplay : Form
    {

        List<string[]> memoryDict = new List<string[]>();
        List<string[]> memoryDictReverse = new List<string[]>();
        List<string[]> ipaList = new List<string[]>();
        string[][] memDict;
        string[][] memDictReverse;
        int counter = 0;
        Dictionary<string, string> id = new Dictionary<string, string>();
        int h = 103; //height of definition
        long entryCount =0;
        long len = 0;
        //have an option to export the dictionary to a json style format

        public DictionaryDisplay()
        {
            InitializeComponent();
        }

        private void DictionaryDisplay_Load(object sender, EventArgs e)
        {
            Preload();
            memDict = memDict.Where(x => !x[0].Contains('[')).ToArray(); ;
            id = ipaList.ToDictionary(item => item[0], item => item[1]);

            entryCount = (long)flowLeft.Height / h;
            counter = 0;
            Populate(flowLeft);
            Populate(flowRight);

            SQLiteConnection m = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.dbLoc + @";Version=3;");
            string sql = @"SELECT count(*) FROM main";
            SQLiteCommand command = new SQLiteCommand(sql, m);
            m.Open();
            len = (long)command.ExecuteScalar();
            m.Close();

            nudPage.Maximum = Math.Ceiling((decimal)len / (entryCount * 2));

            label2.Text = String.Join(Environment.NewLine, new string[] { "Dictionnaire","Woordenboek",
                                                                        "Faclair","ווערטערבוך","অভিধান","λεξικό","قاموس" });
        }

        private string FixForRtf(string input, bool normalise)
        {
            if (normalise)
            {
                input = input.Normalize(NormalizationForm.FormD);
            }
            return string.Concat(input.Replace('\u8217', '\'').Replace('`', '\'')
                    .Select(x => { if ((int)x > 127) { return @"\u" + Convert.ToString((int)x) + @"\'3f"; } else { return Convert.ToString(x); } })); ; ;
        }

        private void Entries(StreamWriter w,int section)
        {
            string word;
            string gloss; ;
            string def;
            string ipa="";
            
            char letter = '~';
            var l = memDict;
            int index = 0;
            if (section == 1)
            { l=memDictReverse; index = 1; }
            foreach (string[] s in l)
            {
                if (char.ToUpperInvariant(letter) != char.ToUpperInvariant(s[index][0]))
                {
                    w.Write(@"\sect\cols1\fs60\cf1" + Convert.ToString(s[index][0]).ToUpper() + @"\par\par \sect \sbknone \cols2");
                }
                letter = s[index][0];
                word = FixForRtf(s[0], false);
                gloss = s[2];
                def = FixForRtf(s[1], false);
                if (section == 0)
                {
                    ipa = s[3];
                    ipa = FixForRtf(string.Concat(s[1].Select(x =>
                    {
                        if (id.ContainsKey(Convert.ToString(x)))
                        { return Convert.ToString(id[Convert.ToString(x)]); }
                        else { return Convert.ToString(x); };
                    })), false);
                }
                string comment = s[4];
                if (section == 0)
                {
                    w.Write(@"\f1\fs32\cf1 " + word.Replace("9", " ").TrimEnd(' ') + @" \fs22\cf2 " + gloss.ToUpper() + @" \f2\fs30\cf0 " + def +
                    @"\f3 \par[" + ipa + "]" + comment.Select(x => { if (comment != "") { return @"\f2\par " + comment; } else { return ""; } }).FirstOrDefault() + @"\par\par" + Environment.NewLine);
                }
                else
                {
                    w.Write(@"\f1\fs32\cf1 " + def + @" \fs22\cf2 " + gloss.ToUpper() + @" \f2\fs30\cf0 " + word.Replace("9", " ").TrimEnd(' ') +
                    comment.Select(x => { if (comment != "") { return @"\f2\par " + comment; } else { return ""; } }).FirstOrDefault() + @"\par\par" + Environment.NewLine);
                }
            }
        }

        private void Populate(Control f)
        {
            int i = 0 + counter;
            while (f.Controls.Count<entryCount)
            {
                string zero = memDict[i][0];
                string one = memDict[i][1];
                string two = memDict[i][2];
                string three = memDict[i][3];
                string four = memDict[i][4];
                string ipa = "";
                if (i < memDict.Length)
                {
                    //if (zero[0] != '[')
                    //{
                        if (three.Length < 1)
                        {
                            ipa = string.Concat(one.Select(x => { if (id.ContainsKey(Convert.ToString(x))) { return (string)id[Convert.ToString(x)]; } else { return x.ToString(); } }));
                        }
                        else
                        {
                            ipa = three;
                        }
                        f.Controls.Add(new Definition(zero.Replace("9", " "), ipa, two, one.Replace("9", " "), four));
                    //}
                }
                else
                {
                    f.Controls.Add(new Definition("", "", "", "", ""));
                }
                i++;
                //counter++;
             }
            counter = (int)entryCount + 1;
        }


        public void Preload()
        {
            SQLiteConnection m = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.dbLoc + @";Version=3;");
            string sql = @"SELECT * FROM main ORDER BY native COLLATE NOCASE";
            m.Open();

            memoryDict = new List<string[]>();
            SQLiteCommand command = new SQLiteCommand(sql, m);
            var pars = command.CreateParameter();
            pars.DbType = DbType.AnsiString;
            command.Parameters.Add(pars);

            var reader = command.ExecuteReader(CommandBehavior.Default);
            while (reader.Read())
            {
                var results = reader.GetValues();
                memoryDict.Add(new string[] { results[0], results[1], results[2], results[3], results[4] });
            }
            memDict = memoryDict.ToArray();

            //----
            sql = @"SELECT * FROM main ORDER BY con COLLATE NOCASE";
            memoryDictReverse = new List<string[]>();
            command = new SQLiteCommand(sql, m);
            reader = command.ExecuteReader(CommandBehavior.Default);
            while (reader.Read())
            {
                var results = reader.GetValues();
                memoryDictReverse.Add(new string[] { results[0], results[1], results[2], results[3], results[4] });
            }
            memDictReverse = memoryDictReverse.ToArray();

            sql = @"SELECT * FROM ipa";
            command = new SQLiteCommand(sql, m);
            reader = command.ExecuteReader(CommandBehavior.Default);
            while (reader.Read())
            {
                var results = reader.GetValues();
                ipaList.Add(new string[] { results[0], results[1]});
            }
        }

        private void nudPage_ValueChanged(object sender, EventArgs e)
        {

            int i = 0+((int)nudPage.Value - 1) * 2 * (int)entryCount;
            foreach (Control f in new Control[] { flowLeft, flowRight })
            {
                foreach (Definition de in f.Controls) //not unsafe, because no other types will be here
                {

                    if (i < len)
                    {
                        string zero = memDict[i][0];
                        string one = memDict[i][1];
                        string two = memDict[i][2];
                        string three = memDict[i][3];
                        string four = memDict[i][4];
                        string ipa = "";
                        if (zero[0] != '[')
                        {
                            if (three.Length < 1)
                            {
                                ipa = string.Concat(one.Select(x => { if (id.ContainsKey(Convert.ToString(x))) { return (string)id[Convert.ToString(x)]; } else { return x.ToString(); } }));
                            }
                            else
                            {
                                ipa = memDict[i][3];
                            }
                            de.Redo(zero, ipa, two, one, four);
                            i++;
                        }
                    }
                    else
                    {
                        de.Redo("", "", "", "", "");
                    }
                }
            }

        }
    }
}

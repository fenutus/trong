using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Text.RegularExpressions;

namespace Translator
{
    class ExportTranslation
    {
        static List<string[]> memoryDict = new List<string[]>();
        static List<string[]> memoryDictReverse = new List<string[]>();
        static List<string[]> ipaList = new List<string[]>();
        static string[][] memDict;
        static string[][] memDictReverse;
        static Dictionary<string, string> id = new Dictionary<string, string>();
        static string conl, nat, sub="";

        private static string FixForRtf(string input, bool normalise)
        {
            if (normalise)
            {
                input = input.Normalize(NormalizationForm.FormD);
            }
            return string.Concat(input.Replace('\u8217', '\'').Replace('`', '\'')
                    .Select(x => { if ((int)x > 127) { return @"\u" + Convert.ToString((int)x) + @"\'3f"; } else { return Convert.ToString(x); } })); ; ;
        }

        public static void Preload()
        {   if (memoryDict.Count<1)
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
            SQLiteConnection n = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.dbLoc + @";Version=3;");
            string s = @"SELECT * FROM meta";
            n.Open();
            SQLiteCommand com = new SQLiteCommand(s, n);
            using (var reader = com.ExecuteReader(CommandBehavior.Default))
            {
                while (reader.Read())
                {
                    var results = reader.GetValues();
                    switch (results[0])
                    {
                        case "conlang_name":
                            conl = results[1];
                            break;

                        case "native_language":
                            nat = results[1];
                            break;

                        case "subtitle":
                            sub = results[1];
                            break;

                        default:
                            break;
                    }
                }
            }
            n.Close();
        }

        private static void Entries(StreamWriter w, int section)
        {
            string word;
            string gloss; ;
            string def;

            string ipa = "";

            char letter = '~';
            var l = memDict;
            int index = 0;
            if (section == 1)
            { l = memDictReverse; index = 1; }
            foreach (string[] s in l)
            {
                if (char.ToUpperInvariant(letter) != char.ToUpperInvariant(s[index][0]))
                {
                    w.Write(@"\sect\cols1\fs60\cf1\f1" + FixForRtf(Convert.ToString(s[index][0]).ToUpper(),false) + @"\par\par \sect \sbknone \cols2");
                }
                letter = s[index][0];
                word = FixForRtf(s[0], false);
                gloss = s[2];
                def = FixForRtf(s[1], false);
                if (section == 0)
                {
                    ipa = s[3];
                    /*
                     ipa = FixForRtf(string.Concat(s[1].Select(x =>
                    {
                        if (id.ContainsKey(Convert.ToString(x)))
                        { return Convert.ToString(id[Convert.ToString(x)]); }
                        else { return Convert.ToString(x); };
                    })), false);
                     * */
                    if (ipa == "")//linq expression is a bit too cumbersome,inelegant
                    {
                        for (int i = 0; i < s[1].Length; i++)
                        {
                            if (i > 0 && id.ContainsKey(String.Concat(s[1][i - 1], s[1][i])))
                            {
                                ipa = ipa.Substring(0, ipa.Length - 1);
                                ipa += id[String.Concat(s[1][i - 1], s[1][i])];
                            }
                            else if (id.ContainsKey(Convert.ToString(s[1][i])))
                            {
                                ipa += id[Convert.ToString(s[1][i])];
                            }
                            else
                            {
                                ipa += Convert.ToString(s[1][i]);
                            }
                        }
                    }
                    ipa = FixForRtf(ipa, false);
                }
                string comment = s[4];
                if (section == 0)
                {
                    w.Write(@"\f1\fs32\cf1\ql " + word.Replace("9", " ").TrimEnd(' ') + @" \fs22\cf2 " + gloss.ToUpper() + @" \f2\fs30\cf0 " + def +
                    @"\f3 \par[" + ipa + "]" + comment.Select(x => { if (comment != "") { return @"\qj\f2\par " + comment; } else { return ""; } }).FirstOrDefault() + @"\par\par" + Environment.NewLine);
                }
                else
                {
                    w.Write(@"\f1\fs32\cf1 " + def + @" \fs22\cf2\ql " + gloss.ToUpper() + @" \f2\fs30\cf0 " + word.Replace("9", " ").TrimEnd(' ') +
                    comment.Select(x => { if (comment != "") { return @"\qj\f2\par " + comment; } else { return ""; } }).FirstOrDefault() + @"\par\par" + Environment.NewLine);
                }
            }
        }

        public static void ExportToFile(string file)
        {
            Preload();
            StreamWriter w = new StreamWriter(file);
            //----------------------------------------------------------Title-Page--------------------------------------------------------------------//
            w.Write(Properties.Resources.rtfHeader); //header
            w.Write(@"\qj " + conl +  " - " + nat + @"\par"); //title
            w.Write(@"\fs36 \cf2 " + sub);// + @"\sect \fs24 \cf0"); //subtitle

            //w.Write("First letter goes here" + @"\par\par \sect \sbknone \cols2");

            //--------------------------------------------------------Orthography---------------------------------------------------------------------//

            //----------------------------------------------------Latinised-Con-to-native-------------------------------------------------------------//
            Entries(w, 0);
            w.Write(@"\sect\sbkpage");
            //Array.Sort(memDict)
            Entries(w, 1);

            w.Write("}");
            w.Close();
        }
    }
}

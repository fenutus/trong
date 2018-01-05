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
using System.Text.RegularExpressions;
using System.Globalization;

namespace Translator
{
    public partial class FuzzyLookup : Form
    {

        public List<string[]> memoryDict = new List<string[]>();
        public string[][] memDict;

        public FuzzyLookup(string[][] m, List<string[]> d)
        {
            InitializeComponent();
            memDict = m;
            memoryDict = d;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Search(textBox1.Text, checkBox1.Checked, true, memDict, memoryDict);
        }

        public static string Search(string input, bool direction, bool fuzzy,string[][] memDict, List<string[]> memoryDict)
        {
            string output = "";
            if (input.Length < 1)
            {
                output = "";
            }
            else
            {
                string temp = "";
                output = string.Concat((Words(string.Concat("%".Where(x => fuzzy)) + input + string.Concat("%".Where(x => fuzzy)), false, true, memDict, memoryDict, direction) + Environment.NewLine).Where(y => !output.Contains(y)));
                if (fuzzy)
                {
                    
                    string ascii = string.Concat(input.Normalize(NormalizationForm.FormD).Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
                    temp = Words("%" + ascii + "%", false, true, memDict, memoryDict, direction);
                    if (!output.Split('\r').Contains(temp))
                    { output += temp; }
                }
            }
            output = string.Join(Environment.NewLine,output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray());
            return output;
        }

        public static string Words(string input, bool dual, bool wg, string[][] memDict, List<string[]> memoryDict, bool direction)
        {
            string output = "";
            SQLiteConnection m = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.dbLoc + @";Version=3;");
            SQLiteCommand command = new SQLiteCommand(@"SELECT con,gloss,native FROM main WHERE native LIKE """ + input + "\"", m);
            //purposefully not cleansing input so wildcards can be used - and who would want to destroy their own database?
            if (direction)
            {
                command = new SQLiteCommand(@"SELECT native,gloss,con FROM main WHERE con LIKE """ + input + "\"", m);
            }
            m.Open();

            using (var reader = command.ExecuteReader(CommandBehavior.Default))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (wg)
                        {
                            var v = reader.GetValues();
                            string extra = "";
                            if (v[1].Length>0)
                            { extra = ", gloss: " + v[1].ToUpper(); }
                            output += v[0].Replace("9"," ") + " (" + v[2].Replace("9", " ") + extra + ")" + Environment.NewLine; //not particulary faster than a while (reader.Read()), just smaller
                        }
                        else
                        {
                            output = reader.GetString(1);
                        }
                    }
                }
                else
                {
                    output = "";
                }
            }
            m.Close();

            return (output);
        }

        private void FuzzyLookup_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}

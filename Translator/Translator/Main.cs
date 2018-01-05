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
using System.IO;
using System.Windows.Input;
using System.Collections;
using System.Threading;

namespace Translator
{
    public partial class Main : Form
    {
        string db = Properties.Settings.Default.dbLoc;
        List<object[]> pieces = new List<object[]>();
        string nullsequence = "``!&%";
        Regex joinery = new Regex("9");
        public List<string[]> memoryDict = new List<string[]>();
        public string[][] memDict;
        public List<string[]> memoryDeclension = new List<string[]>();
        int len = 0, progress = 0, cnt = 0;
        public string updater = "";
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        
        Color textBack = Color.White;
        Color textFore = Color.Black;
        Color colourControl = Color.FromKnownColor(KnownColor.Control);
        Color colourDisabled = Color.FromKnownColor(KnownColor.Control);
        //Midnight
        Color colourNightBlue = Color.FromArgb(255, 40, 50, 70);
        Color colourNightDark = Color.FromArgb(255, 40, 40, 60);
        Color colourNightFore = Color.FromArgb(255, 220, 220, 220);
        //Dark
        Color colourDarkLight = Color.FromArgb(255, 50, 45, 45);
        Color colourDarkDark = Color.FromArgb(255, 36, 32, 32);
        Color colourDarkFore = Color.FromArgb(255, 200, 200, 200);

        public Main()
        {
            InitializeComponent();
            pieces.Capacity = 500;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Recolour("Dark");
            textBoxInput.Font = Properties.Settings.Default.Font;
            tbGlossIPA.Font = Properties.Settings.Default.Font;
            textBoxPlain.Font = Properties.Settings.Default.Font;
            textBoxScript.Font = Properties.Settings.Default.FontOutput;

            statusLabel.Text = "";
            progressBar.Visible = false;

            string dbLoc = Properties.Settings.Default.dbLoc;

            if (Properties.Settings.Default.ProcessSetting == "AIT")
            {
                buttonGo.Visible = false;
            }
            if (File.Exists(dbLoc))
            {
                if (Properties.Settings.Default.MemorySetting == "LIM")
                {
                    try
                    {
                        Preload();
                    }
                    catch
                    {
                        MessageBox.Show("Sorry, this does not appear to be a valid dictionary file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    toolStripMenuItemReload.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No database found.\n\nIf this is your first run, create a new language from the Language menu.\n\nElse, select your database.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                toolStripMenuItemReload.Visible = false;
            }

            splitInputs.Height = panel1.Height - buttonGo.Height - 32;
            splitContainer2.Height = splitContainer1.Panel2.Height - buttonPhonemeDisplay.Height - 13 - labelOutput.Height;
            textBoxInput.Select();
        }

        private void Recolour(string theme)
        {
            switch (theme)
            {
                case "Midnight":
                    colourControl = colourNightBlue;
                    colourDisabled = colourNightBlue;
                    textBack = colourNightDark;
                    textFore = colourNightFore;
                    break;

                case "Dark":
                    colourControl = colourDarkLight;
                    colourDisabled = colourDarkDark;
                    textBack = colourDarkDark;
                    textFore = colourDarkFore;
                    break;

                default:
                    break;
            }
            
            this.BackColor = colourControl;
            menuStrip1.BackColor = colourControl;
            foreach (TextBox t in new object[] { textBoxInput, textBoxPlain, tbGlossIPA, textBoxScript})
            {
                t.BackColor = textBack;
                t.ForeColor = textFore;
            }
            //tbGlossIPA.BackColor = textBack;
            foreach (Control c in this.Controls)
            {
                c.ForeColor = textFore;
            }
            foreach (ToolStripMenuItem t in menuStrip1.Items)
            {
                t.DropDown.BackColor = colourControl;
                t.BackgroundImageLayout = ImageLayout.None;
                t.DropDown.ForeColor = textFore;
            }
            statusStrip1.BackColor = colourControl;
            statusLabel.BackColor = colourControl;
        }

        public void Preload()
        {
            PreloadToMemory p;
            memDict = new string[0][];
            memoryDeclension = new List<string[]>();
            SQLiteConnection m = new SQLiteConnection(@"Data Source=" + db + @";Version=3;");
            string sql = @"SELECT count(*) FROM main";
            SQLiteCommand command = new SQLiteCommand(sql, m);
            m.Open();

            long size = (long)command.ExecuteScalar();
            memoryDict = new List<string[]>(Convert.ToInt32(size));
            p = new PreloadToMemory(size);
            p.Show();
            p.Refresh();

            sql = @"SELECT * FROM main";
            command = new SQLiteCommand(sql, m);
            var pars = command.CreateParameter();
            pars.DbType = DbType.AnsiString;
            command.Parameters.Add(pars);

            var reader = command.ExecuteReader(CommandBehavior.Default);
            while (reader.Read())
            {
                var results = reader.GetValues();
                memoryDict.Add(new string[] { results[0].ToLower(), results[1], results[2], results[3] });
                p.progressBar1.Increment(1);
            }

            /*command = new SQLiteCommand(@"SELECT * FROM verbconjugation", m);
            using (var rdr = command.ExecuteReader(CommandBehavior.Default))
            {
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        var temp = rdr.GetValues();
                        memoryConj.Add(new string[] { temp[0], temp[1], temp[2], temp[3] });
                    }
                }
            }*/

            //declension
            command = new SQLiteCommand(@"SELECT * FROM declension", m);
            using (var rdr = command.ExecuteReader(CommandBehavior.Default))
            {
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        var temp = rdr.GetValues();
                        memoryDeclension.Add(new string[] { temp[0], temp[1]});
                    }
                }
            }
            //-----------------------------------------------------
            m = new SQLiteConnection(@"Data Source=" + db + @";Version=3;");
            sql = @"SELECT val FROM meta WHERE property LIKE ""conlang_name""";
            command = new SQLiteCommand(sql, m);
            m.Open();
            labelLanguageName.Text = "Language: " + (string)command.ExecuteScalar();

            m.Close();
            p.Close();
            memDict = memoryDict.ToArray();
            
        }
        
        private string Words(string input, bool dual, bool wg)
        {
            string output = "";
            if (Properties.Settings.Default.MemorySetting == "ODR")
            {

                SQLiteConnection m = new SQLiteConnection(@"Data Source=" + db + @";Version=3;");
                SQLiteCommand command = new SQLiteCommand(@"SELECT con,gloss FROM main WHERE native LIKE @input", m);
                command.Parameters.Add(new SQLiteParameter("@input", input));
                m.Open();

                using (var reader = command.ExecuteReader(CommandBehavior.Default))
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (wg)
                        {
                            output = reader.GetString(0); //not particulary faster than a while (reader.Read()), just smaller
                        }
                        else {
                            output = reader.GetString(2);
                        }
                    }
                    else
                    {
                        output = input;
                    }
                }
                m.Close();
            }
            else //-----------if memorysetting == LIM
            {
                int index = memoryDict.FindIndex(z => z[0] == input);
                if (index >= 0)
                {
                    if (wg)
                    {
                        output = memDict[index][1];
                    }
                    else
                    {
                        output = memDict[index][2];
                    }
                }
                else
                {
                    if (!dual)
                    {
                        output = input;
                    }
                }
            }
            return (output);
        }

        //-------------------------------------------------------------------------------------------
        public static string[] GetArray(string input)
        {
            string pattern = @"^(\s+|\d+|\w+|[^\d\s\w]+)+$";

            List<string> tmpList = new List<string>();
            Regex r = new Regex(pattern);
            if (r.IsMatch(input))
            {
                Match m = r.Match(input);
                foreach (Capture capture in m.Groups[1].Captures)
                {
                    if (!string.IsNullOrWhiteSpace(capture.Value))
                        tmpList.Add(capture.Value.ToLower());
                }
            }
            return(tmpList.ToArray<string>());
        }

        public static string[] GetGlossArray(string input)
        {
            string pattern = @"([\w]+#[^\s]+)|(#[^\s]+)|\w+|\n";

            List<string> tmpList = new List<string>();
            Regex r = new Regex(pattern);
            if (r.IsMatch(input))
            {

                MatchCollection mc = r.Matches(input);
                tmpList = mc.Cast<Match>().Select(match => match.Value.ToLower()).ToList();//to lower added
            }
            return (tmpList.ToArray<string>());
        }

        private void Translate(string mainstring)
        {
            string output = "";
            foreach (string paragraph in mainstring.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                string p = paragraph.Replace("’", "'").Replace("“", "\"").Replace("”", "\"");
                // do an if contraction remove
                p = p.Replace("'ll", " will").Replace("'ve", " have").Replace("'re", " are").Replace("n't", " not").Replace("'m", " am");
                var dealio = GetArray(p);
                int k = 0;
                foreach (string word in dealio)
                {
                    if (dealio.Length < pieces.Count)
                    {
                        pieces.RemoveRange(dealio.Length, pieces.Count - dealio.Length);
                    }

                    if (k >= pieces.Count)
                    {
                        pieces.Add(new object[] { word.ToLower(), "", "" });
                    }
                    else
                    {
                        if ((pieces[k][0]).ToString() != word.ToLower())
                        {
                            pieces[k] = new object[] { word.ToLower(), "", "" };
                        }
                    }
                    k++;
                    progress++;
                }
                //-----------------------------------------TRANSLATING---------------------------------------//
                string temp = "";
                for (int i = 0; i < pieces.Count; i++)
                {
                    string inp = ((string)pieces[i][0]);
                    if (inp != "." && pieces[i][2] == "")
                    {
                        if (i > 0)
                        {
                            temp = Words((string)pieces[i - 1][0] + "9" + inp, true, true);
                            if (temp.Length > 0)
                            {
                                pieces[i - 1][2] = nullsequence;
                            }
                        }
                        if (temp.Length < 1)
                        {
                            temp = Words(inp, false, true);
                        }
                        pieces[i][2] = temp;
                    }

                    if (textBoxInput.Text.Length > len + 10)
                    {
                        bgTranslaterWorker.ReportProgress(0);
                    }
                    progress++;
                }

                if (pieces.Select(arr => arr.LastOrDefault()).ToArray().Length > dealio.Length)
                {
                    pieces = pieces.Take(dealio.Length).ToList(); ;
                }

                var joined = (pieces.Select(arr =>
                {
                    object a = arr.LastOrDefault();
                    if (a.ToString() != "" || a.ToString() == nullsequence) { return a; }
                    else { return arr.FirstOrDefault(); }
                }).ToList());

                //because of the way that the original string is split, rejoining it can create additional, unwanted whitespaces. Regex and replace used to accomodate
                //This is not a perfect solution, just enough for common situations
                //case insensitive
                //does not capitalise
                //must deal with contractions - can't
                output += Regex.Replace(String.Join(" ", joined.Where(j => j.ToString() != nullsequence)), @"( (?=[\.,;:\?\)\[\]<>])+?|( (?=[\.,;:\?\)\[\]<>]$)))", @"", RegexOptions.Multiline)
                    .Replace("( ", "(").Replace("\" ", "\"").Replace("<< ", " <<").Replace("[ ", " [").Replace(" ' ", "'").Replace(" \".", "\".").Replace("\"\"", "\" \"").Replace(" \",", "\",")
                    .Replace(" !", "!") + Environment.NewLine;
                cnt += pieces.Count;
            }

            updater = output;
        }

        //------------------------------------- BUTTON HANDLING -----------------------------------------//
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences p = new Preferences();
            var r = p.ShowDialog();
            if (Properties.Settings.Default.ProcessSetting == "AIT")
            {
                buttonGo.Visible = false;
            }
            else
            {
                buttonGo.Visible = true;
            }
            if (Properties.Settings.Default.MemorySetting == "LIM")
            {
                toolStripMenuItemReload.Visible = true;
            }
            else
            {
                toolStripMenuItemReload.Visible = false;
            }
            textBoxInput.Font = Properties.Settings.Default.Font;
            tbGlossIPA.Font = Properties.Settings.Default.Font;
            textBoxPlain.Font = Properties.Settings.Default.Font;
            textBoxScript.Font = Properties.Settings.Default.FontOutput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Update();
            Translate(textBoxInput.Text);
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            if (Properties.Settings.Default.ProcessSetting.ToString() == "AIT")
            {
                if (!bgTranslaterWorker.IsBusy)
                {
                    progressBar.Visible = true;
                    progressBar.Maximum = Convert.ToInt32(GetArray(textBoxInput.Text).Length * 2.1);
                    bgTranslaterWorker.RunWorkerAsync();
                }
            }
        }

        private void addVocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VocabularyAdd v = new VocabularyAdd(memDict,memoryDict);
            v.ShowDialog();
            Preload();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            splitInputs.Height = panel1.Height - buttonGo.Height - 32;
            splitContainer2.Height = splitContainer1.Panel2.Height - buttonPhonemeDisplay.Height - 13 - labelOutput.Height;
        }

        private void grammarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grammar g = new Grammar();
            g.ShowDialog();
            Preload();
        }

        private void toolStripMenuItemReload_Click(object sender, EventArgs e)
        {
            memDict = null;
            memoryDict = null;
            Preload();
            textBoxInput_TextChanged(this, e);
            MessageBox.Show("Lexicon reloaded.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void reverseFuzzyLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuzzyLookup f = new FuzzyLookup(memDict,memoryDict);
            f.ShowDialog();
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            NewLanguage n = new NewLanguage();
            var x = n.ShowDialog();
            if (x == DialogResult.OK)
            {
                db = Properties.Settings.Default.dbLoc;
                Preload();
            }
        }

        private void classicDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DictionaryDisplay d = new DictionaryDisplay();
            d.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog() { Filter = "Rich Text Format (*.rtf)|*.rtf", DefaultExt = ".rtf", AddExtension = true, OverwritePrompt = true };
            var x = s.ShowDialog();
            if (x == DialogResult.OK)
            {
                try
                {
                    ExportTranslation.ExportToFile(s.FileName);
                }
                catch (Exception ex) { MessageBox.Show(String.Format("Sorry, there was an error saving the file:\n\n{0}", ex), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void tbGlossIPA_Click(object sender, EventArgs e)
        {
            tbGlossIPA.ReadOnly = false;
            tbGlossIPA.BackColor = textBack;
            
            textBoxInput.ReadOnly = true;
            textBoxInput.BackColor = colourDisabled;
            textBoxInput.Enabled = false;
            textBoxInput.Enabled = true;
        }

        private void textBoxInput_Click(object sender, EventArgs e)
        {
            textBoxInput.ReadOnly = false;
            textBoxInput.BackColor = textBack;

            tbGlossIPA.ReadOnly = true;
            tbGlossIPA.BackColor = colourDisabled;
            tbGlossIPA.Enabled = false;
            tbGlossIPA.Enabled = true;
        }

        private void tbGlossIPA_TextChanged(object sender, EventArgs e)
        {
            string output = "";
            foreach (string paragraph in tbGlossIPA.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                List<string> temp = new List<string>();
                foreach (string x in GetGlossArray(paragraph))
                {
                    if (x.Contains("#"))
                    {
                        string g = x.Substring(x.IndexOf('#') + 1);
                        string w = x.Substring(0, x.IndexOf('#'));
                        string wd = Words(w, false, true);
                        //gloss
                        foreach (string gg in g.Split('#'))
                        {
                            int index = memoryDict.FindIndex(z => (z[2] == gg || z[2].Split(';').Contains(gg)) && (w.Length < 1 || z[0] == w));
                            if (index != -1)
                            {
                                w = memDict[index][1];
                            }
                            //declension
                            else
                            {
                                index = memoryDeclension.FindIndex(z => z[0] == gg || z[0].Split(';').Contains(gg));
                                if (index != -1)
                                {
                                    string[] rules = memoryDeclension[index][1].Split(';');
                                    foreach (string rule in rules)
                                    {
                                        if (rule.ToLower().Contains("pre:"))
                                        {
                                            if (w != x.Substring(0, x.IndexOf('#')))
                                            {
                                                w = rule.ToLower().Replace("pre:", "") + w;
                                            }
                                            else
                                            {
                                                w = rule.ToLower().Replace("pre:", "") + wd;
                                            }
                                        }
                                        if (rule.ToLower().Contains("post:"))
                                        {
                                            if (w != x.Substring(0, x.IndexOf('#')))
                                            {
                                                w = w + rule.ToLower().Replace("post:", "");
                                            }
                                            else
                                            {
                                                w = wd + rule.ToLower().Replace("post:", "");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        temp.Add(w);
                    }
                    else
                    {
                        try
                        {
                            temp.Add(Words(x, false, true));
                        }
                        catch
                        {
                            temp.Add(x);
                        }
                    }
                }
                output += String.Join(" ",temp) + Environment.NewLine;
            }
            textBoxPlain.Text = String.Join(" ",output);
            tbGlossIPA.Select();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPlain.Text);
            MessageBox.Show("Text copied.");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var x = saveFileDialog.ShowDialog();
            try
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxPlain.Text);
            }
            catch (Exception ex) {MessageBox.Show(String.Format("Sorry, there was an error saving the file:\n\n{0}",ex),"Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning) ; }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog s = new OpenFileDialog() { Filter = "SQlite3 Database (*.db)|*.db", DefaultExt = ".db", AddExtension = true };
            var x = s.ShowDialog();
            if (x == DialogResult.OK)
            {
                try
                {
                    db = s.FileName;
                    Preload();
                    pieces = new List<object[]>();
                    Properties.Settings.Default.dbLoc = s.FileName;
                    Properties.Settings.Default.Save();
                    textBoxInput_TextChanged(this, e);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(String.Format("Sorry, there was an error opening the file:\n\n{0}", ex), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Sorry, this does not appear to be a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void plainSaveStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog() { Filter = "Plain Text Format (*.txt)|*.txt", DefaultExt = ".txt", AddExtension = true, OverwritePrompt = true };
            var x = s.ShowDialog();
            if (x == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(s.FileName, textBoxPlain.Text);
                }
                catch (Exception ex) { MessageBox.Show(String.Format("Sorry, there was an error saving the file:\n\n{0}", ex), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void deleteVocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VocabularyDelete v = new VocabularyDelete(memDict, memoryDict);
            v.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a beta release. Further information will be available in the full release. Please send all feedback to reddit user /u/fenutus."
                + "\n\nPlease label messages either BUG or FEATURE SUGGESTION","About");
        }

        private void buttonPhonemeDisplay_Click(object sender, EventArgs e)
        {
            ipaPopup p = new ipaPopup(textBoxPlain.Text);
            p.ShowDialog();
        }

        private void phonemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhonemeEdit p = new PhonemeEdit();
            p.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics(memDict);
            s.ShowDialog();
        }

        //---------------------------------------------------------------------background worker stuff-------------------------------------------
        private void bgTranslaterWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar.Value = progress;
        }

        private void textBoxPlain_TextChanged(object sender, EventArgs e)
        {
            textBoxScript.Text = textBoxPlain.Text;
        }

        private void bgTranslaterWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            updater = "";
            cnt = 0;
            progress = 0;
            textBoxPlain.SuspendLayout();
            textBoxInput.SuspendLayout();
            stopwatch = System.Diagnostics.Stopwatch.StartNew();
            progress = 0;
            
            Translate(textBoxInput.Text);
        }

        private void bgTranslaterWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBoxPlain.Text = updater;
            textBoxPlain.ResumeLayout();
            textBoxInput.ResumeLayout();
            progressBar.Value = 0;
            progressBar.Visible = false;
            progress = 0;
            stopwatch.Stop();
            statusLabel.Text = cnt.ToString() + " units processed in " + stopwatch.ElapsedMilliseconds.ToString() + " milliseconds.";

            len = textBoxInput.Text.Length;
        }
    }
}

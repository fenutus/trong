using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Translator
{
    public partial class NewLanguage: Form
    {

        bool create = false;
        public NewLanguage()
        {
            InitializeComponent();
        }

        private void NewLanguage_Load(object sender, EventArgs e)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            tbNat.Text = ci.EnglishName.Split(' ')[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string file = tbLoc.Text.Replace(" ","_");
                SQLiteConnection.CreateFile(file);
                SQLiteConnection con = new SQLiteConnection(String.Format("Data Source={0};Version=3;", file));
                con.Open();
                string[] creates = {
                    "CREATE TABLE [ipa] ([grapheme] CHAR, [phoneme] CHAR, [glyph] BLOB, [audio] BLOB);",
                    "CREATE TABLE[main] ([native] CHAR, [con] CHAR, [gloss] CHAR, [ipa] CHAR, [comments] CHAR);",
                    "CREATE TABLE[meta] ([property] CHAR, [val] CHAR);",
                    "CREATE TABLE[verbconjugation] ([person] CHAR, [conjugation] CHAR);",
                    "CREATE TABLE [declension] ([gloss] CHAR, [declension] CHAR);"
                };
                foreach (string command in creates)
                {
                    (new SQLiteCommand(command, con)).ExecuteNonQuery();
                }
                (new SQLiteCommand(String.Format("INSERT INTO meta (property,val) VALUES (\"{0}\",\"{1}\")", new object[] { "conlang_name", tbCon.Text }), con)).ExecuteNonQuery();
                (new SQLiteCommand(String.Format("INSERT INTO meta (property,val) VALUES (\"{0}\",\"{1}\")", new object[] { "native_language", tbNat.Text }), con)).ExecuteNonQuery();
                con.Close();
                Properties.Settings.Default.dbLoc = file;
                Properties.Settings.Default.Save();
                create = true;
            }
            catch (Exception ex) { MessageBox.Show(String.Format("Sorry, there was an error creating the file:\n\n{0}", ex), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog() { Filter = "SQLite Database (*.db)|*.db", DefaultExt = ".db", AddExtension = true, OverwritePrompt = true };
            var x = s.ShowDialog();
            if (x == DialogResult.OK)
            {
                tbLoc.Text = s.FileName;
            }
     }

        private void NewLanguage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (create)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

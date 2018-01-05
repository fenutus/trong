using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Preferences : Form
    {
        Dictionary<string, Control> dict = new Dictionary<string, Control>() {
            { "Appearance", new Appearance()}, { "Performance", new Performance() }, { "Database", new Database() } };

        public Preferences()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "Performance":
                    if (Properties.Settings.Default.MemorySetting != ((Performance)(panel2.Controls[0])).MemorySetting)
                        //AIT processign does not need reload.
                    {
                        MessageBox.Show("Performance settings changed. You will have to restart the application for changes to take effect.", "Settings Changed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    Properties.Settings.Default.MemorySetting = ((Performance)(panel2.Controls[0])).MemorySetting;
                    Properties.Settings.Default.ProcessSetting = ((Performance)(panel2.Controls[0])).ProcessSetting;
                    Properties.Settings.Default.Save();
                    break;

                case "Database":
                    Properties.Settings.Default.dbLoc = ((Database)(panel2.Controls[0])).dbLoc;
                    Properties.Settings.Default.Save();
                    break;

                case "Appearance":
                    Properties.Settings.Default.Font = ((Appearance)(panel2.Controls[0])).labelFontFile.Font;
                    Properties.Settings.Default.FontOutput = ((Appearance)(panel2.Controls[0])).labelFontOutput.Font;
                    Properties.Settings.Default.Save();
                    break;

                default:
                    break;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void Preferences_Load(object sender, EventArgs e)
        {

        }
    }
}

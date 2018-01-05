using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Database : UserControl
    {
        public string dbLoc;

        public Database()
        {
            InitializeComponent();
        }

        private void Performance_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 12;
            textBox1.Width = this.Width-30;
            textBox1.Text = Properties.Settings.Default.dbLoc.Replace(@"\\",@"\");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "DB File (*.db,*.db3)|*.db;*.db3|Sqlite Database (*.sqlite)|*.sqlite";
            f.ShowDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = f.FileName;
                dbLoc = f.FileName;
            }
        }
    }
}

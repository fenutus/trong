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
    public partial class Appearance : UserControl
    {
        public Appearance()
        {
            InitializeComponent();
        }

        private void Appearance_Load(object sender, EventArgs e)
        {
            labelFontFile.Text = Properties.Settings.Default.Font.FontFamily.Name;
            labelFontFile.Font = Properties.Settings.Default.Font;
            numericUpDown1.Value = (int)Properties.Settings.Default.Font.SizeInPoints;

            labelFontOutput.Text = Properties.Settings.Default.FontOutput.FontFamily.Name;
            labelFontOutput.Font = Properties.Settings.Default.FontOutput;
            numericFontOutput.Value = (int)Properties.Settings.Default.FontOutput.SizeInPoints;

            this.Width = this.Parent.Width - 12;
            groupBox1.Width = groupBox1.Parent.Width - 2;
            groupBox2.Width = groupBox1.Parent.Width - 2;
            //labelFontFile.Width = flpFont.Width - buttonLoad.Width - 12;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                var x = fontDialog1.Font;
                labelFontFile.Text = x.FontFamily.Name.ToString();
                labelFontFile.Font = new Font(x.FontFamily, x.SizeInPoints);
                numericUpDown1.Value = (int)x.Size;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                var x = fontDialog1.Font;
                labelFontOutput.Text = x.FontFamily.Name.ToString();
                labelFontOutput.Font = new Font(x.FontFamily, x.SizeInPoints);
                numericFontOutput.Value = (int)x.Size;
            }
        }

        private void numericFontOutput_ValueChanged(object sender, EventArgs e)
        {
            labelFontOutput.Font = new Font(labelFontOutput.Font.FontFamily, (float)numericFontOutput.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelFontFile.Font = new Font(labelFontFile.Font.FontFamily, (float)numericUpDown1.Value);
        }
    }
}

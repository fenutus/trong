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
    public partial class Performance : UserControl
    {
        public string MemorySetting = "ODR";
        public string ProcessSetting = "AIT";
        public bool PunctuationSmoothing = true;

        public Performance()
        {
            InitializeComponent();
        }

        private void Performance_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 12;
            gbProcess.Width = gbProcess.Parent.Width - 2;
            gbDatabbase.Width = gbProcess.Parent.Width - 2;
            panel1.Width = panel1.Parent.Width - 14;

            if (Properties.Settings.Default.MemorySetting.ToString() =="ODR")
            {
                radioODR.Select();
                MemorySetting = "ODR";
            }
            else
            {
                radioLIM.Select();
                MemorySetting = "LIM";
            }

            if (Properties.Settings.Default.ProcessSetting.ToString() == "AIT")
            {
                radioButtonAIT.Select();
                ProcessSetting = "AIT";
            }
            else
            {
                radioButtonOBP.Select();
                ProcessSetting = "OBP";
            }

        }

        private void radioODR_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Checked == true)
            {
                MemorySetting = "ODR";
            }
        }

        private void radioLIM_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Checked == true)
            {
                MemorySetting = "LIM";
            }
        }

        private void radioButtonAIT_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Checked == true)
            {
                ProcessSetting = "AIT";
            }
        }

        private void radioButtonOBP_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Checked == true)
            {
                ProcessSetting = "OBP";
            }
        }
    }
}

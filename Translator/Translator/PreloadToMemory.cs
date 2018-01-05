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
    public partial class PreloadToMemory : Form
    {

        public long mx = 0;
        public int pr = 0;


        public PreloadToMemory(long mxm)
        {
            InitializeComponent();
            mx = mxm;
        }

        private void PreloadToMemory_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = Convert.ToInt16(mx);
            this.Update();
            this.Refresh();
        }
    }
}

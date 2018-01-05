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
    public partial class Definition : UserControl
    {
        string word;
        string ipa;
        string gloss;
        string definition;
        string comments;

        public Label lw;
        public Label lp;
        public Label lg;
        public Label ld;
        public Label lc;

        public Definition(string w, string i, string g, string d, string c)
        {
            InitializeComponent();
            word = w;
            ipa = i;
            gloss = g;
            definition = d;
            comments = c;
            this.Name = Convert.ToString(DateTime.Now.Ticks) ;
        }

        private void Definition_Load(object sender, EventArgs e)
        {
            labelWord.Text = word;
            if (ipa != "" && ipa.Length > 0)
            {
                labelPhoneme.Text = "[" + ipa + "]";
            }
            else { labelPhoneme.Text = ""; }
            labelGloss.Text = gloss.ToUpper();
            labelDefinition.Text = definition;
            labelComment.Text = comments;

            lw = labelWord;
            lp = labelPhoneme;
            lg = labelGloss;
            ld = labelDefinition;
            lc = labelComment;
        }

        public void Redo(string w, string i, string g, string d, string c)
        {
            lw.Text = w.Replace("9"," ");
            if (i != "" && i.Length>0)
            {
                lp.Text = "[" + i + "]";
            } else { lp.Text = ""; }
            lg.Text = g.ToUpper();
            ld.Text = d;
            lc.Text = c;
        }
    }
}

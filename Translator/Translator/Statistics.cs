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
    public partial class Statistics: Form
    {
        string[][] mem;
        List<string> found;

        public Statistics(string[][] memDict)
        {
            InitializeComponent();
            mem = memDict;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            found = new List<string>();
            List<int> counter = new List<int>();

            List<object[]> l = new List<object[]>();
            foreach (string[] s in mem)
            {
                string startLetter = Convert.ToString(s[1].First()).ToLower();
                string endLetter = Convert.ToString(s[1].LastOrDefault()).ToLower();

                if (!found.Contains(startLetter))
                {
                    found.Add(startLetter);
                    counter.Add(1);
                }
                else
                {
                    //counter.ElementAt(found.IndexOf(startLetter)) = (int)counter.ElementAt(found.IndexOf(startLetter))+1;
                }
                
            }
            dataGridView1.Rows.Add(new object[] { });
        }
    }
}

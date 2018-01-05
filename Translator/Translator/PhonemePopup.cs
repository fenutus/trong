using System;
using System.Windows.Forms;

namespace Translator
{
    public partial class PhonemePopup : Form
    {
        string[] phonemes = new string[] {"ˑ","ː","ä","ã","a̯","ɐ","ɑ","ɒ","ɑ̃","æ","ɓ","ç","ɔ","ɕ","ɔ̃","ɗ","d̪","ð","ɖ",
            "ə","ɚ","ɛ","ɛ̃","ɜ","ɝ","ɢ","ɠ","ɣ","ɤ","ħ","ɦ","ɥ","ɪ","ɨ","ɟ","ʄ","ʝ","ɫ","ɭ","ɬ","ɮ","ɱ","ɯ","ɰ", "ʍ",
            "ɴ","ɲ","ɳ","n̥","n̩","ŋ","ɵ","ø","œ","œ̃","ɸ","ʀ","ɽ","ɹ","ɺ","ɻ","ɾ","ʁ","ʂ","ʃ", "t͡ʃ","ʈ","ʉ","ʊ","v","ʋ","ʌ",
            "ʏ","ʎ","ʐ","ʑ","ʒ","ʔ","ʕ","β","θ","χ","ᵃ", "ᵇ", "ᶜ", "ᵈ", "ᵉ", "ᶠ", "ᵍ", "ʰ", "ⁱ", "ʲ", "ᵏ", "ˡ",
            "ᵐ", "ⁿ", "ᵒ", "ᵖ", "ʳ", "ˢ", "ᵗ", "ᵘ", "ᵛ", "ʷ", "ˣ", "ʸ", "ᶻ","ǀ","ǁ"};
        VocabularyAdd v;
        PhonemeEdit p;

        public PhonemePopup(VocabularyAdd self)
        {
            InitializeComponent();
            v = self;
        }
        public PhonemePopup(PhonemeEdit self)
        {
            InitializeComponent();
            p = self;
        }

        private void PhonemePopup_Load(object sender, EventArgs e)
        {
            foreach (string s in phonemes)
            {
                lvPhonemes.Items.Add(s);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvPhonemes_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                timerVanish.Stop();
            }
            catch { }
        }

        private void PhonemePopup_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                timerVanish.Start();
            }
            catch { }
        }

        private void lvPhonemes_MouseClick(object sender, MouseEventArgs e)
        {
            //error check, and only insert at cursor point
            
            
        }

        private void lvPhonemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lvPhonemes_ItemActivate(object sender, EventArgs e)
        {
            if (v != null)
            {
                v.dgWords.SelectedCells[0].Value += ((ListView)sender).SelectedItems[0].Text;
            }
            else
            {
                p.dgPhoneme.SelectedCells[0].Value += ((ListView)sender).SelectedItems[0].Text;
            }
        }

        private void lvPhonemes_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                timerVanish.Start();
            }
            catch { }
        }

        private void PhonemePopup_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                timerVanish.Stop();
            }
            catch { }
        }
    }
}

namespace Translator
{
    partial class PhonemePopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvPhonemes = new System.Windows.Forms.ListView();
            this.timerVanish = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lvPhonemes
            // 
            this.lvPhonemes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPhonemes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhonemes.Location = new System.Drawing.Point(0, 0);
            this.lvPhonemes.MultiSelect = false;
            this.lvPhonemes.Name = "lvPhonemes";
            this.lvPhonemes.Size = new System.Drawing.Size(583, 297);
            this.lvPhonemes.TabIndex = 0;
            this.lvPhonemes.UseCompatibleStateImageBehavior = false;
            this.lvPhonemes.ItemActivate += new System.EventHandler(this.lvPhonemes_ItemActivate);
            this.lvPhonemes.SelectedIndexChanged += new System.EventHandler(this.lvPhonemes_SelectedIndexChanged);
            this.lvPhonemes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvPhonemes_MouseClick);
            this.lvPhonemes.MouseEnter += new System.EventHandler(this.lvPhonemes_MouseEnter);
            this.lvPhonemes.MouseLeave += new System.EventHandler(this.lvPhonemes_MouseLeave);
            // 
            // timerVanish
            // 
            this.timerVanish.Interval = 3000;
            this.timerVanish.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PhonemePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 297);
            this.Controls.Add(this.lvPhonemes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PhonemePopup";
            this.ShowInTaskbar = false;
            this.Text = "PhonemePopup";
            this.Load += new System.EventHandler(this.PhonemePopup_Load);
            this.MouseLeave += new System.EventHandler(this.PhonemePopup_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PhonemePopup_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPhonemes;
        private System.Windows.Forms.Timer timerVanish;
    }
}
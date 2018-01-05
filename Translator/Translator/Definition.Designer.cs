namespace Translator
{
    partial class Definition
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWord = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelGloss = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.labelPhoneme = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Futura Hv", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelWord.Location = new System.Drawing.Point(3, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(65, 28);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "Word";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelWord);
            this.flowLayoutPanel1.Controls.Add(this.labelGloss);
            this.flowLayoutPanel1.Controls.Add(this.labelDefinition);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelGloss
            // 
            this.labelGloss.AutoSize = true;
            this.labelGloss.Font = new System.Drawing.Font("Futura Hv", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGloss.ForeColor = System.Drawing.Color.Gray;
            this.labelGloss.Location = new System.Drawing.Point(74, 0);
            this.labelGloss.Name = "labelGloss";
            this.labelGloss.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.labelGloss.Size = new System.Drawing.Size(41, 27);
            this.labelGloss.TabIndex = 1;
            this.labelGloss.Text = "gloss";
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefinition.Location = new System.Drawing.Point(121, 0);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelDefinition.Size = new System.Drawing.Size(181, 28);
            this.labelDefinition.TabIndex = 2;
            this.labelDefinition.Text = "Definition goes here";
            // 
            // labelPhoneme
            // 
            this.labelPhoneme.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneme.Location = new System.Drawing.Point(3, 28);
            this.labelPhoneme.Name = "labelPhoneme";
            this.labelPhoneme.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelPhoneme.Size = new System.Drawing.Size(485, 25);
            this.labelPhoneme.TabIndex = 1;
            this.labelPhoneme.Text = "[phoneme]";
            // 
            // labelComment
            // 
            this.labelComment.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComment.Location = new System.Drawing.Point(4, 53);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(484, 46);
            this.labelComment.TabIndex = 2;
            this.labelComment.Text = "comment comment comment comment comment comment comment g comment";
            // 
            // splitter1
            // 
            this.splitter1.CausesValidation = false;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 99);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(491, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // Definition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelPhoneme);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Futura Hv", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Definition";
            this.Size = new System.Drawing.Size(491, 102);
            this.Load += new System.EventHandler(this.Definition_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label labelPhoneme;
        public System.Windows.Forms.Label labelGloss;
        public System.Windows.Forms.Label labelDefinition;
        public System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Splitter splitter1;
    }
}

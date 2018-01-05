namespace Translator
{
    partial class VocabularyDelete
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
            this.dgWords = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.bClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Native = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gloss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgWords)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgWords
            // 
            this.dgWords.AllowUserToAddRows = false;
            this.dgWords.AllowUserToResizeColumns = false;
            this.dgWords.AllowUserToResizeRows = false;
            this.dgWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Native,
            this.Con,
            this.IPA,
            this.Gloss,
            this.comment,
            this.Delete});
            this.dgWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgWords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgWords.Location = new System.Drawing.Point(12, 44);
            this.dgWords.Margin = new System.Windows.Forms.Padding(4);
            this.dgWords.MultiSelect = false;
            this.dgWords.Name = "dgWords";
            this.dgWords.Size = new System.Drawing.Size(647, 357);
            this.dgWords.TabIndex = 0;
            this.dgWords.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWords_CellEnter);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.bClear);
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(671, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(143, 413);
            this.panelButtons.TabIndex = 1;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(6, 12);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(125, 32);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 367);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Delete";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dgWords);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.textBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(12);
            this.panelLeft.Size = new System.Drawing.Size(671, 413);
            this.panelLeft.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 10);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(647, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Native
            // 
            this.Native.HeaderText = "Native";
            this.Native.Name = "Native";
            this.Native.ReadOnly = true;
            // 
            // Con
            // 
            this.Con.HeaderText = "Con";
            this.Con.Name = "Con";
            this.Con.ReadOnly = true;
            // 
            // IPA
            // 
            this.IPA.HeaderText = "IPA";
            this.IPA.Name = "IPA";
            this.IPA.ReadOnly = true;
            // 
            // Gloss
            // 
            this.Gloss.HeaderText = "Gloss";
            this.Gloss.Name = "Gloss";
            this.Gloss.ReadOnly = true;
            // 
            // comment
            // 
            this.comment.HeaderText = "Comment";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // VocabularyDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 413);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VocabularyDelete";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Delete Vocabulary";
            this.Load += new System.EventHandler(this.VocabularyAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWords)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelLeft;
        public System.Windows.Forms.DataGridView dgWords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Native;
        private System.Windows.Forms.DataGridViewTextBoxColumn Con;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gloss;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
    }
}
namespace Translator
{
    partial class PhonemeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhonemeEdit));
            this.dgPhoneme = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Grapheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phoneme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showIPAPopupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhoneme)).BeginInit();
            this.panel1.SuspendLayout();
            this.context.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPhoneme
            // 
            this.dgPhoneme.AllowUserToResizeColumns = false;
            this.dgPhoneme.AllowUserToResizeRows = false;
            this.dgPhoneme.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPhoneme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPhoneme.ColumnHeadersHeight = 25;
            this.dgPhoneme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPhoneme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grapheme,
            this.Phoneme});
            this.dgPhoneme.ContextMenuStrip = this.context;
            this.dgPhoneme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPhoneme.Location = new System.Drawing.Point(12, 12);
            this.dgPhoneme.Name = "dgPhoneme";
            this.dgPhoneme.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPhoneme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPhoneme.Size = new System.Drawing.Size(355, 652);
            this.dgPhoneme.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(252, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 32);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(155, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 32);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 664);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 49);
            this.panel1.TabIndex = 4;
            // 
            // Grapheme
            // 
            this.Grapheme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grapheme.FillWeight = 25F;
            this.Grapheme.HeaderText = "Grapheme";
            this.Grapheme.MaxInputLength = 3;
            this.Grapheme.Name = "Grapheme";
            // 
            // Phoneme
            // 
            this.Phoneme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phoneme.FillWeight = 25F;
            this.Phoneme.HeaderText = "Phoneme";
            this.Phoneme.MaxInputLength = 3;
            this.Phoneme.Name = "Phoneme";
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showIPAPopupToolStripMenuItem});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(162, 26);
            // 
            // showIPAPopupToolStripMenuItem
            // 
            this.showIPAPopupToolStripMenuItem.Name = "showIPAPopupToolStripMenuItem";
            this.showIPAPopupToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showIPAPopupToolStripMenuItem.Text = "Show IPA popup";
            this.showIPAPopupToolStripMenuItem.Click += new System.EventHandler(this.showIPAPopupToolStripMenuItem_Click);
            // 
            // PhonemeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 725);
            this.Controls.Add(this.dgPhoneme);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PhonemeEdit";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Phoneme Table";
            this.Load += new System.EventHandler(this.PhonemeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhoneme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.context.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grapheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phoneme;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem showIPAPopupToolStripMenuItem;
        internal System.Windows.Forms.DataGridView dgPhoneme;
    }
}
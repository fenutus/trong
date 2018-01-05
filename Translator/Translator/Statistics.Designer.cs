namespace Translator
{
    partial class Statistics
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.letter,
            this.countStart,
            this.countEnd});
            this.dataGridView1.Location = new System.Drawing.Point(35, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 571);
            this.dataGridView1.TabIndex = 0;
            // 
            // letter
            // 
            this.letter.HeaderText = "Letter";
            this.letter.Name = "letter";
            // 
            // countStart
            // 
            this.countStart.HeaderText = "Start Count";
            this.countStart.Name = "countStart";
            // 
            // countEnd
            // 
            this.countEnd.HeaderText = "End Count";
            this.countEnd.Name = "countEnd";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 672);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Statistics";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn countStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn countEnd;
    }
}
namespace Translator
{
    partial class Performance
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbDatabbase = new System.Windows.Forms.GroupBox();
            this.radioODR = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioLIM = new System.Windows.Forms.RadioButton();
            this.gbProcess = new System.Windows.Forms.GroupBox();
            this.radioButtonOBP = new System.Windows.Forms.RadioButton();
            this.radioButtonAIT = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbDatabbase.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.gbDatabbase);
            this.flowLayoutPanel1.Controls.Add(this.gbProcess);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 303);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // gbDatabbase
            // 
            this.gbDatabbase.Controls.Add(this.radioODR);
            this.gbDatabbase.Controls.Add(this.panel1);
            this.gbDatabbase.Controls.Add(this.radioLIM);
            this.gbDatabbase.Location = new System.Drawing.Point(3, 3);
            this.gbDatabbase.Name = "gbDatabbase";
            this.gbDatabbase.Size = new System.Drawing.Size(344, 197);
            this.gbDatabbase.TabIndex = 4;
            this.gbDatabbase.TabStop = false;
            this.gbDatabbase.Text = "Database Behaviour";
            // 
            // radioODR
            // 
            this.radioODR.AutoSize = true;
            this.radioODR.Location = new System.Drawing.Point(7, 22);
            this.radioODR.Margin = new System.Windows.Forms.Padding(4);
            this.radioODR.Name = "radioODR";
            this.radioODR.Size = new System.Drawing.Size(135, 20);
            this.radioODR.TabIndex = 1;
            this.radioODR.TabStop = true;
            this.radioODR.Text = "On Demand Read";
            this.radioODR.UseVisualStyleBackColor = true;
            this.radioODR.CheckedChanged += new System.EventHandler(this.radioODR_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(330, 112);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 90);
            this.label2.TabIndex = 0;
            this.label2.Text = "It is highly recommended that regular users select LIM. Computers with low memory" +
    " may benefit in performance from ODR, especially with larger dictionaries. Trans" +
    "lations will be much slower with ODR.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioLIM
            // 
            this.radioLIM.AutoSize = true;
            this.radioLIM.Location = new System.Drawing.Point(7, 50);
            this.radioLIM.Margin = new System.Windows.Forms.Padding(4);
            this.radioLIM.Name = "radioLIM";
            this.radioLIM.Size = new System.Drawing.Size(122, 20);
            this.radioLIM.TabIndex = 2;
            this.radioLIM.TabStop = true;
            this.radioLIM.Text = "Load In Memory";
            this.radioLIM.UseVisualStyleBackColor = true;
            this.radioLIM.CheckedChanged += new System.EventHandler(this.radioLIM_CheckedChanged);
            // 
            // gbProcess
            // 
            this.gbProcess.Controls.Add(this.radioButtonOBP);
            this.gbProcess.Controls.Add(this.radioButtonAIT);
            this.gbProcess.Location = new System.Drawing.Point(3, 206);
            this.gbProcess.Name = "gbProcess";
            this.gbProcess.Size = new System.Drawing.Size(344, 79);
            this.gbProcess.TabIndex = 5;
            this.gbProcess.TabStop = false;
            this.gbProcess.Text = "Processing Point";
            // 
            // radioButtonOBP
            // 
            this.radioButtonOBP.AutoSize = true;
            this.radioButtonOBP.Location = new System.Drawing.Point(6, 48);
            this.radioButtonOBP.Name = "radioButtonOBP";
            this.radioButtonOBP.Size = new System.Drawing.Size(121, 20);
            this.radioButtonOBP.TabIndex = 1;
            this.radioButtonOBP.TabStop = true;
            this.radioButtonOBP.Text = "On Button Press";
            this.radioButtonOBP.UseVisualStyleBackColor = true;
            this.radioButtonOBP.CheckedChanged += new System.EventHandler(this.radioButtonOBP_CheckedChanged);
            // 
            // radioButtonAIT
            // 
            this.radioButtonAIT.AutoSize = true;
            this.radioButtonAIT.Location = new System.Drawing.Point(7, 22);
            this.radioButtonAIT.Name = "radioButtonAIT";
            this.radioButtonAIT.Size = new System.Drawing.Size(83, 20);
            this.radioButtonAIT.TabIndex = 0;
            this.radioButtonAIT.TabStop = true;
            this.radioButtonAIT.Text = "As I Type";
            this.radioButtonAIT.UseVisualStyleBackColor = true;
            this.radioButtonAIT.CheckedChanged += new System.EventHandler(this.radioButtonAIT_CheckedChanged);
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Performance";
            this.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.Size = new System.Drawing.Size(382, 303);
            this.Load += new System.EventHandler(this.Performance_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbDatabbase.ResumeLayout(false);
            this.gbDatabbase.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbProcess.ResumeLayout(false);
            this.gbProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioODR;
        private System.Windows.Forms.RadioButton radioLIM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatabbase;
        private System.Windows.Forms.GroupBox gbProcess;
        private System.Windows.Forms.RadioButton radioButtonAIT;
        private System.Windows.Forms.RadioButton radioButtonOBP;
    }
}

namespace Translator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitInputs = new System.Windows.Forms.SplitContainer();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelMainInput = new System.Windows.Forms.Label();
            this.tbGlossIPA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonPhonemeDisplay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReload = new System.Windows.Forms.ToolStripMenuItem();
            this.plainSaveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vocabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grammarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phonemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.reverseFuzzyLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classicDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLanguageName = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgTranslaterWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitInputs)).BeginInit();
            this.splitInputs.Panel1.SuspendLayout();
            this.splitInputs.Panel2.SuspendLayout();
            this.splitInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCopy);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPhonemeDisplay);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4, 6, 12, 12);
            this.splitContainer1.Size = new System.Drawing.Size(1001, 437);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 99;
            this.splitContainer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitInputs);
            this.panel1.Controls.Add(this.buttonGo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12, 6, 4, 12);
            this.panel1.Size = new System.Drawing.Size(450, 437);
            this.panel1.TabIndex = 99;
            // 
            // splitInputs
            // 
            this.splitInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitInputs.Location = new System.Drawing.Point(12, 6);
            this.splitInputs.Name = "splitInputs";
            this.splitInputs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitInputs.Panel1
            // 
            this.splitInputs.Panel1.Controls.Add(this.textBoxInput);
            this.splitInputs.Panel1.Controls.Add(this.labelMainInput);
            // 
            // splitInputs.Panel2
            // 
            this.splitInputs.Panel2.Controls.Add(this.tbGlossIPA);
            this.splitInputs.Panel2.Controls.Add(this.label1);
            this.splitInputs.Size = new System.Drawing.Size(434, 338);
            this.splitInputs.SplitterDistance = 169;
            this.splitInputs.TabIndex = 99;
            this.splitInputs.TabStop = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.White;
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Font = new System.Drawing.Font("Futura Bk", 15.75F);
            this.textBoxInput.Location = new System.Drawing.Point(0, 20);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(434, 149);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Click += new System.EventHandler(this.textBoxInput_Click);
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // labelMainInput
            // 
            this.labelMainInput.AutoSize = true;
            this.labelMainInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMainInput.Font = new System.Drawing.Font("Futura Bk", 10.75F);
            this.labelMainInput.Location = new System.Drawing.Point(0, 0);
            this.labelMainInput.Name = "labelMainInput";
            this.labelMainInput.Size = new System.Drawing.Size(47, 20);
            this.labelMainInput.TabIndex = 4;
            this.labelMainInput.Text = "Input:";
            // 
            // tbGlossIPA
            // 
            this.tbGlossIPA.BackColor = System.Drawing.SystemColors.Control;
            this.tbGlossIPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGlossIPA.Font = new System.Drawing.Font("Futura Bk", 15.75F);
            this.tbGlossIPA.Location = new System.Drawing.Point(0, 20);
            this.tbGlossIPA.Multiline = true;
            this.tbGlossIPA.Name = "tbGlossIPA";
            this.tbGlossIPA.ReadOnly = true;
            this.tbGlossIPA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGlossIPA.Size = new System.Drawing.Size(434, 145);
            this.tbGlossIPA.TabIndex = 1;
            this.tbGlossIPA.Click += new System.EventHandler(this.tbGlossIPA_Click);
            this.tbGlossIPA.TextChanged += new System.EventHandler(this.tbGlossIPA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Futura Bk", 10.75F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Glossing Input:";
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Futura Bk", 13F);
            this.buttonGo.Location = new System.Drawing.Point(310, 380);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(136, 45);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Translate";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(4, 6);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxPlain);
            this.splitContainer2.Panel1.Controls.Add(this.labelOutput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBoxScript);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(531, 338);
            this.splitContainer2.SplitterDistance = 169;
            this.splitContainer2.TabIndex = 12;
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.BackColor = System.Drawing.Color.White;
            this.textBoxPlain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPlain.Location = new System.Drawing.Point(0, 20);
            this.textBoxPlain.Multiline = true;
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.ReadOnly = true;
            this.textBoxPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlain.Size = new System.Drawing.Size(531, 149);
            this.textBoxPlain.TabIndex = 4;
            this.textBoxPlain.TextChanged += new System.EventHandler(this.textBoxPlain_TextChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOutput.Font = new System.Drawing.Font("Futura Bk", 10.75F);
            this.labelOutput.Location = new System.Drawing.Point(0, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(120, 20);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "Plaintext Output:";
            // 
            // textBoxScript
            // 
            this.textBoxScript.BackColor = System.Drawing.Color.White;
            this.textBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxScript.Location = new System.Drawing.Point(0, 20);
            this.textBoxScript.Multiline = true;
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.ReadOnly = true;
            this.textBoxScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxScript.Size = new System.Drawing.Size(531, 145);
            this.textBoxScript.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Futura Bk", 10.75F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Script Output";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Font = new System.Drawing.Font("Futura Bk", 9.75F);
            this.buttonCopy.Location = new System.Drawing.Point(257, 380);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(136, 45);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy To Clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPhonemeDisplay
            // 
            this.buttonPhonemeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPhonemeDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhonemeDisplay.Font = new System.Drawing.Font("Futura Bk", 13F);
            this.buttonPhonemeDisplay.Location = new System.Drawing.Point(399, 380);
            this.buttonPhonemeDisplay.Name = "buttonPhonemeDisplay";
            this.buttonPhonemeDisplay.Size = new System.Drawing.Size(136, 45);
            this.buttonPhonemeDisplay.TabIndex = 7;
            this.buttonPhonemeDisplay.Text = "Show IPA";
            this.buttonPhonemeDisplay.UseVisualStyleBackColor = true;
            this.buttonPhonemeDisplay.Click += new System.EventHandler(this.buttonPhonemeDisplay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReload,
            this.plainSaveStripMenuItem,
            this.exportToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemReload
            // 
            this.toolStripMenuItemReload.Name = "toolStripMenuItemReload";
            this.toolStripMenuItemReload.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItemReload.Text = "Reload Lexicon";
            this.toolStripMenuItemReload.Click += new System.EventHandler(this.toolStripMenuItemReload_Click);
            // 
            // plainSaveStripMenuItem
            // 
            this.plainSaveStripMenuItem.Name = "plainSaveStripMenuItem";
            this.plainSaveStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.plainSaveStripMenuItem.Text = "Export Translation";
            this.plainSaveStripMenuItem.Click += new System.EventHandler(this.plainSaveStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exportToolStripMenuItem.Text = "Export Classic Dictionary";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.selectToolStripMenuItem,
            this.toolStripSeparator2,
            this.vocabToolStripMenuItem,
            this.grammarToolStripMenuItem,
            this.phonemeToolStripMenuItem,
            this.toolStripSeparator3,
            this.reverseFuzzyLookupToolStripMenuItem,
            this.toolStripSeparator4,
            this.statisticsToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemNew.Text = "New...";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.selectToolStripMenuItem.Text = "Select...";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // vocabToolStripMenuItem
            // 
            this.vocabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVocabularyToolStripMenuItem,
            this.deleteVocabularyToolStripMenuItem});
            this.vocabToolStripMenuItem.Name = "vocabToolStripMenuItem";
            this.vocabToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.vocabToolStripMenuItem.Text = "Vocabulary";
            // 
            // addVocabularyToolStripMenuItem
            // 
            this.addVocabularyToolStripMenuItem.Name = "addVocabularyToolStripMenuItem";
            this.addVocabularyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addVocabularyToolStripMenuItem.Text = "Add/Revise Vocabulary";
            this.addVocabularyToolStripMenuItem.Click += new System.EventHandler(this.addVocabularyToolStripMenuItem_Click);
            // 
            // deleteVocabularyToolStripMenuItem
            // 
            this.deleteVocabularyToolStripMenuItem.Name = "deleteVocabularyToolStripMenuItem";
            this.deleteVocabularyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteVocabularyToolStripMenuItem.Text = "Delete Vocabulary";
            this.deleteVocabularyToolStripMenuItem.Click += new System.EventHandler(this.deleteVocabularyToolStripMenuItem_Click);
            // 
            // grammarToolStripMenuItem
            // 
            this.grammarToolStripMenuItem.Name = "grammarToolStripMenuItem";
            this.grammarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.grammarToolStripMenuItem.Text = "Grammar";
            this.grammarToolStripMenuItem.Click += new System.EventHandler(this.grammarToolStripMenuItem_Click);
            // 
            // phonemeToolStripMenuItem
            // 
            this.phonemeToolStripMenuItem.Name = "phonemeToolStripMenuItem";
            this.phonemeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.phonemeToolStripMenuItem.Text = "Phoneme Table";
            this.phonemeToolStripMenuItem.Click += new System.EventHandler(this.phonemeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
            // 
            // reverseFuzzyLookupToolStripMenuItem
            // 
            this.reverseFuzzyLookupToolStripMenuItem.Name = "reverseFuzzyLookupToolStripMenuItem";
            this.reverseFuzzyLookupToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reverseFuzzyLookupToolStripMenuItem.Text = "Fuzzy Lookup";
            this.reverseFuzzyLookupToolStripMenuItem.Click += new System.EventHandler(this.reverseFuzzyLookupToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(153, 6);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classicDictionaryToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // classicDictionaryToolStripMenuItem
            // 
            this.classicDictionaryToolStripMenuItem.Name = "classicDictionaryToolStripMenuItem";
            this.classicDictionaryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.classicDictionaryToolStripMenuItem.Text = "Classic Dictionary";
            this.classicDictionaryToolStripMenuItem.Click += new System.EventHandler(this.classicDictionaryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1001, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(72, 17);
            this.statusLabel.Text = "statusLabel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelLanguageName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 41);
            this.panel2.TabIndex = 3;
            // 
            // labelLanguageName
            // 
            this.labelLanguageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLanguageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLanguageName.Location = new System.Drawing.Point(0, 0);
            this.labelLanguageName.Name = "labelLanguageName";
            this.labelLanguageName.Size = new System.Drawing.Size(1001, 41);
            this.labelLanguageName.TabIndex = 0;
            this.labelLanguageName.Text = "No Language Selected";
            this.labelLanguageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Plaintext File (*.txt)|*.txt";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save Translation";
            // 
            // bgTranslaterWorker
            // 
            this.bgTranslaterWorker.WorkerReportsProgress = true;
            this.bgTranslaterWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgTranslaterWorker_DoWork);
            this.bgTranslaterWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgTranslaterWorker_ProgressChanged);
            this.bgTranslaterWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgTranslaterWorker_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1001, 524);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Futura Bk", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Trong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitInputs.Panel1.ResumeLayout(false);
            this.splitInputs.Panel1.PerformLayout();
            this.splitInputs.Panel2.ResumeLayout(false);
            this.splitInputs.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitInputs)).EndInit();
            this.splitInputs.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbGlossIPA;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem vocabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grammarToolStripMenuItem;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReload;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem reverseFuzzyLookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classicDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phonemeToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitInputs;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelMainInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonPhonemeDisplay;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.ComponentModel.BackgroundWorker bgTranslaterWorker;
        private System.Windows.Forms.ToolStripMenuItem plainSaveStripMenuItem;
        private System.Windows.Forms.Label labelLanguageName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxScript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}


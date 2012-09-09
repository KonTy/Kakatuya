namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textToRead = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.speedrateBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutDoneButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.highlitePanel = new System.Windows.Forms.Panel();
            this.theStrip = new System.Windows.Forms.ToolStrip();
            this.playerStrip = new System.Windows.Forms.ToolStrip();
            this.highliteTxt = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.theWord = new System.Windows.Forms.ToolStripLabel();
            this.Read = new System.Windows.Forms.ToolStripButton();
            this.Stop = new System.Windows.Forms.ToolStripButton();
            this.Pause = new System.Windows.Forms.ToolStripButton();
            this.Resume = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedrateBar)).BeginInit();
            this.aboutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.highlitePanel.SuspendLayout();
            this.theStrip.SuspendLayout();
            this.playerStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textToRead
            // 
            this.textToRead.AcceptsReturn = true;
            this.textToRead.AcceptsTab = true;
            this.textToRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textToRead.BackColor = System.Drawing.SystemColors.Window;
            this.textToRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToRead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textToRead.Location = new System.Drawing.Point(259, 30);
            this.textToRead.Multiline = true;
            this.textToRead.Name = "textToRead";
            this.textToRead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textToRead.Size = new System.Drawing.Size(364, 344);
            this.textToRead.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Volume";
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.volumeBar.BackColor = System.Drawing.SystemColors.Window;
            this.volumeBar.Location = new System.Drawing.Point(3, 248);
            this.volumeBar.Maximum = 20;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(250, 45);
            this.volumeBar.TabIndex = 3;
            this.volumeBar.Value = 18;
            // 
            // speedrateBar
            // 
            this.speedrateBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speedrateBar.BackColor = System.Drawing.SystemColors.Window;
            this.speedrateBar.LargeChange = 1;
            this.speedrateBar.Location = new System.Drawing.Point(3, 197);
            this.speedrateBar.Minimum = -10;
            this.speedrateBar.Name = "speedrateBar";
            this.speedrateBar.Size = new System.Drawing.Size(250, 45);
            this.speedrateBar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed";
            // 
            // aboutPanel
            // 
            this.aboutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutPanel.BackColor = System.Drawing.SystemColors.Info;
            this.aboutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutPanel.Controls.Add(this.aboutDoneButton);
            this.aboutPanel.Controls.Add(this.textBox1);
            this.aboutPanel.Controls.Add(this.button2);
            this.aboutPanel.Location = new System.Drawing.Point(297, 30);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(329, 255);
            this.aboutPanel.TabIndex = 7;
            // 
            // aboutDoneButton
            // 
            this.aboutDoneButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutDoneButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aboutDoneButton.Location = new System.Drawing.Point(16, 215);
            this.aboutDoneButton.Name = "aboutDoneButton";
            this.aboutDoneButton.Size = new System.Drawing.Size(301, 33);
            this.aboutDoneButton.TabIndex = 2;
            this.aboutDoneButton.Text = "ok";
            this.aboutDoneButton.UseVisualStyleBackColor = false;
            this.aboutDoneButton.Click += new System.EventHandler(this.aboutDoneButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(17, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 155);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(17, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "কাকাতুয়া";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsButton,
            this.toolStripLabel2,
            this.helpToolStripButton1,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(626, 27);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Shruti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(64, 24);
            this.toolStripLabel2.Text = "কাকাতুয়া";
            this.toolStripLabel2.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // highlitePanel
            // 
            this.highlitePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.highlitePanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.highlitePanel.Controls.Add(this.theStrip);
            this.highlitePanel.Controls.Add(this.playerStrip);
            this.highlitePanel.Controls.Add(this.label3);
            this.highlitePanel.Controls.Add(this.volumeBar);
            this.highlitePanel.Controls.Add(this.label2);
            this.highlitePanel.Controls.Add(this.highliteTxt);
            this.highlitePanel.Controls.Add(this.speedrateBar);
            this.highlitePanel.Location = new System.Drawing.Point(0, 23);
            this.highlitePanel.Name = "highlitePanel";
            this.highlitePanel.Size = new System.Drawing.Size(256, 359);
            this.highlitePanel.TabIndex = 12;
            // 
            // theStrip
            // 
            this.theStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.theStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theWord});
            this.theStrip.Location = new System.Drawing.Point(0, 0);
            this.theStrip.Name = "theStrip";
            this.theStrip.Padding = new System.Windows.Forms.Padding(4);
            this.theStrip.Size = new System.Drawing.Size(256, 59);
            this.theStrip.TabIndex = 7;
            this.theStrip.Text = "toolStrip2";
            // 
            // playerStrip
            // 
            this.playerStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playerStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.playerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Read,
            this.Stop,
            this.Pause,
            this.Resume});
            this.playerStrip.Location = new System.Drawing.Point(0, 304);
            this.playerStrip.Name = "playerStrip";
            this.playerStrip.Size = new System.Drawing.Size(256, 55);
            this.playerStrip.TabIndex = 6;
            this.playerStrip.Text = "toolStrip1";
            // 
            // highliteTxt
            // 
            this.highliteTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.highliteTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highliteTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.highliteTxt.Location = new System.Drawing.Point(3, 62);
            this.highliteTxt.Multiline = true;
            this.highliteTxt.Name = "highliteTxt";
            this.highliteTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.highliteTxt.Size = new System.Drawing.Size(250, 129);
            this.highliteTxt.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusIcon,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 377);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(626, 29);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip2";
            // 
            // statusIcon
            // 
            this.statusIcon.BackColor = System.Drawing.Color.Transparent;
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusIcon.Size = new System.Drawing.Size(15, 24);
            this.statusIcon.Text = "~";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusLabel.Image = global::WindowsFormsApplication1.Properties.Resources.Loader;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(253, 24);
            this.statusLabel.Text = "Kakatuya Narrator from SfaarSoft by Sadh ";
            // 
            // settingsButton
            // 
            this.settingsButton.Image = global::WindowsFormsApplication1.Properties.Resources.AlienBonzai1_1024jpg;
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(69, 24);
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // helpToolStripButton1
            // 
            this.helpToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton1.Image")));
            this.helpToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton1.Name = "helpToolStripButton1";
            this.helpToolStripButton1.Size = new System.Drawing.Size(23, 24);
            this.helpToolStripButton1.Text = "He&lp";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.printToolStripButton.Text = "&Print";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // theWord
            // 
            this.theWord.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theWord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.theWord.Image = global::WindowsFormsApplication1.Properties.Resources.theWordIcon;
            this.theWord.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.theWord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.theWord.Name = "theWord";
            this.theWord.RightToLeftAutoMirrorImage = true;
            this.theWord.Size = new System.Drawing.Size(80, 48);
            this.theWord.Text = "...";
            this.theWord.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.theWord.Click += new System.EventHandler(this.smartClick);
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.Color.Transparent;
            this.Read.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Read.Image = global::WindowsFormsApplication1.Properties.Resources.Play2;
            this.Read.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Read.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Read.Name = "Read";
            this.Read.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Read.Padding = new System.Windows.Forms.Padding(4);
            this.Read.RightToLeftAutoMirrorImage = true;
            this.Read.Size = new System.Drawing.Size(52, 52);
            this.Read.Text = "toolStripButton1";
            this.Read.Click += new System.EventHandler(this.read_Click);
            // 
            // Stop
            // 
            this.Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Stop.Image = global::WindowsFormsApplication1.Properties.Resources.Stop7;
            this.Stop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Stop.Name = "Stop";
            this.Stop.Padding = new System.Windows.Forms.Padding(4);
            this.Stop.Size = new System.Drawing.Size(52, 52);
            this.Stop.Text = "toolStripButton1";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause
            // 
            this.Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pause.Name = "Pause";
            this.Pause.Padding = new System.Windows.Forms.Padding(4);
            this.Pause.Size = new System.Drawing.Size(44, 52);
            this.Pause.Text = "toolStripButton2";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Resume
            // 
            this.Resume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Resume.Image = global::WindowsFormsApplication1.Properties.Resources.Resume;
            this.Resume.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Resume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Resume.Name = "Resume";
            this.Resume.Padding = new System.Windows.Forms.Padding(4);
            this.Resume.Size = new System.Drawing.Size(44, 52);
            this.Resume.Text = "toolStripButton1";
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(626, 406);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.textToRead);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.highlitePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.97;
            this.Text = "কাকাতুয়া KAKATUYA Narrator";
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedrateBar)).EndInit();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.highlitePanel.ResumeLayout(false);
            this.highlitePanel.PerformLayout();
            this.theStrip.ResumeLayout(false);
            this.theStrip.PerformLayout();
            this.playerStrip.ResumeLayout(false);
            this.playerStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textToRead;
        private System.Windows.Forms.TrackBar speedrateBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button aboutDoneButton;
        private System.Windows.Forms.ToolStrip menuStrip;
        private System.Windows.Forms.ToolStripButton helpToolStripButton1;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel highlitePanel;
        private System.Windows.Forms.TextBox highliteTxt;
        private System.Windows.Forms.ToolStrip playerStrip;
        private System.Windows.Forms.ToolStripButton Read;
        private System.Windows.Forms.ToolStrip theStrip;
        private System.Windows.Forms.ToolStripButton Pause;
        private System.Windows.Forms.ToolStripButton Resume;
        private System.Windows.Forms.ToolStripButton Stop;
        private System.Windows.Forms.ToolStripLabel theWord;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusIcon;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


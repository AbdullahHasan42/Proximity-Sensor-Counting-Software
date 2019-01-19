namespace ProximitySensorCountingSoftware
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBoxSerialMonitor = new System.Windows.Forms.RichTextBox();
            this.label_serialMonitor = new System.Windows.Forms.Label();
            this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
            this.richTextBoxTargetCount = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.label_targetCount = new System.Windows.Forms.Label();
            this.labelComPorts = new System.Windows.Forms.Label();
            this.textBoxPartNumber = new System.Windows.Forms.TextBox();
            this.labelPartName = new System.Windows.Forms.Label();
            this.groupBox_testDetails = new System.Windows.Forms.GroupBox();
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.labelPartNumber = new System.Windows.Forms.Label();
            this.ButtonRestart = new System.Windows.Forms.Button();
            this.imageListForIcons = new System.Windows.Forms.ImageList(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.ButtonCreateLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.groupBox_testDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.ReadTimeout = 500;
            this.serialPort1.WriteTimeout = 500;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // richTextBoxSerialMonitor
            // 
            this.richTextBoxSerialMonitor.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxSerialMonitor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSerialMonitor.Location = new System.Drawing.Point(623, 77);
            this.richTextBoxSerialMonitor.Name = "richTextBoxSerialMonitor";
            this.richTextBoxSerialMonitor.ReadOnly = true;
            this.richTextBoxSerialMonitor.Size = new System.Drawing.Size(333, 97);
            this.richTextBoxSerialMonitor.TabIndex = 0;
            this.richTextBoxSerialMonitor.Text = "";
            // 
            // label_serialMonitor
            // 
            this.label_serialMonitor.AutoSize = true;
            this.label_serialMonitor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serialMonitor.Location = new System.Drawing.Point(619, 53);
            this.label_serialMonitor.Name = "label_serialMonitor";
            this.label_serialMonitor.Size = new System.Drawing.Size(119, 21);
            this.label_serialMonitor.TabIndex = 4;
            this.label_serialMonitor.Text = "Serial Monitor";
            // 
            // comboBoxComPorts
            // 
            this.comboBoxComPorts.FormattingEnabled = true;
            this.comboBoxComPorts.Location = new System.Drawing.Point(126, 94);
            this.comboBoxComPorts.Name = "comboBoxComPorts";
            this.comboBoxComPorts.Size = new System.Drawing.Size(149, 21);
            this.comboBoxComPorts.TabIndex = 2;
            // 
            // richTextBoxTargetCount
            // 
            this.richTextBoxTargetCount.Enabled = false;
            this.richTextBoxTargetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBoxTargetCount.Location = new System.Drawing.Point(325, 236);
            this.richTextBoxTargetCount.MaxLength = 7;
            this.richTextBoxTargetCount.Multiline = false;
            this.richTextBoxTargetCount.Name = "richTextBoxTargetCount";
            this.richTextBoxTargetCount.Size = new System.Drawing.Size(251, 33);
            this.richTextBoxTargetCount.TabIndex = 5;
            this.richTextBoxTargetCount.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTime.Location = new System.Drawing.Point(761, 375);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(180, 28);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "0 day(s), 00:00:00";
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.AutoSize = true;
            this.labelTimeElapsed.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeElapsed.Location = new System.Drawing.Point(618, 375);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(142, 28);
            this.labelTimeElapsed.TabIndex = 0;
            this.labelTimeElapsed.Text = "Time Elapsed:";
            // 
            // label_targetCount
            // 
            this.label_targetCount.AutoSize = true;
            this.label_targetCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_targetCount.Location = new System.Drawing.Point(320, 205);
            this.label_targetCount.Name = "label_targetCount";
            this.label_targetCount.Size = new System.Drawing.Size(134, 28);
            this.label_targetCount.TabIndex = 13;
            this.label_targetCount.Text = "Target Count";
            // 
            // labelComPorts
            // 
            this.labelComPorts.AutoSize = true;
            this.labelComPorts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComPorts.Location = new System.Drawing.Point(122, 69);
            this.labelComPorts.Name = "labelComPorts";
            this.labelComPorts.Size = new System.Drawing.Size(156, 20);
            this.labelComPorts.TabIndex = 14;
            this.labelComPorts.Text = "COM Ports Avaliable:";
            // 
            // textBoxPartNumber
            // 
            this.textBoxPartNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPartNumber.Location = new System.Drawing.Point(134, 86);
            this.textBoxPartNumber.Name = "textBoxPartNumber";
            this.textBoxPartNumber.Size = new System.Drawing.Size(138, 36);
            this.textBoxPartNumber.TabIndex = 4;
            // 
            // labelPartName
            // 
            this.labelPartName.AutoSize = true;
            this.labelPartName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartName.Location = new System.Drawing.Point(6, 55);
            this.labelPartName.Name = "labelPartName";
            this.labelPartName.Size = new System.Drawing.Size(95, 21);
            this.labelPartName.TabIndex = 16;
            this.labelPartName.Text = "Part Name:";
            // 
            // groupBox_testDetails
            // 
            this.groupBox_testDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.groupBox_testDetails.Controls.Add(this.textBoxPartName);
            this.groupBox_testDetails.Controls.Add(this.textBoxPartNumber);
            this.groupBox_testDetails.Controls.Add(this.labelPartNumber);
            this.groupBox_testDetails.Controls.Add(this.labelPartName);
            this.groupBox_testDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox_testDetails.Font = new System.Drawing.Font("Haettenschweiler", 20F);
            this.groupBox_testDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.groupBox_testDetails.Location = new System.Drawing.Point(325, 54);
            this.groupBox_testDetails.Name = "groupBox_testDetails";
            this.groupBox_testDetails.Size = new System.Drawing.Size(280, 148);
            this.groupBox_testDetails.TabIndex = 17;
            this.groupBox_testDetails.TabStop = false;
            this.groupBox_testDetails.Text = "Test Details";
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.BackColor = System.Drawing.Color.White;
            this.textBoxPartName.Location = new System.Drawing.Point(134, 44);
            this.textBoxPartName.MaxLength = 240;
            this.textBoxPartName.Name = "textBoxPartName";
            this.textBoxPartName.Size = new System.Drawing.Size(138, 36);
            this.textBoxPartName.TabIndex = 3;
            // 
            // labelPartNumber
            // 
            this.labelPartNumber.AutoSize = true;
            this.labelPartNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartNumber.Location = new System.Drawing.Point(6, 97);
            this.labelPartNumber.Name = "labelPartNumber";
            this.labelPartNumber.Size = new System.Drawing.Size(113, 21);
            this.labelPartNumber.TabIndex = 18;
            this.labelPartNumber.Text = "Part Number:";
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRestart.Enabled = false;
            this.ButtonRestart.FlatAppearance.BorderSize = 0;
            this.ButtonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRestart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRestart.ImageKey = "Restart.png";
            this.ButtonRestart.ImageList = this.imageListForIcons;
            this.ButtonRestart.Location = new System.Drawing.Point(12, 259);
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.Size = new System.Drawing.Size(107, 95);
            this.ButtonRestart.TabIndex = 7;
            this.ButtonRestart.Text = "Restart";
            this.ButtonRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonRestart.UseVisualStyleBackColor = false;
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // imageListForIcons
            // 
            this.imageListForIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListForIcons.ImageStream")));
            this.imageListForIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListForIcons.Images.SetKeyName(0, "Connect.png");
            this.imageListForIcons.Images.SetKeyName(1, "CreateLog.png");
            this.imageListForIcons.Images.SetKeyName(2, "Disconnect.png");
            this.imageListForIcons.Images.SetKeyName(3, "Exit.png");
            this.imageListForIcons.Images.SetKeyName(4, "Pause.png");
            this.imageListForIcons.Images.SetKeyName(5, "Resume.png");
            this.imageListForIcons.Images.SetKeyName(6, "Restart.png");
            this.imageListForIcons.Images.SetKeyName(7, "Send.png");
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Transparent;
            this.buttonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonConnect.ImageKey = "Connect.png";
            this.buttonConnect.ImageList = this.imageListForIcons;
            this.buttonConnect.Location = new System.Drawing.Point(12, 57);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(107, 95);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSend.Enabled = false;
            this.ButtonSend.FlatAppearance.BorderSize = 0;
            this.ButtonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSend.ImageKey = "Send.png";
            this.ButtonSend.ImageList = this.imageListForIcons;
            this.ButtonSend.Location = new System.Drawing.Point(10, 158);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(107, 95);
            this.ButtonSend.TabIndex = 6;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSend.UseVisualStyleBackColor = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ImageKey = "Exit.png";
            this.buttonClose.ImageList = this.imageListForIcons;
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(12, 359);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(107, 95);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Haettenschweiler", 50F);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(693, 180);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 3;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(206, 188);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(6, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(485, 37);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Proximity Sensor Counting Software";
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPercentage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentage.Location = new System.Drawing.Point(774, 259);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(56, 37);
            this.labelPercentage.TabIndex = 0;
            this.labelPercentage.Text = "0%";
            // 
            // ButtonCreateLog
            // 
            this.ButtonCreateLog.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCreateLog.Enabled = false;
            this.ButtonCreateLog.FlatAppearance.BorderSize = 0;
            this.ButtonCreateLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateLog.ImageKey = "CreateLog.png";
            this.ButtonCreateLog.ImageList = this.imageListForIcons;
            this.ButtonCreateLog.Location = new System.Drawing.Point(125, 259);
            this.ButtonCreateLog.Name = "ButtonCreateLog";
            this.ButtonCreateLog.Size = new System.Drawing.Size(107, 95);
            this.ButtonCreateLog.TabIndex = 8;
            this.ButtonCreateLog.Text = "Create Log";
            this.ButtonCreateLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonCreateLog.UseVisualStyleBackColor = false;
            this.ButtonCreateLog.Click += new System.EventHandler(this.ButtonCreateLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(828, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPause.Enabled = false;
            this.ButtonPause.FlatAppearance.BorderSize = 0;
            this.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPause.ImageKey = "Pause.png";
            this.ButtonPause.ImageList = this.imageListForIcons;
            this.ButtonPause.Location = new System.Drawing.Point(123, 158);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(107, 95);
            this.ButtonPause.TabIndex = 24;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonPause.UseVisualStyleBackColor = false;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(970, 457);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonCreateLog);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox_testDetails);
            this.Controls.Add(this.labelComPorts);
            this.Controls.Add(this.label_targetCount);
            this.Controls.Add(this.ButtonRestart);
            this.Controls.Add(this.labelTimeElapsed);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.richTextBoxTargetCount);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxComPorts);
            this.Controls.Add(this.label_serialMonitor);
            this.Controls.Add(this.richTextBoxSerialMonitor);
            this.Controls.Add(this.ButtonSend);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(970, 43);
            this.Name = "FormMain";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSCS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.groupBox_testDetails.ResumeLayout(false);
            this.groupBox_testDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button ButtonRestart;
        private System.Windows.Forms.RichTextBox richTextBoxSerialMonitor;
        private System.Windows.Forms.RichTextBox richTextBoxTargetCount;
        private System.Windows.Forms.Label label_serialMonitor;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.Label label_targetCount;
        private System.Windows.Forms.Label labelComPorts;
        private System.Windows.Forms.Label labelPartName;
        private System.Windows.Forms.Label labelPartNumber;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.ComboBox comboBoxComPorts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_testDetails;
        private System.Windows.Forms.TextBox textBoxPartNumber;
        private System.Windows.Forms.TextBox textBoxPartName;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Button ButtonCreateLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.ImageList imageListForIcons;
    }
}


namespace workingasintended
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
            this.imageList_button_icons = new System.Windows.Forms.ImageList(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBoxSerialMonitor = new System.Windows.Forms.RichTextBox();
            this.label_serialMonitor = new System.Windows.Forms.Label();
            this.comboBoxComPorts = new System.Windows.Forms.ComboBox();
            this.richTextBoxTargetCount = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.label_timeElapsed = new System.Windows.Forms.Label();
            this.label_targetCount = new System.Windows.Forms.Label();
            this.label_comPorts = new System.Windows.Forms.Label();
            this.textBoxPartNumber = new System.Windows.Forms.TextBox();
            this.labelPartName = new System.Windows.Forms.Label();
            this.groupBox_testDetails = new System.Windows.Forms.GroupBox();
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.labelPartNumber = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.imageList_closebutton = new System.Windows.Forms.ImageList(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label_title = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.groupBox_testDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList_button_icons
            // 
            this.imageList_button_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_button_icons.ImageStream")));
            this.imageList_button_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_button_icons.Images.SetKeyName(0, "Connect.png");
            this.imageList_button_icons.Images.SetKeyName(1, "Disconnect.png");
            this.imageList_button_icons.Images.SetKeyName(2, "glossy-3d-blue-orbs2-045-icon.png");
            this.imageList_button_icons.Images.SetKeyName(3, "glossy-3d-blue-orbs2-053-icon.png");
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // richTextBoxSerialMonitor
            // 
            this.richTextBoxSerialMonitor.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.richTextBoxSerialMonitor, "richTextBoxSerialMonitor");
            this.richTextBoxSerialMonitor.Name = "richTextBoxSerialMonitor";
            this.richTextBoxSerialMonitor.ReadOnly = true;
            // 
            // label_serialMonitor
            // 
            resources.ApplyResources(this.label_serialMonitor, "label_serialMonitor");
            this.label_serialMonitor.Name = "label_serialMonitor";
            // 
            // comboBoxComPorts
            // 
            this.comboBoxComPorts.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxComPorts, "comboBoxComPorts");
            this.comboBoxComPorts.Name = "comboBoxComPorts";
            // 
            // richTextBoxTargetCount
            // 
            resources.ApplyResources(this.richTextBoxTargetCount, "richTextBoxTargetCount");
            this.richTextBoxTargetCount.Name = "richTextBoxTargetCount";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelTime
            // 
            resources.ApplyResources(this.labelTime, "labelTime");
            this.labelTime.Name = "labelTime";
            // 
            // label_timeElapsed
            // 
            resources.ApplyResources(this.label_timeElapsed, "label_timeElapsed");
            this.label_timeElapsed.Name = "label_timeElapsed";
            // 
            // label_targetCount
            // 
            resources.ApplyResources(this.label_targetCount, "label_targetCount");
            this.label_targetCount.Name = "label_targetCount";
            // 
            // label_comPorts
            // 
            resources.ApplyResources(this.label_comPorts, "label_comPorts");
            this.label_comPorts.Name = "label_comPorts";
            // 
            // textBoxPartNumber
            // 
            this.textBoxPartNumber.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxPartNumber, "textBoxPartNumber");
            this.textBoxPartNumber.Name = "textBoxPartNumber";
            // 
            // labelPartName
            // 
            resources.ApplyResources(this.labelPartName, "labelPartName");
            this.labelPartName.Name = "labelPartName";
            // 
            // groupBox_testDetails
            // 
            this.groupBox_testDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.groupBox_testDetails.Controls.Add(this.textBoxPartName);
            this.groupBox_testDetails.Controls.Add(this.textBoxPartNumber);
            this.groupBox_testDetails.Controls.Add(this.labelPartNumber);
            this.groupBox_testDetails.Controls.Add(this.labelPartName);
            this.groupBox_testDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.groupBox_testDetails, "groupBox_testDetails");
            this.groupBox_testDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.groupBox_testDetails.Name = "groupBox_testDetails";
            this.groupBox_testDetails.TabStop = false;
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxPartName, "textBoxPartName");
            this.textBoxPartName.Name = "textBoxPartName";
            // 
            // labelPartNumber
            // 
            resources.ApplyResources(this.labelPartNumber, "labelPartNumber");
            this.labelPartNumber.Name = "labelPartNumber";
            // 
            // buttonRestart
            // 
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonRestart, "buttonRestart");
            this.buttonRestart.ImageList = this.imageList_button_icons;
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.ImageList = this.imageList_button_icons;
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonSend, "buttonSend");
            this.buttonSend.ImageList = this.imageList_button_icons;
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.ImageList = this.imageList_closebutton;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // imageList_closebutton
            // 
            this.imageList_closebutton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_closebutton.ImageStream")));
            this.imageList_closebutton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_closebutton.Images.SetKeyName(0, "Close.png");
            // 
            // circularProgressBar1
            // 
            resources.ApplyResources(this.circularProgressBar1, "circularProgressBar1");
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 3;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Silver;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 3;
            // 
            // label_title
            // 
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.Name = "label_title";
            // 
            // labelPercentage
            // 
            resources.ApplyResources(this.labelPercentage, "labelPercentage");
            this.labelPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPercentage.Name = "labelPercentage";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox_testDetails);
            this.Controls.Add(this.label_comPorts);
            this.Controls.Add(this.label_targetCount);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.label_timeElapsed);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.richTextBoxTargetCount);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxComPorts);
            this.Controls.Add(this.label_serialMonitor);
            this.Controls.Add(this.richTextBoxSerialMonitor);
            this.Controls.Add(this.buttonSend);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox_testDetails.ResumeLayout(false);
            this.groupBox_testDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox richTextBoxSerialMonitor;
        private System.Windows.Forms.Label label_serialMonitor;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label_timeElapsed;
        private System.Windows.Forms.Label label_targetCount;
        private System.Windows.Forms.Label label_comPorts;
        private System.Windows.Forms.Label labelPartName;
        private System.Windows.Forms.Label labelPartNumber;
        private System.Windows.Forms.ComboBox comboBoxComPorts;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.RichTextBox richTextBoxTargetCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.ImageList imageList_button_icons;
        private System.Windows.Forms.TextBox textBoxPartNumber;
        private System.Windows.Forms.GroupBox groupBox_testDetails;
        private System.Windows.Forms.TextBox textBoxPartName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ImageList imageList_closebutton;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label labelPercentage;
    }
}


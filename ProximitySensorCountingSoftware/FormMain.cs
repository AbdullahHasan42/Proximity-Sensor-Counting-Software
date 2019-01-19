using System;
using System.IO;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ProximitySensorCountingSoftware
{
    public partial class FormMain : Form
    {
        string serialReader = "";
        string inputValue = "";
        string[] portNames;
        decimal percentage = 0m;
        decimal targetCount = 0m;
        string timerLabel = "";
        bool isConnected = false;
        bool isPaused = false;
        int ticks = 0;
        int day = 0;
        int internalCounter = 0;

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public FormMain()
        {
            InitializeComponent();
            GetAvailableComPorts();
            PopulateComboBox();     //Populates combobox with COM ports found
            circularProgressBar1.Value = 0;
        }

        private void GetAvailableComPorts()
        {
            portNames = SerialPort.GetPortNames();
        }

        private void PopulateComboBox()
        {
            foreach (string port in portNames)
            {
                comboBoxComPorts.Items.Add(port);
                if (portNames[0] != null)
                {
                    comboBoxComPorts.SelectedItem = portNames[0];
                }
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                ConnectToArduino();
            }
            else
            {
                DisconnectFromArduino();
            }
        }

        private void ConnectToArduino()
        {
            try
            {
                isConnected = true;

                //Capture the selected COM port from comboBox, and open a serial connection to it
                string selectedPort = comboBoxComPorts.GetItemText(comboBoxComPorts.SelectedItem);
                serialPort1.PortName = selectedPort;
                serialPort1.Open();

                buttonConnect.Text = "Disconnect";
                buttonConnect.ImageKey = "Disconnect.png";

                //Enable controls required for target count input
                EnableInputControls();
            }
            catch(ArgumentException)
            {
                MessageBox.Show("No COM Ports Selected!", "Missing COM port selection", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
        
        private void DisconnectFromArduino()
        {
            isConnected = false;

            serialPort1.Close();
            richTextBoxTargetCount.ResetText();
            
            buttonConnect.Text = "Connect";
            buttonConnect.ImageKey = "Connect.png";
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            inputValue = richTextBoxTargetCount.Text;

            if (IsInputValueForNumeric(inputValue) && IsValidFileName(textBoxPartName.Text))
            {
                //Sends Target Count value over the COM port, then converts it to integer for later comparison
                serialPort1.Write(inputValue);
                targetCount = Int32.Parse(inputValue);
                circularProgressBar1.Maximum = (int)targetCount;

                //Disable unrequired controls to prevent unwanted inputs and enable restart button 
                ButtonSend.Enabled = false;
                ButtonRestart.Enabled = true;
                richTextBoxTargetCount.Enabled = false;

                timer1.Start();
            }
        }

        private bool IsInputValueForNumeric(string inputValueToCheck)
        {
            //Checks for Numbers ONLY
            string pattern = @"^[0-9]{1,7}$";

            Match match = Regex.Match(inputValueToCheck, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter NUMBERS only", "Invalid input value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        private bool IsValidFileName(string expression)
        {
            //Checks part name for any invalid characters for a file name
            string sPattern = @"^(?!(?:PRN|AUX|CLOCK\$|NUL|CON|COM\d|LPT\d)(?:\..+)?$)[^\x00-\x1F\xA5\\?*:\"";|\/<>]+(?<![\s.])$";
            bool isVoidOfInvalidCharacters = Regex.IsMatch(expression, sPattern, RegexOptions.CultureInvariant);

            if (isVoidOfInvalidCharacters)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Part name contains invalid characters!", "Invalid Part Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                PauseTest();
            }
            else
            {
                ResumeTest();
            }
        }

        private void PauseTest()
        {
            isPaused = true;
            timer1.Stop();
            ButtonPause.ImageKey = "Resume.png";
        }

        private void ResumeTest()
        {
            isPaused = false;
            timer1.Start();
            ButtonPause.ImageKey = "Pause.png";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Test stopping condition
            if (internalCounter == targetCount)
            {
                timer1.Stop();

                //Message box for log creation inquiry
                string logMessageBoxText = "Test Completed!\n\nWould you like to create a log?";
                DialogResult logMessageBoxChoice = MessageBox.Show(logMessageBoxText, "Log Creation Inquiry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(logMessageBoxChoice == DialogResult.Yes)
                {
                    CreateLog();
                }
            }
            else
            {
                ticks++;
            }
            if (ticks % 86400 == 0)
            {
                day++;
            }

            UpdateTimeAndPercentage();
        }

        private void UpdateTimeAndPercentage()
        {
            //Formats the ticks variable from (seconds) to (days, HH:MM:SS)
            TimeSpan timeSpan = TimeSpan.FromSeconds(ticks);
            timerLabel = timeSpan.ToString("%d") + " day(s), " + timeSpan.ToString(@"hh\:mm\:ss");

            labelTime.Text = timerLabel;

            try
            { 
                percentage = Math.Round((circularProgressBar1.Value / targetCount) * 100, 2);
                labelPercentage.Text = percentage.ToString() + "%";
            }
            catch(DivideByZeroException)
            {
                timer1.Stop();
                MessageBox.Show("Test stopped suddenly!", "Sudden Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCreateLog_Click(object sender, EventArgs e)
        {
            CreateLog();
        }

        private void CreateLog()
        {
            //Found in the current folder, along with the .exe file
            string logDate = DateTime.Now.ToString("dd_MM_yyyy");
            string logPath = textBoxPartName.Text + " " + logDate + ".txt";

            if (File.Exists(logPath))
            {
                MessageBox.Show("File name already exists!\n\nChange the Part name!", "File name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreamWriter Logger = new StreamWriter(logPath);
                Logger.WriteLine("Part Name:\t" + textBoxPartName.Text);
                Logger.WriteLine("Part Number:\t" + textBoxPartNumber.Text);
                Logger.WriteLine("Counter reached over target counter:\t" + internalCounter + " / " + targetCount);
                Logger.WriteLine("Time taken:\t" + timerLabel);
                Logger.Close();
            }
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            serialPort1.Write("RESTART");
            ResetVariables();
            EnableInputControls();
        }

        private void ResetVariables()
        {
            serialReader = "";
            internalCounter = 0;
            inputValue = "";
            ticks = 0;
            day = 0;
            targetCount = 0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Maximum = 3;
            circularProgressBar1.ResetText();
            richTextBoxTargetCount.ResetText();
        }

        private void EnableInputControls()
        {
            ButtonSend.Enabled = true;
            richTextBoxTargetCount.Enabled = true;
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialReader = serialPort1.ReadLine(); // ReadLine includes the + "\n"

            DisplayToSerialMonitor(serialReader);

            if (serialReader.StartsWith("Counter ="))
            {
                internalCounter++;
                CircularProgressBarIncrease();
            }
        }

        private void CircularProgressBarIncrease()
        {
            BeginInvoke(new EventHandler(delegate { circularProgressBar1.PerformStep(); }));
        }

        private void DisplayToSerialMonitor(string dataToDisplay)
        {
            BeginInvoke(new EventHandler(delegate { richTextBoxSerialMonitor.Text = dataToDisplay; }));
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        //Code enabling cursor-based free movement of form
        //

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e) => dragging = false;

    }
}

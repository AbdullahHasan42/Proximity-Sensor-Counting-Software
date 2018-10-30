using System;
using System.IO;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace workingasintended
{
    public partial class FormMain : Form
    {
        string counter = "";
        string inputValue = "";
        string percentage = "0%";
        string timerLabel = "";
        bool isConnected = false;
        string[] ports;
        int ticks = 0;
        int day = 0;
        int counterEnd = 0;
        int internalCounter = 1;
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public FormMain()
        {
            InitializeComponent();
            GetAvailableComPorts();
            PopulateComboBox();     //Populates combobox with COM ports found
            buttonSend.Enabled = false;
            richTextBoxTargetCount.Enabled = false;
            richTextBoxSerialMonitor.Enabled = false;
            buttonRestart.Enabled = false;
            circularProgressBar1.Value = 0;
        }

        private void PopulateComboBox()
        {
            foreach (string port in ports)
            {
                comboBoxComPorts.Items.Add(port);
                if (ports[0] != null)
                {
                    comboBoxComPorts.SelectedItem = ports[0];
                }
            }
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            serialPort1.Write("RESTART");
            ResetVariables();
            EnableInputControls();
        }

        private void CircularProgressBarIncrease()
        {
            BeginInvoke(new EventHandler(delegate { circularProgressBar1.PerformStep(); }));
        }

        private void DisplayToSerialMonitor(string counter)
        {
            BeginInvoke(new EventHandler(delegate { richTextBoxSerialMonitor.Text = counter; }));
        }

        private void GetAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            inputValue = richTextBoxTargetCount.Text;

            if (CheckInputValueForNumeric(inputValue))
            { 
                //Reads the input from the richTextBox, sends it over the COM port
                //then converts it to integer for further comparison
                serialPort1.Write(inputValue + "\n");
                counterEnd = Int32.Parse(inputValue);
                circularProgressBar1.Maximum = counterEnd - 1;

                //Disable unrequired controls and enable restart button, to prevent unwanted inputs
                buttonSend.Enabled = false;
                richTextBoxSerialMonitor.Enabled = true;
                richTextBoxTargetCount.Enabled = false;
                buttonRestart.Enabled = true;

                timer1.Start();
            }
        }

        private bool CheckInputValueForNumeric(string inputValueToCheck)
        {
            //Checks for Numbers ONLY
            string pattern = @"^[0-9]{1,1000000}$";
            Match match = Regex.Match(inputValueToCheck, pattern); 
                if (match.Success)
                    return true;
                else
                {
                    MessageBox.Show("Please enter NUMBERS only");
                    return false;
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
                buttonConnect.ImageIndex = 1;

                //Enable controls required for target count input
                buttonSend.Enabled = true;
                richTextBoxTargetCount.Enabled = true;
            }
            catch(ArgumentException)
            {
                MessageBox.Show("No COM Ports Selected!");
            }
        }
        
        private void DisconnectFromArduino()
        {
            isConnected = false;

            richTextBoxTargetCount.Text = "";
            serialPort1.Close();

            buttonConnect.Text = "Connect";
            buttonConnect.ImageIndex = 0;
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            counter = serialPort1.ReadLine(); // ReadLine includes the + "\n"
            DisplayToSerialMonitor(counter);

            if (counter.StartsWith("Counter ="))
            {
                internalCounter++;
                CircularProgressBarIncrease();
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Test stopping condition
            if (internalCounter == counterEnd)
            {
                timer1.Stop();
                CreateLog();
                MessageBox.Show("Test Completed!");

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
                TimeSpan time_span = TimeSpan.FromSeconds(ticks);
                timerLabel = time_span.ToString("%d") + " day(s), " + time_span.ToString(@"hh\:mm\:ss");

                labelTime.Text = timerLabel;

                percentage = ((circularProgressBar1.Value / counterEnd) * 100).ToString();
                labelPercentage.Text = percentage + "%";
        }

        private void ResetVariables()
        {
            counter = "";
            inputValue = "";
            ticks = 0;
            day = 0;
            counterEnd = 0;
            circularProgressBar1.Value = 1;
            circularProgressBar1.Maximum = 3;
            circularProgressBar1.Text = "0%";
            richTextBoxTargetCount.ResetText();
            richTextBoxSerialMonitor.ResetText();
        }

        private void EnableInputControls()
        {
            buttonSend.Enabled = true;
            richTextBoxTargetCount.Enabled = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateLog()
        {
            //Found in the current folder, along with the .exe file
            string log_date = DateTime.Now.ToString("dd_MM_yyyy");
            string logPath = textBoxPartName.Text + " " + log_date + ".txt";

            StreamWriter Logger = new StreamWriter(logPath);
            Logger.WriteLine("Part Name: \t" + textBoxPartName.Text);
            Logger.WriteLine("Part Number: \t" + textBoxPartNumber.Text);
            Logger.WriteLine("Counter reached over target counter: " + counter + "/" + counterEnd);
            Logger.WriteLine("Time taken: " + timerLabel);
            Logger.Close();
        }

        //
        //Code enabling cursor-based free movement of form
        //

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) => dragging = false;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NUMBER AT: " + internalCounter.ToString());
        }
    }
}

using System;
using System.IO;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;

namespace workingasintended
{
    public partial class Form1 : Form
    {
        string counter = "";
        string inputvalue = "";
        string percentage = "0%";
        bool isConnected = false;
        string[] ports;
        int ticks = 0;
        int day = 0;
        int counter_end = 0;
        string timer_label = "";
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
            GetAvailableComPorts();
            send_button.Enabled = false;
            richTextBox2.Enabled = false;
            richTextBox1.Enabled = false;
            restart_button.Enabled = false;
            circularProgressBar1.Value = 0;
            timer1.Stop();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
            
        }

        private void Restart_button_Click(object sender, EventArgs e)
        {
            serialPort1.Write("RESTART");
            ReDeclareVariables();
            Re_enable_controls();
        }

        private void Progressincrease()
        {
            BeginInvoke(new EventHandler(delegate{ circularProgressBar1.PerformStep(); }));
        }

        private void DisplayToWindow(string counter)
        {
            BeginInvoke(new EventHandler(delegate{richTextBox1.Text = counter;}));
        }

        private void GetAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }
        
        private void Send_button__Click(object sender, EventArgs e)
        {
            inputvalue = richTextBox2.Text;
            serialPort1.Write(inputvalue + "\n");
            counter_end = Int32.Parse(inputvalue);
            circularProgressBar1.Maximum = counter_end + 1;
            send_button.Enabled = false;
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = false;
            restart_button.Enabled = true;
            timer1.Start();
        }

        private void Connect_button_Click_1(object sender, EventArgs e)
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
            try{
                isConnected = true;
                string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
                serialPort1.PortName = selectedPort;
                serialPort1.Open();
                connect_button.Text = "Disconnect";
                send_button.Enabled = true;
                richTextBox2.Enabled = true;
                connect_button.ImageIndex = 1;
            }
            catch(ArgumentException)
            {
                MessageBox.Show("No COM Ports Selected!");
            }
        }
        
        private void DisconnectFromArduino()
        {
            isConnected = false;
            richTextBox2.Text = "";
            serialPort1.Close();
            connect_button.Text = "Connect";
            connect_button.ImageIndex = 0;
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            counter = serialPort1.ReadLine(); // ReadLine includes the + "\n"

            if (counter.StartsWith("Counter ="))
            {
                DisplayToWindow(counter);
                Progressincrease();
                UpdateTimeAndPercentage();
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value == counter_end)
            {
                timer1.Stop();
                Create_log();
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
        }

        private void UpdateTimeAndPercentage()
        { 
            TimeSpan time_span = TimeSpan.FromSeconds(ticks);
            timer_label = time_span.ToString("%d") + " day(s), " + time_span.ToString(@"hh\:mm\:ss");
            label2.Text = timer_label;
            percentage = ((circularProgressBar1.Value / counter_end) * 100).ToString() + "%";
            circularProgressBar1.Text = percentage;
        }
        
        private void ReDeclareVariables()
        {
            counter = "";
            inputvalue = "";
            ticks = 0;
            day = 0;
            counter_end = 0;
            circularProgressBar1.Value = 1;
            circularProgressBar1.Maximum = 3;
            circularProgressBar1.Text = "0%";
            richTextBox2.ResetText();
            richTextBox1.ResetText();
        }

        private void Re_enable_controls()
        {
            send_button.Enabled = true;
            richTextBox2.Enabled = true;
        }

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

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Create_log() 
        {
            //Found in the bin folder, along with the .exe file

            string log_date = DateTime.Now.ToString("dd_MM_yyyy");
            StreamWriter Logger = new StreamWriter(part_name + " " + log_date + ".txt");
            Logger.WriteLine("Part Name: \t" + part_name.Text);
            Logger.WriteLine("Part Number: \t" + part_number.Text);
            Logger.WriteLine("Counter reached over target counter: " + counter + "/" + counter_end);
            Logger.WriteLine("Time taken: " + timer_label);
            Logger.Close();
        }
    }
}

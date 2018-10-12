using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace workingasintended
{
    public partial class Form1 : Form
    {
        string counter = "";
        string inputvalue = "";
        bool isConnected = false;
        string[] ports;
        int ticks = 0;
        int day = 0;
        int counter_end = 0;

        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();
            send_button.Enabled = false;
            richTextBox2.Enabled = false;
            richTextBox1.Enabled = false;
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
            Re_declare_variables();
            Re_enable_controls();
        }

        private void Progressincrease()
        {
            BeginInvoke(new EventHandler(delegate{progressBar1.PerformStep();}));
        }

        private void DisplayToWindow(string counter)
        {
            BeginInvoke(new EventHandler(delegate{richTextBox1.Text = counter;}));
        }
        
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }
        
        private void Send_button__Click(object sender, EventArgs e)
        {
            inputvalue = richTextBox2.Text;
            serialPort1.Write(inputvalue + "\n");
            counter_end = Int32.Parse(inputvalue);
            progressBar1.Maximum = counter_end + 1;
            send_button.Enabled = false;
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = false;
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
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            counter = serialPort1.ReadLine(); // ReadLine includes the + "\n"

            if (counter.StartsWith("Counter ="))
            {
                DisplayToWindow(counter);
                Progressincrease();
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == counter_end)
            {
                timer1.Stop();
                //create_log();
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

            TimeSpan time_span = TimeSpan.FromSeconds(ticks);
            string timer_label = time_span.ToString("%d") + " day(s), " + time_span.ToString(@"hh\:mm\:ss");
            label2.Text = timer_label;
            string percentage = ((progressBar1.Value / counter_end) * 100).ToString() + "%";
            percentage_completion.Text = percentage;
        }
        
        private void Re_declare_variables()
        {
            counter = "";
            inputvalue = "";
            ticks = 0;
            day = 0;
            counter_end = 0;
            progressBar1.Value = 1;
            progressBar1.Maximum = 3;
            percentage_completion.Text = "0%";
            richTextBox2.ResetText();
            richTextBox1.ResetText();
        }

        private void Re_enable_controls()
        {
            send_button.Enabled = true;
            richTextBox2.Enabled = true;
        }
        /*
        private void create_log() 
        {
            //Found in the bin folder, with the .exe file

            string log_date = DateTime.Now.ToString("dd_MM_yyyy");
            StreamWriter Logger = new StreamWriter("TEST LOG " + log_date + ".txt");
            Logger.Write("THIS IS A TEST LOG!");
            Logger.Close();
        }
        */
    }
}

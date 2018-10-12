using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workingasintended
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        public void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string counter = serialPort1.ReadLine(); // ReadLine includes the + "\n"
            displayToWindow(counter);
        }

        private void displayToWindow(string counter)
        {
            BeginInvoke(new EventHandler(delegate
            {
                richTextBox1.Text = counter;
                //richTextBox1.ScrollToCaret();
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            serialPort1.Write("1000000");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("OFF");
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.AppendText(serialPort1.ReadLine());
        }
    }
}

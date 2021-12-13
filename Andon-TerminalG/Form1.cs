using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// System
using System.Net;
using System.Net.Sockets;



namespace Andon_TerminalG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "hello";

                UdpClient udpClient = new UdpClient();
            
            try {
                udpClient.Connect(hostname: "127.0.0.1" ,port:4023);
                Byte[] sendBytes = Encoding.ASCII.GetBytes(textBox1.Text.ToString());
                udpClient.Send(sendBytes, sendBytes.Length);
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                recivetext.Text = returnData.ToString();

            }
            catch ( Exception fault ) {
                textBox1.Text = fault.ToString();
                    }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

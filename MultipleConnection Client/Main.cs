using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using FSUIPC;

namespace MultipleConnection_Client
{
    public partial class Main : Form
    {
        Socket sck;

        public Main()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            sck.Connect("127.0.0.1", 8);
            MessageBox.Show("Connected");
            FSUIPCConnection.Open();            
            LATandLON.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int s = sck.Send(Encoding.Default.GetBytes(txtMsg.Text));

            if(s > 0)
            {
                MessageBox.Show("Data Sent");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FSUIPCConnection.Close();
            sck.Close();
            sck.Dispose();
            Close();
        }
       
        private void LATandLON_Tick(object sender, EventArgs e)
        {            
            FSUIPCGets.GetCurrent();
            txtLAT.Text = FSUIPCGets.GetCurrent().Latitude.ToString();
            txtLON.Text = FSUIPCGets.GetCurrent().Longitude.ToString();
        }
    }
}

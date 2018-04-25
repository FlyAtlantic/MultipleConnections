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
using System.Runtime.InteropServices;

namespace MultipleConnection_Client
{

    public partial class Main : Form
    {

        public string lat = null;
        public string lon = null;
        public string hdg = null;
        public string alt = null;
        public string gs = null;
        FsLatitude LAT;
        FsLongitude LON;

        public bool terminate = false;
        public bool terminated = false;

        Socket sck;

        public Main()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            sck.Connect("95.94.130.22", 6702);
            MessageBox.Show("Connected");
            FSUIPCConnection.Open();
            LATandLON.Start();

            btnConnect.Enabled = false;
            txtCallsign.Enabled = false;
            txtAircraft.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //string[] data = new string[4];
            //data[0] = txtMsg.Text;
            //data[1] = lat;
            //data[2] = lon;
            //data[3] = hdg;

            //int s = sck.Send(Encoding.Default.GetBytes(data[0] + '/'  + data[1] + '/' + data[2] + '/' + data[3]));

            //if(s > 0)
            //{
            //    MessageBox.Show("Data Sent");
            //}

   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

           // terminate = true;
           // while (terminated == false) { }
            FSUIPCConnection.Close();
            sck.Close();
            sck.Dispose();
            Close();
        }
       
        private void LATandLON_Tick(object sender, EventArgs e)
        {

            FSUIPCGets.GetCurrent();
            
            lat = txtLAT.Text = FSUIPCGets.GetCurrent().Latitude.ToString();
            lon =  txtLON.Text = FSUIPCGets.GetCurrent().Longitude.ToString();
            hdg = FSUIPCGets.GetCurrent().Compass.ToString("0");
            alt = FSUIPCGets.GetCurrent().Altitude.ToString("0");
            gs = FSUIPCGets.GetCurrent().GroundSpeed.ToString("0");

            FSUIPCConnection.AITrafficServices.RefreshAITrafficInformation();
            var aiTfc = FSUIPCConnection.AITrafficServices.AllTraffic;
            Console.WriteLine(aiTfc.ToString());

            string[] data = new string[8];
            data[0] = txtMsg.Text;
            data[1] = txtCallsign.Text;
            data[2] = txtAircraft.Text;
            data[3] = lat;
            data[4] = lon;
            data[5] = hdg;
            data[6] = alt;
            data[7] = gs;

            int s = sck.Send(Encoding.Default.GetBytes(data[0] + '/' + data[1] + '/' + data[2] + '/' + data[3] + '/' + data[4] + '/' + data[5] + '/' + data[6] + '/' + data[7]));
        }

        private void txtCallsign_TextChanged(object sender, EventArgs e)
        {
            if (txtCallsign.Text != "" && txtAircraft.Text != "" && txtAircraft.TextLength >= 4)
            {
                btnConnect.Enabled = true;
            }
        }

        private void txtAircraft_TextChanged(object sender, EventArgs e)
        {
            if (txtCallsign.Text != "" && txtAircraft.Text != "" && txtAircraft.TextLength >= 4)
            {
                btnConnect.Enabled = true;
            }
        }
    }
}

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

        public static string ServerName;
        public static string ServerIP;
        public static string ServerPort;

        public string lat = null;
        public string lon = null;
        public string hdg = null;
        public string alt = null;
        public string gs = null;

        FlightPlanFrm f = new FlightPlanFrm();

        public bool terminate = false;
        public bool terminated = false;
         
        Socket sck;

        public Main()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            cboxServer.Text = "Beta";

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            switch (btnConnect.Text)
            {

                case "Connect":                                     

                    switch (cboxServer.Text)
                    {
                        case "Beta":
                            sck.Connect("192.168.56.102", 6809);

                            FSUIPCConnection.Open();

                            LATandLON.Start();

                            txtCallsign.Enabled = false;
                            txtAircraft.Enabled = false;
                            txtChatText.Enabled = true;
                            btnChatSend.Enabled = true;

                            lblStatus.Text = "Connected";
                            lblStatus.ForeColor = Color.ForestGreen;
                            txtChat.Text = "You are now connect on network server!";

                            btnConnect.Text = "Flight Plan";
                            btnClose.Enabled = true;
                            break;

                        default:
                            LATandLON.Stop();
                            FSUIPCConnection.Close();
                            sck.Close();
                            sck.Dispose();

                            txtCallsign.Enabled = true;
                            txtAircraft.Enabled = true;
                            txtChatText.Enabled = false;
                            btnChatSend.Enabled = false;
                            btnClose.Enabled = false;
                            btnConnect.Enabled = false;

                            lblStatus.Text = "Server Error";
                            lblStatus.ForeColor = Color.DarkRed;

                            btnConnect.Text = "Connect";
                            txtChat.Text = txtChat.Text + "\r\nSelect one server!";
                            break;
                    }

                    break;

                case "Flight Plan":
                    f.Show();
                    break;

                default:
                    break;
            }

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
            LATandLON.Stop();
            FSUIPCConnection.Close();
            sck.Close();
            sck.Dispose();

            txtCallsign.Enabled = true;
            txtAircraft.Enabled = true;
            txtChatText.Enabled = false;
            btnChatSend.Enabled = false;
            btnClose.Enabled = false;
            btnConnect.Enabled = false;

            lblStatus.Text = "Disconnected";
            lblStatus.ForeColor = Color.DarkRed;

            btnConnect.Text = "Connect";
            txtChat.Text = txtChat.Text + "\r\nYou are now disconnected on network server!";

            
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
            if ((txtCallsign.Text != "" && txtAircraft.Text != "") && txtAircraft.TextLength >= 4)
            {
                btnConnect.Enabled = true;
            }
            else { btnConnect.Enabled = false; }
        }

        private void txtAircraft_TextChanged(object sender, EventArgs e)
        {
            if ((txtCallsign.Text != "" && txtAircraft.Text != "") && txtAircraft.TextLength >= 4)
            {
                btnConnect.Enabled = true;
            }
            else { btnConnect.Enabled = false; }
        }
    }
}

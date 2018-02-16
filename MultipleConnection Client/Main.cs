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
            sck.Connect("127.0.0.1", 8);
            MessageBox.Show("Connected");
            FSUIPCConnection.Open();            
            LATandLON.Start();
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

            LAT = new FsLatitude(FSUIPCGets.GetCurrent().Latitude);
            LON = new FsLongitude(FSUIPCGets.GetCurrent().Longitude);
            double fshdg = Convert.ToInt64(hdg);
            double fsalt = Convert.ToInt64(1000); ;
            short fsgs = Convert.ToInt16(gs);
            short fsvs = Convert.ToInt16(0); ;
            short com1 = Convert.ToInt16(122.80);


        FSUIPCConnection.AITrafficServices.AddTCASTarget(0, "FlyAtlantic", AITrafficStatus.FilingFlightPlan, LAT, LON, fsalt, fshdg, fsgs, fsvs, com1);
        FSUIPCConnection.AITrafficServices.SendTCASTargets();
        
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
            Console.WriteLine(aiTfc);

            string[] data = new string[6];
            data[0] = txtMsg.Text;
            data[1] = lat;
            data[2] = lon;
            data[3] = hdg;
            data[4] = alt;
            data[5] = gs;

            int s = sck.Send(Encoding.Default.GetBytes(data[0] + '/' + data[1] + '/' + data[2] + '/' + data[3] + '/' + data[4] + '/' + data[5]));
        }
    }
}

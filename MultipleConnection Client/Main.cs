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
            sck.Connect("127.0.0.1", 8);
            MessageBox.Show("Connected");
            FSUIPCConnection.Open();
            LATandLON.Start();
        }

        public struct TCAS
        {
            public UInt32 id; // 0 = empty, otherwise this is an FS-generated ID.
                              // (Do not use this for anything other than checking if the slot is empty or used—it may be reused
                              // for other things at a later date).
            public float lat; // 32-bit float, in degrees, –ve = South
            public float lon; // 32-bit float, in degrees, –ve = West
            public float alt; // 32-bit float, in feet
            public UInt16 hdg; // 16-bits. Heading. Usual 360 degrees == 65536 format.
                               // Note that this is degrees TRUE, not MAG
            public UInt16 gs; // 16-bits. Knots Ground Speed
            public short vs; // 16-bits, signed feet per minute V/S
            public string idATC; // Zero terminated string identifying the aircraft. By default this is:
                                 // Airline & Flight Number, or Tail number
                                 // For Tail number, if more than 14 chars you get the *LAST* 14
                                 // Airline name is truncated to allow whole flight number to be included
            public byte bState; // Zero in FS2002, a status indication in FS2004—see list below.
            public UInt16 com1; // the COM1 frequency set in the AI aircraft’s radio. (0Xaabb as in 1aa.bb)
                                // NOTE that since FSUIPC 3.60, in FS2004 this is set to           
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


            FSUIPCConnection.AITrafficServices.AddTCASTarget(5666666, "FlyAtlantic", AITrafficStatus.Enroute, LAT, LON, fsalt, fshdg, fsgs, fsvs, com1);
            FSUIPCConnection.AITrafficServices.SendTCASTargets();

            FSUIPCConnection.AITrafficServices.RefreshAITrafficInformation(true, true);

            TCAS tcas = new TCAS();
            tcas.id = Convert.ToUInt32(0);
            tcas.lat = Convert.ToSingle(lat);
            tcas.lon = Convert.ToSingle(lon);
            tcas.alt = Convert.ToSingle(1000);
            tcas.hdg = Convert.ToUInt16(fshdg);
            tcas.gs = Convert.ToUInt16(0);
            tcas.idATC = "150000000000000";
            tcas.bState = Convert.ToByte(0x8C);
            tcas.com1 = Convert.ToUInt16(112.80);
            byte[] tcasToBytes = tcasGetBytes(tcas);
            FSUIPCGets.SetValue(FSUIPCOffsets.AiTfrafficInsert, tcasToBytes);          
        }

        public byte[] tcasGetBytes(TCAS str)
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
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

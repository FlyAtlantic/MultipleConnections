using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Microsoft.FlightSimulator;
using Microsoft.FlightSimulator.SimConnect;
using System.Threading;
using System.Globalization;


namespace SimConnect
{
    class Program
    {
        void Main(string[] args)
        {
            StartSimConnect();
        }

        private void StartSimConnect()
        {
            // Open
            // Declare a SimConnect object 
            Microsoft.FlightSimulator.SimConnect.SimConnect simconnect = null;
            // User-defined win32 event
            const int WM_USER_SIMCONNECT = 0x0402;
            try
            {
                simconnect = new Microsoft.FlightSimulator.SimConnect.SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            if (simconnect != null)
            {
                simconnect.ReceiveMessage();
            }

        }
    }
}

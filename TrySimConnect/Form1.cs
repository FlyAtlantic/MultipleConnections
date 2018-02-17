using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.FlightSimulator.SimConnect;

namespace TrySimConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartSimConnect()
        {
            // Open
            // Declare a SimConnect object 
            SimConnect simconnect = null;
            // User-defined win32 event
            const int WM_USER_SIMCONNECT = 0x0402;
            try
            {
                simconnect = new SimConnect("MattTest", this.Handle, WM_USER_SIMCONNECT, null, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            StartSimConnect();
        }
    }
}

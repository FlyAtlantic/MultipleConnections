using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConnection_Client
{
    public partial class FlightPlanFrm : Form
    {

        public FlightPlanFrm()
        {
            InitializeComponent();           
        }

        private void btnCloseFP_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

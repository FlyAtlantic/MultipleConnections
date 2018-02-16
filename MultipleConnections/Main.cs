using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConnections
{
    public partial class Main : Form
    {

        Listener listener;
        public Main()
        {
            InitializeComponent();
            listener = new Listener(8);
            listener.SocketAccepted += new Listener.SocketAcceptedHandler(listener_SocketAccepted);
            Load += new EventHandler(Main_Load);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            listener.Start();
        }

        void listener_SocketAccepted(System.Net.Sockets.Socket e)
        {
            Client client = new Client(e);
            client.Received += new Client.ClientReceivedHandler(client_Received);
            client.Disconnected += new Client.ClientDisconnectedHandler(client_Disconnected);

            Invoke((MethodInvoker)delegate
            {
                ListViewItem i = new ListViewItem();
                i.Text = client.EndPoint.ToString();
                i.SubItems.Add(client.ID);
                i.SubItems.Add("XX");
                i.SubItems.Add("XX");
                i.SubItems.Add("XX");
                i.SubItems.Add("XX");
                i.Tag = client;
                lstClients.Items.Add(i);

            });
        }

        private void client_Received(Client sender, byte[] data)
        {
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < lstClients.Items.Count; i++)
                {
                    Client client = lstClients.Items[i].Tag as Client;

                    if (client.ID == sender.ID)
                    {

                        string[] newData = Encoding.Default.GetString(data).Split('/');
                        lstClients.Items[i].SubItems[2].Text = newData[0];
                        lstClients.Items[i].SubItems[3].Text = newData[1];
                        lstClients.Items[i].SubItems[4].Text = newData[2];
                        lstClients.Items[i].SubItems[5].Text = DateTime.Now.ToString();
                        break;
                    }
                }
            });
        }

        private void client_Disconnected(Client sender)
        {
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < lstClients.Items.Count; i++)
                {
                    Client client = lstClients.Items[i].Tag as Client;

                    if(client.ID == sender.ID)
                    {
                        lstClients.Items.RemoveAt(i);
                        break;
                    }
                }
            });
        }
    }
}

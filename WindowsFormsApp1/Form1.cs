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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public NetworkServer NetworkServer { get; set; }
        public Form1()
        {
            InitializeComponent();
            var ipAddressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            IPAddress ipAddress = IPAddress.Any;
            foreach (var address in ipAddressList)
            {
                if (address.AddressFamily.Equals(AddressFamily.InterNetwork))
                    ipAddress = address;
            }
            labelIP.Text = "IP Address: " + ipAddress.ToString();

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (NetworkServer == null)
            {
                NetworkServer = new NetworkServer(Convert.ToInt32(textBoxPort.Text));
                NetworkServer.StartServer();
                labelStatusServer.Text = "Server is running.";
                labelStatusServerColor.BackColor = Color.Green;
                btnStartServer.Text = "Stop Server";
                textLogs.Text += "\r\n Server listening on: " + NetworkServer.TcpListener.LocalEndpoint;
                NetworkServer.AcceptConnection().ContinueWith(result =>
                {
                    textLogs.Text += Environment.NewLine + "Client " + result.Result + " connected!";
                    NetworkServer.AcceptConnection().ContinueWith(result2 =>
                    {
                        textLogs.Text += Environment.NewLine + "Client " + result2.Result + " connected!";
                        NetworkServer.StartPainting();
                        NetworkServer.TransferData();

                    });
                });
            }
            else
            {
                NetworkServer.Disconnect();
                NetworkServer.StopServer();
                NetworkServer = null;
                labelStatusServer.Text = "Server is stopped.";
                labelStatusServerColor.BackColor = Color.Red;
                btnStartServer.Text = "Start Server";
            }
        }
    }
}

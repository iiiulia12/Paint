using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public class NetworkServer
    {
        public TcpListener TcpListener { get; set; }
        public TcpClient Client1 { get; set; }
        public TcpClient Client2 { get; set; }
        public NetworkServer(Int32 port)
        {
            var ipAddress = IPAddress.Any;
            TcpListener = new TcpListener(ipAddress, port);
        }

        public void StartServer()
        {
            TcpListener.Start();
        }

        public async Task<int> AcceptConnection()
        {
            if (Client1 == null)
            {
                Client1 = await TcpListener.AcceptTcpClientAsync();
                return 1;
            }
            else if (Client2 == null)
            {
                Client2 = await TcpListener.AcceptTcpClientAsync();
                return 2;
            }
            return 0;
        }

        public void StartPainting()
        {
           // Console.WriteLine("sunt in startpainting din prj networkserver");
            string start = "start";
            string painter1 = "painter1";
            string painter2 = "painter2";
            BinaryWriter binaryWriter1 = new BinaryWriter(Client1.GetStream());
            BinaryWriter binaryWriter2 = new BinaryWriter(Client2.GetStream());
            binaryWriter1.Write(start);
            binaryWriter2.Write(start);
            binaryWriter1.Write(painter1);
            binaryWriter2.Write(painter2);
        }

        public void TransferData()
        {
           // Console.WriteLine("sunt in transferdata din prj server");
            NetworkStream networkStream1 = Client1.GetStream();
            NetworkStream networkStream2 = Client2.GetStream();
            while (Client1.Connected && Client2.Connected)
            {
                if (networkStream1.DataAvailable)
                {
                    networkStream1.CopyToAsync(networkStream2);
                }
                else if (networkStream2.DataAvailable)
                {
                    networkStream2.CopyToAsync(networkStream1);
                }
            }
        }

        public void Disconnect()
        {
            Client1.Close();
            Client2.Close();
        }

        public void StopServer()
        {
            TcpListener.Stop();
        }

    }
}

using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Paint
{
    

   
    public class NetworkClient
    {
        public TcpClient TcpClient { get; set; }

        private WelcomeWindow ww;

        
        public NetworkClient(Form f)
        {
            TcpClient = new TcpClient();
            ww = (WelcomeWindow)f;
        }

        public void Connect(string IP, Int32 port)
        {
            TcpClient.Connect(IPAddress.Parse(IP), port);
        }

        public void Write(string data)
        {
            if (TcpClient.Connected)
            { 
                BinaryWriter binaryWriter = new BinaryWriter(TcpClient.GetStream());
                binaryWriter.Write(data);
                binaryWriter.Flush();
            }
        }

        public void Read()
        {
            try
            {
                
                Thread.Sleep(1000);

                BinaryReader binaryReader = new BinaryReader(TcpClient.GetStream());


               
                if (TcpClient.Connected)
                {
                   

                    var text = binaryReader.ReadString();
                    //Console.WriteLine("SUNT IN READ DIN netwokclient " + text);
                    // Console.WriteLine("SUNT IN READ DIN netwokclient pimul if" + text);
                    string Text = text.ToString();

                    if (text.Equals("start"))
                    {
                        MessageBox.Show("Enjoy Paint! " +
                            "Painter1 starts! each painter can make 1 move at a time!");
                        ww.Hide();
                        ww.pw.Show();
                    }
                    else if (!Text.Equals("stop"))
                    {
                        
                        ww.DataRead(Text);
                        
                    }



                   
                }

            }

            catch (IOException ex)
            {
                System.Environment.Exit(0);
            }
        }


     }
}
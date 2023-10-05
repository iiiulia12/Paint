using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Paint
{
    public partial class WelcomeWindow : Form
    {
        public PaintWindow pw;
        public NetworkClient networkClient;
       // public int read_write = 0;
        public bool server = false;

        //1reading, 2 writing
        public WelcomeWindow()
        {
            networkClient = new NetworkClient(this);

            // networkClient.OnGameStarted += networkClient.OnGameStarted;
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            pw = new PaintWindow(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pw.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void WelcomeWindow_Load(object sender, EventArgs e)
        {
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            server = true;
            networkClient.Connect(textBipAdr.Text, Convert.ToInt32(textBPort.Text));
            
            networkClient.Read();
            
            networkClient.Read();
            // networkClient.Write("@/e/2/Color [Red]/150/150/70/80");
            // networkClient.Read();
        }

        public void DataRead(string data)
        {
           // Console.WriteLine("sunt in functia data read" + data);

            if (data[0].Equals('@'))
            {
                Draw(data);
            }
            else 
            {
               
                switch (data)
                {
                    case "clear": { Clear(); break; }
                    case "painter1": { pw.btnDRAW.BackColor = Color.Green; break;}
                    case "painter2": { pw.btnSEE.BackColor = Color.Red;  networkClient.Read(); break; }
                 }
            }
          
        }

        public void Clear()
        {
            pw.g.Clear(Color.White);
            pw.pic.Image = pw.bm;
            pw.index = 0;
            pw.paint = false;
            pw.pick_color.BackColor = Color.White;
            pw.pic.Refresh();
        }

        public void Draw(string text)
        {
            //Console.WriteLine("sunt in functia draw " + text);
          
            int A, R, G, B;
            Pen p;
            string color;
            int w, h, x, y;
            Color Color;

            string[] subs = text.Split('!');

            if (subs[0].Equals("@") && !subs[1].Equals("f"))
            {
                int pen_Width = Convert.ToInt32(subs[2]);

                //color [black]
                //color [a=20, r=23, r=45, g=56]

                color = subs[3];

                color = color.Substring(0, color.Length - 1);
                color = color.Substring(color.IndexOf('r') + 3);
               // Console.WriteLine(color[1]);
                String verif = "" + color[1];
                if (verif.Equals("="))
                {  
                   // Console.WriteLine("aici sunt in if argb true");
                    string[] aux = color.Split(',');
                    string[] aux2 = aux[0].Split('=');
                    A = Convert.ToInt32(aux2[1]);
                    aux2 = aux[1].Split('=');
                    R = Convert.ToInt32(aux2[1]);
                    aux2 = aux[2].Split('=');
                    G = Convert.ToInt32(aux2[1]);
                    aux2 = aux[3].Split('=');
                    B = Convert.ToInt32(aux2[1]);
                    Color = Color.FromArgb(A, R, G, B);
                }
                else
                {
                   // Console.WriteLine("aici sunt in else argb false");
                    Color = ColorTranslator.FromHtml(color);
                }
                p = new Pen(Color, pen_Width);

                x = Convert.ToInt32(subs[4]);
                y = Convert.ToInt32(subs[5]);
                w = Convert.ToInt32(subs[6]);
                h = Convert.ToInt32(subs[7]);

                if (subs[1].Equals("r"))
                {
                    //r = true;
                    if (w > 0 && h > 0)
                        pw.g.DrawRectangle(p,x, y, w, h);
                    else
                    {
                        if (w > 0 && h < 0)

                            pw.g.DrawRectangle(p, x, y + h, w, -h);
                        else
                        {
                            if (w < 0 && h > 0)
                                pw.g.DrawRectangle(p, x + w, y, -w, h);
                            else pw.g.DrawRectangle(p, x + w, y + h, -h, -w);
                        }
                    }
                   // pw.g.DrawRectangle(p, x, y, w, h);
                    pw.pic.Refresh();
                }
                else
                {
                    if (subs[1].Equals("e"))
                    {
                        // e = true;
                        // pw.g.DrawEllipse(p, x, y, w, h);
                        if (w > 0 && h > 0)
                            pw.g.DrawEllipse(p, x, y, w, h);
                        else
                        {
                            if (w > 0 && h < 0)

                                pw.g.DrawEllipse(p, x, y + h, w, -h);
                            else
                            {
                                if (w < 0 && h > 0)
                                    pw.g.DrawEllipse(p, x + w, y, -w, h);
                                else pw.g.DrawEllipse(p, x + w, y + h, -h, -w);
                            }
                        }
                        pw.pic.Refresh();
                    }
                    else
                    {
                        if (subs[1].Equals("l"))
                        {
                           // l = true;
                            pw.g.DrawLine(p, x, y, w, h);
                            pw.pic.Refresh();
                        }
                    }
                }
            }
            else if (subs[1].Equals("f") && subs[0].Equals("@"))
            { //@/f/600/275/Color [A=255, R=255, G=255, B=255]/Color [A=255, R=128, G=128, B=255]
                Point point1 = new Point();
                point1.X = Convert.ToInt32(subs[2]);
                point1.Y = Convert.ToInt32(subs[3]);
               // Console.WriteLine(subs[2]);
                //Console.WriteLine(subs[3]);
                Color targetColor, penColor;
                color = subs[4];
               // Console.WriteLine(color);
                color = color.Substring(0, color.Length - 1);
                color = color.Substring(color.IndexOf('r') + 3);
                String verif = "" + color[1];
                if (verif.Equals("="))
                {  //a=20, r=23, g=45, g=56
                    string[] aux = color.Split(',');
                    string[] aux2 = aux[0].Split('=');
                    A = Convert.ToInt32(aux2[1]);
                    aux2 = aux[1].Split('=');
                    R = Convert.ToInt32(aux2[1]);
                    aux2 = aux[2].Split('=');
                    G = Convert.ToInt32(aux2[1]);
                    aux2 = aux[3].Split('=');
                    B = Convert.ToInt32(aux2[1]);
                    targetColor = Color.FromArgb(A, R, G, B);
                }
                else { targetColor = ColorTranslator.FromHtml(color); }

                color = subs[5];
                //Console.WriteLine(color);
                color = color.Substring(0, color.Length - 1);
                color = color.Substring(color.IndexOf('r') + 3);
                verif = "" + color[1];

                if (verif.Equals("="))
                {  //Color [a=20, r=23, g=45, g=56]
                    string[] aux = color.Split(',');
                    string[] aux2 = aux[0].Split('=');
                    A = Convert.ToInt32(aux2[1]);
                    aux2 = aux[1].Split('=');
                    R = Convert.ToInt32(aux2[1]);
                    aux2 = aux[2].Split('=');
                    G = Convert.ToInt32(aux2[1]);
                    aux2 = aux[3].Split('=');
                    B = Convert.ToInt32(aux2[1]);
                    penColor = Color.FromArgb(A, R, G, B);
                }
                else
                {
                    penColor = ColorTranslator.FromHtml(color);
                }

                Stack<Point> pixels = new Stack<Point>();
                Point point2 = new Point();
                pixels.Push(point1);
                while (pixels.Count > 0)
                {
                    point2 = pixels.Pop();
                    if (point2.X < pw.bm.Width && point2.X > 0 && point2.Y < pw.bm.Height && point2.Y > 0)
                    {
                        if (pw.bm.GetPixel(point2.X, point2.Y) == targetColor)
                        {
                            pixels.Push(new Point(point2.X + 1, point2.Y));
                            pixels.Push(new Point(point2.X, point2.Y + 1));
                            pixels.Push(new Point(point2.X - 1, point2.Y));
                            pixels.Push(new Point(point2.X, point2.Y - 1));
                            pw.bm.SetPixel(point2.X, point2.Y, penColor);
                        }
                    }
                }
                pw.pic.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
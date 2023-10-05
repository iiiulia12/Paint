using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Paint
{
    public partial class PaintWindow : Form
    {
        public WelcomeWindow ww;
        public Canvas canvas;
        public int index = 0;
        public bool paint;
        public Bitmap bm;
        public Graphics g;
        public Pen pen = new Pen(Color.White, 1);
        public Pen erase = new Pen(Color.White, 20);
        private ColorDialog cd = new ColorDialog();
        private Color NewColor;
        public int MYcase = 0;
        public MYPoint MYe = new MYPoint();
        public Graphics e1;
        public String text;

        //index 1= pen
        //index 2= erase
        //index 3 = rectangle
        //index 4 = ellipse
        //index 5 = line
        //index 6 = fill
        public PaintWindow(Form f)
        {
            InitializeComponent();
            ww = (WelcomeWindow)f;

            this.Width = 900;
            this.Height = 700;
            pic.Width = 900;
            pic.Height = 700;

            //am pregtit fereastra pt desenare

            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            canvas = new Canvas(this);

            canvas.PrepareTheCanvas();
            
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ww.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            MYcase = 0;
            MYe.x = e.Location.X;
            MYe.y = e.Location.Y;
            canvas.sendMYcase(MYcase);

           
            /*
            canvas.ppy.CopyCoordXY(MYe);

            canvas.rectangle.copyCoordMouseDown(MYe);
            */
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            MYcase = 1;
            MYe.x = e.Location.X;
            MYe.y = e.Location.Y;
            canvas.sendMYcase(MYcase);
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            MYcase = 2;
            MYe.x = e.Location.X;
            MYe.y = e.Location.Y;
            canvas.sendMYcase(MYcase);
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void clearCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.clearCanvas();
        }

        private void saveCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = pic.Image;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPG(*.JPG)|.*jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            NewColor = cd.Color;
            pick_color.BackColor = NewColor;
            pen.Color = NewColor;
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            ww.Show();
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Image image = pic.Image;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPG(*.JPG)|.*jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog.FileName);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ww.networkClient.Write("stop");
                System.Environment.Exit(0);
            
        }

        private void pic_Paint(object sender, PaintEventArgs e)

        {
            MYcase = 3;

            e1 = e.Graphics;
            canvas.sendMYcase(MYcase);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            canvas.clearCanvas();
            
        }

        private void Orange3_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Orange3.BackColor;
            pen.Color = Orange3.BackColor;
        }

        private void color_picker_Click(object sender, EventArgs e)
        {
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void Orange2_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Orange2.BackColor;
            pen.Color = Orange2.BackColor;
        }

        private void Orange1_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Orange1.BackColor;
            pen.Color = Orange1.BackColor;
        }

        private void Yellow3_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Yellow3.BackColor;
            pen.Color = Yellow3.BackColor;
        }

        private void Yellow2_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Yellow2.BackColor;
            pen.Color = Yellow2.BackColor;
        }

        private void Yellow1_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Yellow1.BackColor;
            pen.Color = Yellow1.BackColor;
        }

        private void Green3_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Green3.BackColor;
            pen.Color = Green3.BackColor;
        }

        private void Green2_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Green2.BackColor;
            pen.Color = Green2.BackColor;
        }

        private void Green1_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Green1.BackColor;
            pen.Color = Green1.BackColor;
        }

        private void Aqua3_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Aqua3.BackColor;
            pen.Color = Aqua3.BackColor;
        }

        private void Aqua2_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Aqua2.BackColor;
            pen.Color = Aqua2.BackColor;
        }

        private void Aqua1_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Aqua1.BackColor;
            pen.Color = Aqua1.BackColor;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Purple.BackColor;
            pen.Color = Purple.BackColor;
        }

        private void Navy2_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Navy2.BackColor;
            pen.Color = Navy2.BackColor;
        }

        private void Navy1_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Navy1.BackColor;
            pen.Color = Navy1.BackColor;
        }

        private void Pink3_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Pink3.BackColor;
            pen.Color = Pink3.BackColor;
        }

        private void Pink2_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Pink2.BackColor;
            pen.Color = Pink2.BackColor;
        }

        private void Pink1_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Pink1.BackColor;
            pen.Color = Pink1.BackColor;
        }

        private void Red3_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Red3.BackColor;
            pen.Color = Red3.BackColor;
        }

        private void Red2_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Red2.BackColor;
            pen.Color = Red2.BackColor;
        }

        private void Red1_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Red1.BackColor;
            pen.Color = Red1.BackColor;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = Black.BackColor;
            pen.Color = Black.BackColor;
        }

        private void White_Click(object sender, EventArgs e)
        {
            pick_color.BackColor = White.BackColor;
            pen.Color = White.BackColor;
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void pic_Click(object sender, EventArgs e)
        {
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6)
            {
                MYPoint p = new MYPoint(e.X, e.Y);
                Color targetColor = bm.GetPixel(p.x, p.y);
                canvas.Fill(p, targetColor);
                pic.Refresh();
            }
        }

        private void pick_color_Click(object sender, EventArgs e)
        {
        }

        private void ThickLine2_Click(object sender, EventArgs e)
        {
        }

        private void ThickLine1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void ThickLine2_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void ThickLine3_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void PenThick3_Click(object sender, EventArgs e)
        {
            pen.Width = 1;
        }

        private void PenThick2_Click(object sender, EventArgs e)
        {
            pen.Width = 3;
        }

        private void PenThick1_Click(object sender, EventArgs e)
        {
            pen.Width = 8;
        }

        private void btnOtherPainter_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnDRAW_Click(object sender, EventArgs e)
        {
            
            
        }
        
    }
}
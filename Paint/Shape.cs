using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace Paint
{
    public abstract class Shape : MYPoint
    {
        public int height, width, coordMouseDownX, coordMouseDownY;
        public abstract void draw();
        public abstract void draw(Graphics g);

        public abstract void copyCoordMouseDown(MYPoint p);
        public virtual void Calculate_Width_Height() { }



        public Shape(Form f) : base(f)
        {
            this.height = 0;
            this.width = 0;
        }
        public Shape(int x, int y, Form f) : base(x, y, f)
        {

        }
        public Shape() : base()
        {

        }

    }
}

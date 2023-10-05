using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MYLine : Shape
    {    // public int coordMouseDownX, coordMouseDownY;
        public MYLine(Form f) : base(f)
        {
        }


        public override void copyCoordMouseDown(MYPoint p)
        {
            this.coordMouseDownX = p.x;
            this.coordMouseDownY = p.y;
        }

        public override void draw()
        {
            paintWindow.g.DrawLine(paintWindow.pen, coordMouseDownX, coordMouseDownY, x, y);
        }

        public override void draw(Graphics e)
        {
            e.DrawLine(paintWindow.pen, coordMouseDownX, coordMouseDownY, x, y);
        }
    }
}

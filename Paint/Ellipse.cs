using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MYEllipse : Shape
    {
        //public int height, width, coordMouseDownX, coordMouseDownY;

        public MYEllipse(Form f) : base(f)
        {

        }
        public MYEllipse(int x, int y, int h, int w, Form f)
            : base(x, y, f)
        {
            this.height = h;
            this.width = w;
        }

        public MYEllipse() : base()
        {
            this.height = 0;
            this.width = 0;
        }
        public override void draw()
        {
            if (width > 0 && height > 0)
                paintWindow.g.DrawEllipse(paintWindow.pen, coordMouseDownX, coordMouseDownY, width, height);
            else
            {
                if (width > 0 && height < 0)

                    paintWindow.g.DrawEllipse(paintWindow.pen, coordMouseDownX, coordMouseDownY + height, width, -height);
                else
                {
                    if (width < 0 && height > 0)
                        paintWindow.g.DrawEllipse(paintWindow.pen, coordMouseDownX + width, coordMouseDownY, -width, height);
                    else paintWindow.g.DrawEllipse(paintWindow.pen, coordMouseDownX + width, coordMouseDownY + height, -height, -width);
                }
            }
        }



        public override void copyCoordMouseDown(MYPoint p)
        {
            this.coordMouseDownX = p.x;
            this.coordMouseDownY = p.y;
        }

        public override void draw(Graphics e)
        {
            if (width > 0 && height > 0)
                e.DrawEllipse(paintWindow.pen, coordMouseDownX, coordMouseDownY, width, height);
            else
            {
                if (width > 0 && height < 0)

                    e.DrawEllipse(paintWindow.pen, coordMouseDownX, coordMouseDownY + height, width, -height);
                else
                {
                    if (width < 0 && height > 0)
                        e.DrawEllipse(paintWindow.pen, coordMouseDownX + width, coordMouseDownY, -width, height);
                    else e.DrawEllipse(paintWindow.pen, coordMouseDownX + width, coordMouseDownY + height, -height, -width);
                }
            }
        }
    }
}

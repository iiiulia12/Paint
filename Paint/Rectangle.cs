using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class MYRectangle : Shape
    {


        public MYRectangle(Form f) : base(f)
        {

        }
        public MYRectangle(int x, int y, int h, int w, Form f)
            : base(x, y, f)
        {
            this.height = h;
            this.width = w;
        }

        public MYRectangle() : base()
        {
            this.height = 0;
            this.width = 0;
        }

        public override void draw()
        {
            if (width > 0 && height > 0)
                paintWindow.g.DrawRectangle(paintWindow.pen, coordMouseDownX, coordMouseDownY, width, height);
            else
            {
                if (width > 0 && height < 0)

                    paintWindow.g.DrawRectangle(paintWindow.pen, coordMouseDownX, coordMouseDownY + height, width, -height);
                else
                {
                    if (width < 0 && height > 0)
                        paintWindow.g.DrawRectangle(paintWindow.pen, coordMouseDownX + width, coordMouseDownY, -width, height);
                    else paintWindow.g.DrawRectangle(paintWindow.pen, coordMouseDownX + width, coordMouseDownY + height, -height, -width);
                }
            }
        }

        public override void Calculate_Width_Height()
        {
            this.height = this.y - this.coordMouseDownY;
            this.width = this.x - this.coordMouseDownX;
        }


        public override void copyCoordMouseDown(MYPoint p)
        {
            this.coordMouseDownX = p.x;
            this.coordMouseDownY = p.y;
        }

        public override void draw(Graphics e)
        {
            if (width > 0 && height > 0)
                e.DrawRectangle(paintWindow.pen, coordMouseDownX, coordMouseDownY, width, height);
            else
            {
                if (width > 0 && height < 0)

                    e.DrawRectangle(paintWindow.pen, coordMouseDownX, coordMouseDownY + height, width, -height);
                else
                {
                    if (width < 0 && height > 0)
                        e.DrawRectangle(paintWindow.pen, coordMouseDownX + width, coordMouseDownY, -width, height);
                    else e.DrawRectangle(paintWindow.pen, coordMouseDownX + width, coordMouseDownY + height, -height, -width);
                }
            }
        }

    }
}
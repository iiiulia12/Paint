using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    public class MYPoint
    {

        public int x, y;

        protected PaintWindow paintWindow;
        public MYPoint(Form f)
        {
            paintWindow = (PaintWindow)f;
        }
        public MYPoint(int x, int y, Form f)
        {
            this.x = x;
            this.y = y;
            paintWindow = (PaintWindow)f;




        }
        public MYPoint()
        {
            this.x = 0;
            this.y = 0;
        }
        public MYPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        

        public void Draw(MYPoint ppy)
        {
            paintWindow.g.DrawLine(paintWindow.pen, this.x, this.y, ppy.x, ppy.y);


        }
        public void Erase(MYPoint ppy)
        {
            paintWindow.g.DrawLine(paintWindow.erase, this.x, this.y, ppy.x, ppy.y);
        }
        public void CopyCoordXY(MYPoint p)
        {
            this.x = p.x;
            this.y = p.y;
        }
       
        

    }
   
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Paint
{
    public class Canvas
    {
        private PaintWindow paintWindow;

        //incuibarite
        private MYPoint ppx;
        private MYPoint ppy;
        private Shape rectangle;
        private Shape ellipse;
        private Shape line;

        private string toWrite = "";

        public Canvas(Form f)
        {
            paintWindow = (PaintWindow)f;
        }

        public void PrepareTheCanvas()
        {
            ppx = new MYPoint(this.paintWindow);
            ppy = new MYPoint(paintWindow);
            rectangle = new MYRectangle(paintWindow);
            ellipse = new MYEllipse(paintWindow);
            line = new MYLine(paintWindow);
        }

        public void copyRectangleToEllipse()
        {
            ellipse.x = rectangle.x;
            ellipse.y = rectangle.y;
            ellipse.coordMouseDownX = rectangle.coordMouseDownX;
            ellipse.coordMouseDownY = rectangle.coordMouseDownY;
            ellipse.width = rectangle.width;
            ellipse.height = rectangle.height;
        }

        public void copyRectangleToLine()
        {
            line.x = rectangle.x;
            line.y = rectangle.y;
            line.coordMouseDownY = rectangle.coordMouseDownY;
            line.coordMouseDownX = rectangle.coordMouseDownX;
        }

        public void clearCanvas()
        {    if (paintWindow.ww.server)
            {
                Thread.Sleep(1000);
                paintWindow.ww.networkClient.Write("clear");
                
            }
            

          
            paintWindow.g.Clear(Color.White);
            paintWindow.pic.Image = paintWindow.bm;
            paintWindow.index = 0;
            paintWindow.paint = false;
            paintWindow.pick_color.BackColor = Color.White;
            paintWindow.pic.Refresh();

            if (paintWindow.ww.server)
            {
                Thread.Sleep(1000);
                paintWindow.ww.networkClient.Read();
            }
        }

        public void Fill(MYPoint point, Color targetColor)//Color replacementColor)
        {
            if (targetColor != paintWindow.pen.Color)
            {
                Stack<MYPoint> pixels = new Stack<MYPoint>();
                MYPoint p;
                pixels.Push(point);

                while (pixels.Count > 0)
                {
                    p = pixels.Pop();
                    if (p.x < paintWindow.bm.Width && p.x > 0 && p.y < paintWindow.bm.Height && p.y > 0)
                    {
                        if (paintWindow.bm.GetPixel(p.x, p.y) == targetColor)
                        {
                            pixels.Push(new MYPoint(p.x + 1, p.y));
                            pixels.Push(new MYPoint(p.x, p.y + 1));
                            pixels.Push(new MYPoint(p.x - 1, p.y));
                            pixels.Push(new MYPoint(p.x, p.y - 1));
                            paintWindow.bm.SetPixel(p.x, p.y, paintWindow.pen.Color);
                        }
                    }

                }
                paintWindow.pic.Refresh();

                if (paintWindow.ww.server)
                {
                    toWrite = "";
                    toWrite = "@!" + "f!" + point.x.ToString() + "!" + point.y.ToString() + "!" + (targetColor).ToString() + "!" +
                        (paintWindow.pen.Color).ToString();
                    Thread.Sleep(1000);
                    paintWindow.ww.networkClient.Write(toWrite);

                    Thread.Sleep(3000);
                    paintWindow.ww.networkClient.Read();
                }
            }
        }

        public void sendMYcase(int MYcase)
        {
            switch (MYcase)
            {
                case 0:
                    {
                        ppy.CopyCoordXY(paintWindow.MYe);

                        rectangle.copyCoordMouseDown(paintWindow.MYe);
                        break;
                    }
                case 1:
                    {
                        if (paintWindow.paint)
                        {
                            if (paintWindow.index == 1)
                            {
                                ppx.CopyCoordXY(paintWindow.MYe);
                                ppx.Draw(ppy);
                                /*

                                toWrite = "";
                                toWrite = "@/" + "l/" + (paintWindow.pen.Width).ToString()+"/"+ (paintWindow.pen.Color).ToString()+"/"
                                + ppx.x.ToString() + "/" + ppx.y.ToString() + "/" + ppy.x.ToString() +"/" + ppy.y.ToString();

                                    Console.WriteLine("aici sunt in canvas scriu info in server " + toWrite +"punct");
                                    Thread.Sleep(1000);
                                    paintWindow.ww.networkClient.Write(toWrite);
                                    Thread.Sleep(1000); */
                                // paintWindow.ww.networkClient.Write("painter");

                                //  paintWindow.ww.networkClient.Read();

                                ppy.CopyCoordXY(ppx);
                                
                            }
                            if (paintWindow.index == 2)
                            {
                                ppx.CopyCoordXY(paintWindow.MYe);
                                ppx.Erase(ppy);
                                ppy.CopyCoordXY(ppx);
                            }
                        }

                        rectangle.CopyCoordXY(paintWindow.MYe);
                        paintWindow.pic.Refresh();
                        break;
                    }
                case 2:
                    {
                        rectangle.Calculate_Width_Height();
                        copyRectangleToEllipse();
                        copyRectangleToLine();
                        

                        if (paintWindow.index == 3)

                        {
                            if (paintWindow.ww.server)
                            {    
                                toWrite = "";
                                toWrite = "@!" + "r!" + (paintWindow.pen.Width).ToString() + "!" + (paintWindow.pen.Color).ToString()
                                + "!" + rectangle.coordMouseDownX.ToString() + "!" + rectangle.coordMouseDownY.ToString() + "!" + rectangle.width.ToString()
                                + "!" + rectangle.height.ToString();


                                Thread.Sleep(1000);

                               // Console.WriteLine("aici sunt in canvas scriu info in server " + toWrite + "rectangle");



                                paintWindow.ww.networkClient.Write(toWrite);
                                Thread.Sleep(2000);
                            }

                            rectangle.draw();
                            paintWindow.pic.Refresh();
                            if(paintWindow.ww.server)
                            paintWindow.ww.networkClient.Read();
                        }
                        if (paintWindow.index == 4)
                        {
                            if (paintWindow.ww.server)
                            {
                                toWrite = "";
                                toWrite = "@!" + "e!" + (paintWindow.pen.Width).ToString() + "!" + (paintWindow.pen.Color).ToString()
                                + "!" + ellipse.coordMouseDownX.ToString() + "!" + ellipse.coordMouseDownY.ToString() + "!" + ellipse.width.ToString()
                                + "!" + ellipse.height.ToString();


                                Thread.Sleep(1000);
                               // Console.WriteLine("aici sunt in canvas scriu info in server " + toWrite + " elipse");
                                paintWindow.ww.networkClient.Write(toWrite);
                                Thread.Sleep(2000);

                            }
                           
                            ellipse.draw();
                            paintWindow.pic.Refresh();
                            if (paintWindow.ww.server)
                                paintWindow.ww.networkClient.Read();

                        }
                        if (paintWindow.index == 5)
                        {
                            if (paintWindow.ww.server)
                            {
                                toWrite = "";
                                toWrite = "@!" + "l!" + (paintWindow.pen.Width).ToString() + "!" + (paintWindow.pen.Color).ToString()
                                + "!" + line.coordMouseDownX.ToString() + "!" + line.coordMouseDownY.ToString() + "!" + line.x.ToString() +
                                "!" + line.y.ToString();


                                Thread.Sleep(1000);
                                paintWindow.ww.networkClient.Write(toWrite);
                                //Console.WriteLine("aici sunt in canvas scriu info in server " + toWrite + " linie");


                                Thread.Sleep(2000);

                            }




                            line.draw();
                            paintWindow.pic.Refresh();
                            if (paintWindow.ww.server)
                                paintWindow.ww.networkClient.Read();
                        }
                        paintWindow.paint = false;

                        break;
                    }
                case 3:
                    {
                        rectangle.Calculate_Width_Height();
                        copyRectangleToEllipse();
                        copyRectangleToLine();

                        if (paintWindow.paint)
                        {
                            if (paintWindow.index == 3)
                            {
                                rectangle.draw(paintWindow.e1);
                                paintWindow.pic.Refresh();
                            }
                            if (paintWindow.index == 4)
                            {
                                ellipse.draw(paintWindow.e1);
                                paintWindow.pic.Refresh();
                            }
                            if (paintWindow.index == 5)
                            {
                                line.draw(paintWindow.e1);
                                paintWindow.pic.Refresh();
                            }
                        }
                        break;
                    }
            }
        }
    }
}
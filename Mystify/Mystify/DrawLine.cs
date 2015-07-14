
/*
 *FileName      :DrawLines.cs
 * Project      :PROG2120
 * Programmer   :Xiaodong Meng
 * First Version:10/21/2014
 * Description  :This file used to draw a line.
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
namespace Mystify
{
    class DrawLine
    {
        public Color BackgroundColor { get; set; }
        public Int32 XCentre { get; set; }
        public Int32 YCentre { get; set; }
        public Int32 nScreenWidth { get; set; }
        public Int32 nScreenLength { get; set; }
        private Pen myPen = null;
        private Pen backgroundPen = null;
        private Graphics graObject;
        public bool Shutdown { get; set; }

        public DrawLine(Graphics g)
        {
            Random randomColor = new Random();
            myPen = new Pen(Color.FromArgb(randomColor.Next(0, 256), randomColor.Next(0, 256), randomColor.Next(0, 256)));
            graObject = g;
            Shutdown = false;
        }

        //Function      :DrawLines
        //Description   :Draw a lines at the same position.
        //
        //Parameters    :none
        //Return        :none
        public void DrawLines()
        {
            Thread.Sleep(60);
            Random randomPos = new Random();
            backgroundPen = new Pen(BackgroundColor);
            Point pEnd = new Point(randomPos.Next(0, nScreenWidth + 1), randomPos.Next(0, nScreenLength + 1));
            double angelOfLine = Math.Atan2((YCentre - 0), (XCentre - 0))*180/Math.PI;

            int XRandom = randomPos.Next(0,( nScreenWidth /5) + 1);
            int YRandom = randomPos.Next(0,(nScreenLength/5)+1);
           // graObject.TranslateTransform((float)(-Math.Cos(angelOfLine) * (Math.Sqrt(Math.Pow(XCentre, 2) + Math.Pow(YCentre, 2)))), (float)(-Math.Sin(angelOfLine) * Math.Sqrt(Math.Pow(XCentre, 2) + Math.Pow(YCentre, 2))));
          
            try
            {
                for (Int32 ripple = 0; ripple < 30; ripple++)
                {

                    if (!Shutdown)
                    {
                        graObject.DrawLine(myPen, XCentre - XRandom, YCentre - YRandom, XCentre + XRandom, YCentre + YRandom);


                        Thread.Sleep(30);
                        graObject.DrawLine(backgroundPen, XCentre - XRandom, YCentre - YRandom, XCentre + XRandom, YCentre + YRandom);

                    }
                    else
                    {
                        break;
                    }
                   

                }
            }
            catch(ThreadAbortException exception)
            {
                graObject.Dispose();
                myPen.Dispose();
            }
           
        }
    }
}

/*
 *FileName      :Form1.cs
 * Project      :PROG2120
 * Programmer   :Xiaodong Meng
 * First Version:10/21/2014
 * Description  :This file used to create multiple thread to draw lines, and handle the thread gracefully.
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mystify
{
    public partial class Form1 : Form
    {
        ThreadRepo tRepo = new ThreadRepo();
        List<DrawLine> lines = new List<DrawLine>();
        public Form1()
        {
            InitializeComponent();
           
        }


        //Function      : autoDrawLine
        //Description   : Draw multiple lines at different position.
        //
        //Parameters    : NONE
        //
        //Returns       :NONE
        //
        //
    
        private void autoDrawLine()
        {
           
            
            Random pRandom = new Random();

            Point pStart = new Point(pRandom.Next(20, (this.Width) / 4 + 1), pRandom.Next(20, (this.Height)/4 + 1));
        
            int unitX = 7;
            int unitY = 7;
            int times = 0;
            for (times = 0; times < 50; times++ )
            {
                 DrawLine line = new DrawLine(this.CreateGraphics());
                 
                line.BackgroundColor = this.BackColor;
                Thread t = new Thread(new ThreadStart(line.DrawLines));
                lines.Add(line);
                tRepo.Add(t);
                pStart.X += unitX;
                pStart.Y += unitX;

                line.XCentre = pStart.X;
                line.YCentre = pStart.Y;
                line.nScreenLength = this.Height;
                line.nScreenWidth = this.Width;


                if (pStart.X >= this.Width)
                {
                    unitX = -unitX;

                }
                else if (pStart.X <= 0)
                {
                    unitX = -unitX;
                }


                if (pStart.Y >= this.Height)
                {
                    unitY = -unitY;

                }
                else if (pStart.Y <= 0)
                {
                    unitY = -unitY;
                }
            
                Thread.Sleep(10);
                t.Start();
             
            }
    
        }



        //Function      :DrawLine_MouseMove
        //Description   :Draw lines when mouse moving
        //
        //Parameters    :MouseEventArgs e: mouse move event
        //
        //Returns       :None
        //
        //
        private void DrawLine_MouseMove(MouseEventArgs e)
        {
         
            DrawLine line = new DrawLine(this.CreateGraphics());

            line.BackgroundColor = this.BackColor;
            Thread t = new Thread(new ThreadStart(line.DrawLines));
            lines.Add(line);
            tRepo.Add(t);
            line.XCentre = e.X;
            line.YCentre = e.Y;
            line.nScreenLength = this.Height;
            line.nScreenWidth = this.Width;


            t.Start();
          
        }



        //Function      :Form1_MouseMove
        //Description   :Mouse move response function.
        //
        //Parameters    :object sender
        //                MouseEventArgs e
        //
        //Returns       :None
        //
        //
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DrawLine_MouseMove(e);
            }
        }



        //Function      :Form1_MouseClick
        //Description   :Mouse Click event handle function.
        //
        //Parameters    :object sender, MouseEventArgs e
        //
        //Returns       :none
        //
        //
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
       
            autoDrawLine();
           
        }



        //Function      :NewLineBtn_Click
        //Description   :NewLine button clieked event handle function.
        //
        //Parameters    :object sender, EventArgs e
        //
        //Returns       :none
        //
        //
        private void NewLineBtn_Click(object sender, EventArgs e)
        {
            autoDrawLine();
        }



        //Function      :PauseBtn_Click
        //Description   :Pause button clicked event handle function.
        //
        //Parameters    :object sender, EventArgs e
        //
        //Returns       :none
        //
        //
        private void PauseBtn_Click(object sender, EventArgs e)
        {
            tRepo.PauseThreads();
        }



        //Function      :ResumeBtn_Click
        //Description   :Resume button clicked event handle function.
        //
        //Parameters    :object sender, EventArgs e
        //
        //Returns       :none
        //
        //
        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            tRepo.ResumeThreads();
        }


        //Function      :Form1_FormClosing
        //Description   :Close button clicked event handle function.
        //
        //Parameters    :object sender, FormClosingEventArgs e
        //
        //Returns       :none
        //
        //
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            foreach (DrawLine line in lines)
            {
                line.Shutdown = true;
            }
            tRepo.ResumeThreads();
            tRepo.JoinAll();
            tRepo.Clear();
      
            
        }



        //Function      :ExitBtn_Click
        //Description   :Exit button clicked event handle function.
        //
        //Parameters    :object sender, EventArgs e
        //
        //Returns       :none
        //
        //
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            foreach(DrawLine line in lines )
            {
                line.Shutdown = true;
            }
          tRepo.ResumeThreads();
          tRepo.JoinAll();
           this.Close();
        }


    }
}

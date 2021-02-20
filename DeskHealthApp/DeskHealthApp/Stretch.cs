using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;





namespace DeskHealthApp
{
    public partial class Stretch : Form
    {
        //public new System.Drawing.Point DesktopLocation { get; set; }
        private int breakDone = Form1.BreakTime;
        private int clickCount = 0;
        private int MaxClickCount = 4;

        private const int IntervalTimer = 1000 * 5; // set for 5 seconds for Testing ( 20 - 30 seconds during final)

        public Stretch()
        {
            InitializeComponent();

            

            // this is here to put them in on load up
            this.pictureBox1.Image = Properties.Resources.StreImgExp2;
            this.textBox1.Text = Properties.Resources.StretchTxt1;
            this.SetDesktopLocation(355, 355);

            // this sets the slide time 
            this.timer1.Enabled = true;
            this.timer1.Interval = IntervalTimer;
            this.timer1.Start();


        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            clickCount++;
            /*
            if (clickCount == 0)
            {
                this.pictureBox1.Image = Properties.Resources.StreImgExp2;
                this.textBox1.Text = Properties.Resources.StretchTxt1;
            }  */
            if (clickCount == 1)
            {
                this.pictureBox1.Image = Properties.Resources.StreImgEXP1;
                this.textBox1.Text = Properties.Resources.StreTxt2;
            }
            if (clickCount == 2)
            {
                this.textBox1.Text = Properties.Resources.StretchHamstring;
            }
            if (clickCount == 3)
            {
                this.textBox1.Text = "*** Needs to be done ***";
            }

            if (clickCount == 4)
            {
                this.textBox1.Text = "*** Needs to be done ***";
            }
            if (clickCount == MaxClickCount)// displays website sources of the stretches
            {
                this.textBox1.Text = Properties.Resources.Stretching_Sources_;
            }


            if (clickCount > MaxClickCount)
            {

                MessageBox.Show("Oh oh , That is it. No more yet ");
                clickCount = MaxClickCount;
            }
        }// end of NextBtn

        private void PreBtn_Click(object sender, EventArgs e)
        {
            clickCount--;
            if (clickCount == 0)
            {
                this.pictureBox1.Image = Properties.Resources.StreImgExp2;
                this.textBox1.Text = Properties.Resources.StretchTxt1;
            }
            if (clickCount == 1)
            {
                this.pictureBox1.Image = Properties.Resources.StreImgEXP1;
                this.textBox1.Text = Properties.Resources.StreTxt2;
            }
            if (clickCount == 2)
            {
                this.textBox1.Text = Properties.Resources.StretchHamstring;
            }
            if (clickCount == 3)
            {
                this.textBox1.Text = Properties.Resources.StreTxt3;
                // this.pictureBox1.Image = Properties.Resources.me;
            }
            if (clickCount == MaxClickCount)
            {
                this.textBox1.Text = Properties.Resources.Stretching_Sources_;
            }


            if (clickCount < 0)
            {

                MessageBox.Show("thats the begining");
                clickCount = 0;
            }
        }// ends PreBtn

        private void timer1_Tick(object sender, EventArgs e)
        {
            // this sets the length the window stays up  
            this.BreakLengT.Enabled = true;
            this.BreakLengT.Interval = breakDone;
            this.BreakLengT.Start();

            if (clickCount < MaxClickCount) { NextBtn_Click(sender, e); timer1.Interval = IntervalTimer; }
            if (clickCount == MaxClickCount)
            {
                timer1.Stop();
                timer1.Enabled = false;

                PrevTimer.Enabled = true;
                PrevTimer.Interval = IntervalTimer;
                PrevTimer.Start();

            }



        }

        private void PrevTimer_Tick(object sender, EventArgs e)
        {
            if (clickCount > 0)
            {
                PreBtn_Click(sender, e); timer1.Interval = IntervalTimer;

            }
            if(clickCount == 0)
            {
                PrevTimer.Stop();
                PrevTimer.Enabled = false;
            }
        }
            
    private void BreakLengT_Tick(object sender, EventArgs e)
    {
            MessageBox.Show("Okay dokay Time to get back to work :) ");


            Close();
            

    }// end BreakLengT_Tick  
    

    }
}

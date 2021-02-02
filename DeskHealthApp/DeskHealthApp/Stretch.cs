using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskHealthApp
{
    public partial class Stretch : Form
    {

        private int clickCount = 0;
        public Stretch()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount > 0)
            {
                this.pictureBox1.Image = Properties.Resources.StreImgExp2;
                this.textBox1.Text = Properties.Resources.StretchTxt1;
            }
            if (clickCount > 1)
            {
                this.pictureBox1.Image = Properties.Resources.StreImgEXP1;
                this.textBox1.Text = Properties.Resources.StreTxt2;
            }
            if (clickCount > 2)
            {
                //this.pictureBox1.Image = Properties.Resources.ptk;
            }
            if (clickCount > 3)
            {
             //   this.pictureBox1.Image = Properties.Resources.me;
            }
        }

        private void PreBtn_Click(object sender, EventArgs e)
        {

            if (clickCount > 0)
            {
                this.pictureBox1.Image = Properties.Resources.StreImgExp2;
                this.textBox1.Text = Properties.Resources.StretchTxt1;
            }
            if (clickCount > 1)
            {
                this.pictureBox1.Image = Properties.Resources.StreImgEXP1;
                this.textBox1.Text = Properties.Resources.StreTxt2;
            }
            if (clickCount > 2)
            {

            }
            if (clickCount > 3)
            {
               // this.pictureBox1.Image = Properties.Resources.me;
            }
            clickCount--;

            if (clickCount == 0)
            {
                MessageBox.Show("thats the begining");
            }
        }

        private void BreakLengT_Tick(object sender, EventArgs e)
        {
            bool restart = true;
            int breakDone = Form1.BreakTime;
           BreakLengT.Enabled = true;
            BreakLengT.Interval = breakDone;
            // WorkOutEndT.Interval = Form1.BreakTime;
            BreakLengT.Start();

            timer1.Enabled = false;

            if (restart ==true)
            {
                restart = false;
                BreakLengT.Stop();
                MessageBox.Show("Okay dokay Time to get back to work :) ");

            }
            Close();

        }// end BreakLengT_Tick 

        private void timer1_Tick(object sender, EventArgs e)
        {
            BreakLengT_Tick(sender, e);
        }
    }
}

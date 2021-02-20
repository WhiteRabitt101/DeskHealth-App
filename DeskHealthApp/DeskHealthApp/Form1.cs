using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows; // Forms.Timer

namespace DeskHealthApp
{
    public partial class Form1 : Form
    {
        //public static int WorkTime;
        public static int BreakTime;
        public static bool restart = true;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void WorkOutRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartB_Click(object sender, EventArgs e)
        {
            // sets the length of work b4 break activity
            string workTimeStr = WorkTimeTB.Text;
            int WorkTime = int.Parse(workTimeStr);
            int interval = WorkTime * 1000; //**************** set for seconds Should be changed to minutes after testing ********************************

            // sets the length of the break activty
            string BreakTimeStr = BreakLenTB.Text;
            int BreakTime1 = int.Parse(BreakTimeStr);
            BreakTime = BreakTime1 * 1000; //**************** set for seconds Should be changed to minutes after testing ********************************



            TimeTellBreak.Enabled = true;
                TimeTellBreak.Interval = interval;
                TimeTellBreak.Start();

            // Timer that Pops up Reminders about Posture / to breathe/ Positive stuff 
            if(RemindRB.Checked)
            {
               // bool RestartTime = true;

                RemindT.Enabled = restart;
                RemindT.Interval = 5000; // thinking like every 10-30 min? +/-
                RemindT.Start();

            }

        }

        private void TimeTellBreak_Tick(object sender, EventArgs e)
        {
            if (WorkOutRB.Checked)
            {
                TimeTellBreak.Enabled = false; // These 2 lines
                TimeTellBreak.Stop();          // stop the Timer
                var WorkoutForm = new WorkOut(); ;
                WorkoutForm.Show();
            }
            if(StretchRB.Checked)
            {
                TimeTellBreak.Enabled = false;
                TimeTellBreak.Stop();
                
                var StretchForm = new Stretch();
                StretchForm.Show();
            }
            if(otherRB.Checked)
            {
                TimeTellBreak.Enabled = false;
                TimeTellBreak.Stop();
                Form other = new Form();
                other.DesktopLocation = new Point(355,225);
                other.Show();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // would like to make it give a different positive goodbye 
            Random randNum = new Random();
            
            int random = randNum.Next(0,2);
            if (random == 1)
            {
                MessageBox.Show(" Way to be healthy!! :)");
            }
            if(random == 0)
            {
                MessageBox.Show(" You did awesome!! :) ");
            }

            Close();
        }

        public void RemindT_Tick(object sender, EventArgs e)
        {
            RemindT.Enabled = false;
            var HealthRemind = new HealthyReminders();
            HealthRemind.DesktopLocation = new Point(355, 355);
            HealthRemind.Show();

            MessageBox.Show(" Don't for get to breathe :) ");
            
        }


    }
}

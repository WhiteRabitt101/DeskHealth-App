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
        public static int RemindInterval = 5000;
        public static int RemindPauseInterval = 5000;
        public static int BreakTime;
        public static bool restart = true;

        public static int PainAreaSelect;
        public static string workTimeStr;
        public static int WorkTime;
        public static int interval;
        public static int MeditationImgSelect;

        public static int i;

        public Form1()
        {
            MessageBox.Show(" Talk to your doctor before using this product \n *** Insert More Legal info here *** ");
                InitializeComponent();
            
              
            
        }
        // this makes OptionsLB visible so user can select background images style
        private void MeditateRB_CheckedChanged(object sender, EventArgs e)
        {
            if (MeditateRB.Checked) { OptionsLB.Visible = true; MedSlidL.Visible = true; }
            else
            { OptionsLB.Visible = false; MedSlidL.Visible = false; }
        }
    private void MeditateImgSelect()
        {
            MeditationImgSelect = OptionsLB.SelectedIndex; 
        }
        

        private void WorkOutRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartB_Click(object sender, EventArgs e)
        {
            MeditateImgSelect(); // this sends Index for ImageSlideShow
            //**************** set for seconds Should be changed to minutes after testing ********************************
            try
            {
                     workTimeStr = WorkTimeTB.Text;
                     WorkTime = int.Parse(workTimeStr);
                     interval = WorkTime * 1000;
            }
                 catch(FormatException)
                 {
                      MessageBox.Show(" Incorrect value entered for Work Time ");
                      return;
                 }

            // sets the length of the break activty
            try { 
                    string BreakTimeStr = BreakLenTB.Text;
                    int BreakTime1 = int.Parse(BreakTimeStr);
                    BreakTime = BreakTime1 * 1000; //**************** set for seconds Should be changed to minutes after testing ********************************
            }
            catch(FormatException)
            {
                MessageBox.Show(" Incorrect value entered for Break Time ");
                return;
            }
            /*
            if(MeditateRB.Checked)
            {
                OptionsLB.Visible = true;

            }
            */
            TimeTellBreak.Enabled = true;
                TimeTellBreak.Interval = interval;
                TimeTellBreak.Start();

            // Timer that Pops up Reminders about Posture / to breathe/ Positive stuff 
            if(RemindRB.Checked)
            {
               // bool RestartTime = true;

                RemindT.Enabled = restart;
                RemindT.Interval = RemindInterval; // thinking like every 10-30 min? +/-
                RemindT.Start();
             }
        }



        private void TimeTellBreak_Tick(object sender, EventArgs e)
        {
            restart = false;
            RemindT.Enabled = restart; //  These stop 
          //  RemindT.Stop();          //  the reminders TImer  *** NOT WORKING
            
            if (WorkOutRB.Checked)
            {
                
                TimeTellBreak.Enabled = restart; // These 2 lines
                TimeTellBreak.Stop();          // stop the TimeTellBreak Timer
                var WorkoutForm = new WorkOut(); ;
                WorkoutForm.Show();
            }
            if(StretchRB.Checked)
            {
           
                TimeTellBreak.Enabled = restart; // These 2 lines
                TimeTellBreak.Stop();          // stop the TimeTellBreak Timer             
      
                if(NeckShouldRB.Checked)
                {
                    PainAreaSelect = 1;                    
                }
                else if(FullBodyRB.Checked)
                {
                    PainAreaSelect = 2;
                }
                var StretchForm = new Stretch();
                StretchForm.Show();

                RemindT.Enabled = false; //  These stop 
                RemindT.Stop();          //  the reminders TImer
            }
            if(YogaRB.Checked)
            {
                TimeTellBreak.Enabled = restart; // These 2 lines
                TimeTellBreak.Stop();          // stop the TimeTellBreak Timer

                var YogaForm = new Yoga();
                YogaForm.Show();
            }
            if(MeditateRB.Checked)
            {   
                

                TimeTellBreak.Enabled = restart; // These 2 lines
                TimeTellBreak.Stop();          // stop the TimeTellBreak Timer

                var MeditateForm = new Meditation();
                MeditateForm.Show();

            }
            if(otherRB.Checked)
            {                
                TimeTellBreak.Enabled = restart; // These 2 lines
                TimeTellBreak.Stop();          // stop the TimeTellBreak Timer
               
                Form other = new Form();
                other.DesktopLocation = new Point(355,225); // this sets the location of creation on screen
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
            RemindT.Stop();
            var HealthRemind = new HealthyReminders();
            HealthRemind.DesktopLocation = new Point(1200, 600);
            HealthRemind.Show();
            TimeBetweenReminder.Enabled = true;
            TimeBetweenReminder.Interval = RemindPauseInterval;
            TimeBetweenReminder.Start();
         
        }

        // This Sets a timer restart the Reminder Timer(RemindT) for after the Reminder window Closes
        private void TimeBetweenReminder_Tick(object sender, EventArgs e)
        {
            TimeBetweenReminder.Enabled = false;
            TimeBetweenReminder.Stop();
            
            RemindT.Enabled = restart;
            RemindT.Interval = RemindInterval;
            RemindT.Start();
        }

        private void ActivityBox_Enter(object sender, EventArgs e)
        {
          
            if(MeditateRB.Checked)
            {
                OptionsLB.Visible = true;
            }
        }

      
    }
}

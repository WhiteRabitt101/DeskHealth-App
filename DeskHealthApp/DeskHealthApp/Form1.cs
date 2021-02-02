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
            

        }

        private void TimeTellBreak_Tick(object sender, EventArgs e)
        {
            if (WorkOutRB.Checked)
            {
                TimeTellBreak.Enabled = false;
                TimeTellBreak.Stop();
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
        }
    }
}

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
  
    public partial class HealthyReminders : Form
    {
      
        public HealthyReminders()
        {
            InitializeComponent();
        }

        private void WindowLifeT_Tick(object sender, EventArgs e)
        {   
           
            
            Close();
        }
    }
}

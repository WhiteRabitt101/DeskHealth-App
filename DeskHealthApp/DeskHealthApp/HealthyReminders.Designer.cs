
namespace DeskHealthApp
{
    partial class HealthyReminders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReminderTB = new System.Windows.Forms.TextBox();
            this.WindowLifeT = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ReminderTB
            // 
            this.ReminderTB.Location = new System.Drawing.Point(105, 104);
            this.ReminderTB.Multiline = true;
            this.ReminderTB.Name = "ReminderTB";
            this.ReminderTB.Size = new System.Drawing.Size(270, 227);
            this.ReminderTB.TabIndex = 0;
            // 
            // WindowLifeT
            // 
            this.WindowLifeT.Enabled = true;
            this.WindowLifeT.Interval = 10000;
            this.WindowLifeT.Tick += new System.EventHandler(this.WindowLifeT_Tick);
            // 
            // HealthyReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReminderTB);
            this.Name = "HealthyReminders";
            this.Text = "HealthyReminders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReminderTB;
        private System.Windows.Forms.Timer WindowLifeT;
    }
}
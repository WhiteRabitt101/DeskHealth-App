﻿
namespace DeskHealthApp
{
    partial class Form1
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
            this.ActivityBox = new System.Windows.Forms.GroupBox();
            this.otherRB = new System.Windows.Forms.RadioButton();
            this.YogaRB = new System.Windows.Forms.RadioButton();
            this.StretchRB = new System.Windows.Forms.RadioButton();
            this.WorkOutRB = new System.Windows.Forms.RadioButton();
            this.StartB = new System.Windows.Forms.Button();
            this.TimeTellBreak = new System.Windows.Forms.Timer(this.components);
            this.WorkTimeTB = new System.Windows.Forms.TextBox();
            this.WorkTimeLB = new System.Windows.Forms.Label();
            this.BreakLengthLB = new System.Windows.Forms.Label();
            this.BreakLenTB = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.RemindRB = new System.Windows.Forms.RadioButton();
            this.RemindT = new System.Windows.Forms.Timer(this.components);
            this.ReminderGB = new System.Windows.Forms.GroupBox();
            this.HealthRemindRB = new System.Windows.Forms.RadioButton();
            this.ActivityBox.SuspendLayout();
            this.ReminderGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivityBox
            // 
            this.ActivityBox.BackColor = System.Drawing.Color.Transparent;
            this.ActivityBox.Controls.Add(this.otherRB);
            this.ActivityBox.Controls.Add(this.YogaRB);
            this.ActivityBox.Controls.Add(this.StretchRB);
            this.ActivityBox.Controls.Add(this.WorkOutRB);
            this.ActivityBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ActivityBox.Location = new System.Drawing.Point(121, 134);
            this.ActivityBox.Name = "ActivityBox";
            this.ActivityBox.Size = new System.Drawing.Size(185, 183);
            this.ActivityBox.TabIndex = 0;
            this.ActivityBox.TabStop = false;
            this.ActivityBox.Text = "Activity Box";
            // 
            // otherRB
            // 
            this.otherRB.AutoSize = true;
            this.otherRB.Location = new System.Drawing.Point(8, 138);
            this.otherRB.Name = "otherRB";
            this.otherRB.Size = new System.Drawing.Size(65, 21);
            this.otherRB.TabIndex = 3;
            this.otherRB.TabStop = true;
            this.otherRB.Text = "Other";
            this.otherRB.UseVisualStyleBackColor = true;
            // 
            // YogaRB
            // 
            this.YogaRB.AutoSize = true;
            this.YogaRB.Location = new System.Drawing.Point(7, 110);
            this.YogaRB.Name = "YogaRB";
            this.YogaRB.Size = new System.Drawing.Size(62, 21);
            this.YogaRB.TabIndex = 2;
            this.YogaRB.TabStop = true;
            this.YogaRB.Text = "Yoga";
            this.YogaRB.UseVisualStyleBackColor = true;
            // 
            // StretchRB
            // 
            this.StretchRB.AutoSize = true;
            this.StretchRB.Location = new System.Drawing.Point(7, 82);
            this.StretchRB.Name = "StretchRB";
            this.StretchRB.Size = new System.Drawing.Size(74, 21);
            this.StretchRB.TabIndex = 1;
            this.StretchRB.TabStop = true;
            this.StretchRB.Text = "Stretch";
            this.StretchRB.UseVisualStyleBackColor = true;
            // 
            // WorkOutRB
            // 
            this.WorkOutRB.AutoSize = true;
            this.WorkOutRB.ForeColor = System.Drawing.SystemColors.Window;
            this.WorkOutRB.Location = new System.Drawing.Point(7, 54);
            this.WorkOutRB.Name = "WorkOutRB";
            this.WorkOutRB.Size = new System.Drawing.Size(82, 21);
            this.WorkOutRB.TabIndex = 0;
            this.WorkOutRB.TabStop = true;
            this.WorkOutRB.Text = "Workout";
            this.WorkOutRB.UseVisualStyleBackColor = true;
            this.WorkOutRB.CheckedChanged += new System.EventHandler(this.WorkOutRB_CheckedChanged);
            // 
            // StartB
            // 
            this.StartB.Location = new System.Drawing.Point(131, 377);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(110, 41);
            this.StartB.TabIndex = 1;
            this.StartB.Text = "Start";
            this.StartB.UseVisualStyleBackColor = true;
            this.StartB.Click += new System.EventHandler(this.StartB_Click);
            // 
            // TimeTellBreak
            // 
            this.TimeTellBreak.Interval = 5000;
            this.TimeTellBreak.Tick += new System.EventHandler(this.TimeTellBreak_Tick);
            // 
            // WorkTimeTB
            // 
            this.WorkTimeTB.Location = new System.Drawing.Point(121, 93);
            this.WorkTimeTB.Name = "WorkTimeTB";
            this.WorkTimeTB.Size = new System.Drawing.Size(100, 22);
            this.WorkTimeTB.TabIndex = 2;
            // 
            // WorkTimeLB
            // 
            this.WorkTimeLB.AutoSize = true;
            this.WorkTimeLB.BackColor = System.Drawing.Color.Transparent;
            this.WorkTimeLB.ForeColor = System.Drawing.SystemColors.Window;
            this.WorkTimeLB.Location = new System.Drawing.Point(118, 73);
            this.WorkTimeLB.Name = "WorkTimeLB";
            this.WorkTimeLB.Size = new System.Drawing.Size(180, 17);
            this.WorkTimeLB.TabIndex = 3;
            this.WorkTimeLB.Text = "Enter amount of Work time ";
            // 
            // BreakLengthLB
            // 
            this.BreakLengthLB.AutoSize = true;
            this.BreakLengthLB.BackColor = System.Drawing.Color.Transparent;
            this.BreakLengthLB.ForeColor = System.Drawing.SystemColors.Window;
            this.BreakLengthLB.Location = new System.Drawing.Point(322, 73);
            this.BreakLengthLB.Name = "BreakLengthLB";
            this.BreakLengthLB.Size = new System.Drawing.Size(125, 17);
            this.BreakLengthLB.TabIndex = 4;
            this.BreakLengthLB.Text = "Enter break length";
            // 
            // BreakLenTB
            // 
            this.BreakLenTB.Location = new System.Drawing.Point(325, 93);
            this.BreakLenTB.Name = "BreakLenTB";
            this.BreakLenTB.Size = new System.Drawing.Size(100, 22);
            this.BreakLenTB.TabIndex = 5;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(365, 377);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(110, 41);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // RemindRB
            // 
            this.RemindRB.AutoSize = true;
            this.RemindRB.BackColor = System.Drawing.Color.Transparent;
            this.RemindRB.ForeColor = System.Drawing.SystemColors.Window;
            this.RemindRB.Location = new System.Drawing.Point(6, 21);
            this.RemindRB.Name = "RemindRB";
            this.RemindRB.Size = new System.Drawing.Size(142, 21);
            this.RemindRB.TabIndex = 7;
            this.RemindRB.TabStop = true;
            this.RemindRB.Text = "Health Reminders";
            this.RemindRB.UseVisualStyleBackColor = false;
            // 
            // RemindT
            // 
            this.RemindT.Interval = 5000;
            this.RemindT.Tick += new System.EventHandler(this.RemindT_Tick);
            // 
            // ReminderGB
            // 
            this.ReminderGB.BackColor = System.Drawing.Color.Transparent;
            this.ReminderGB.Controls.Add(this.HealthRemindRB);
            this.ReminderGB.Controls.Add(this.RemindRB);
            this.ReminderGB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReminderGB.Location = new System.Drawing.Point(335, 137);
            this.ReminderGB.Name = "ReminderGB";
            this.ReminderGB.Size = new System.Drawing.Size(200, 100);
            this.ReminderGB.TabIndex = 8;
            this.ReminderGB.TabStop = false;
            this.ReminderGB.Text = "Reminders";
            // 
            // HealthRemindRB
            // 
            this.HealthRemindRB.AutoSize = true;
            this.HealthRemindRB.Location = new System.Drawing.Point(6, 51);
            this.HealthRemindRB.Name = "HealthRemindRB";
            this.HealthRemindRB.Size = new System.Drawing.Size(110, 21);
            this.HealthRemindRB.TabIndex = 8;
            this.HealthRemindRB.TabStop = true;
            this.HealthRemindRB.Text = "radioButton1";
            this.HealthRemindRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeskHealthApp.Properties.Resources.FormBackfround1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(609, 465);
            this.Controls.Add(this.ReminderGB);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BreakLenTB);
            this.Controls.Add(this.BreakLengthLB);
            this.Controls.Add(this.WorkTimeLB);
            this.Controls.Add(this.WorkTimeTB);
            this.Controls.Add(this.StartB);
            this.Controls.Add(this.ActivityBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ActivityBox.ResumeLayout(false);
            this.ActivityBox.PerformLayout();
            this.ReminderGB.ResumeLayout(false);
            this.ReminderGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ActivityBox;
        private System.Windows.Forms.RadioButton WorkOutRB;
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Timer TimeTellBreak;
        private System.Windows.Forms.TextBox WorkTimeTB;
        private System.Windows.Forms.Label WorkTimeLB;
        private System.Windows.Forms.RadioButton YogaRB;
        private System.Windows.Forms.RadioButton StretchRB;
        private System.Windows.Forms.Label BreakLengthLB;
        private System.Windows.Forms.TextBox BreakLenTB;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.RadioButton RemindRB;
        private System.Windows.Forms.RadioButton otherRB;
        private System.Windows.Forms.GroupBox ReminderGB;
        private System.Windows.Forms.RadioButton HealthRemindRB;
        public System.Windows.Forms.Timer RemindT;
    }
}


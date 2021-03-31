
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
            this.MeditateRB = new System.Windows.Forms.RadioButton();
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
            this.TimeBetweenReminder = new System.Windows.Forms.Timer(this.components);
            this.MedSlidL = new System.Windows.Forms.Label();
            this.OptionsLB = new System.Windows.Forms.ListBox();
            this.PainAreaSelectGB = new System.Windows.Forms.GroupBox();
            this.NeckShouldRB = new System.Windows.Forms.RadioButton();
            this.BackRb = new System.Windows.Forms.RadioButton();
            this.FullBodyRB = new System.Windows.Forms.RadioButton();
            this.ActivityBox.SuspendLayout();
            this.ReminderGB.SuspendLayout();
            this.PainAreaSelectGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivityBox
            // 
            this.ActivityBox.BackColor = System.Drawing.Color.Transparent;
            this.ActivityBox.Controls.Add(this.MeditateRB);
            this.ActivityBox.Controls.Add(this.otherRB);
            this.ActivityBox.Controls.Add(this.YogaRB);
            this.ActivityBox.Controls.Add(this.StretchRB);
            this.ActivityBox.Controls.Add(this.WorkOutRB);
            this.ActivityBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ActivityBox.Location = new System.Drawing.Point(27, 134);
            this.ActivityBox.Name = "ActivityBox";
            this.ActivityBox.Size = new System.Drawing.Size(185, 183);
            this.ActivityBox.TabIndex = 0;
            this.ActivityBox.TabStop = false;
            this.ActivityBox.Text = "Activity Box";
            this.ActivityBox.Enter += new System.EventHandler(this.ActivityBox_Enter);
            // 
            // MeditateRB
            // 
            this.MeditateRB.AutoSize = true;
            this.MeditateRB.Location = new System.Drawing.Point(7, 27);
            this.MeditateRB.Name = "MeditateRB";
            this.MeditateRB.Size = new System.Drawing.Size(94, 21);
            this.MeditateRB.TabIndex = 4;
            this.MeditateRB.TabStop = true;
            this.MeditateRB.Text = "Meditation";
            this.MeditateRB.UseVisualStyleBackColor = true;
            this.MeditateRB.CheckedChanged += new System.EventHandler(this.MeditateRB_CheckedChanged);
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
            this.WorkTimeTB.Location = new System.Drawing.Point(347, 39);
            this.WorkTimeTB.Name = "WorkTimeTB";
            this.WorkTimeTB.Size = new System.Drawing.Size(100, 22);
            this.WorkTimeTB.TabIndex = 2;
            // 
            // WorkTimeLB
            // 
            this.WorkTimeLB.AutoSize = true;
            this.WorkTimeLB.BackColor = System.Drawing.Color.Transparent;
            this.WorkTimeLB.ForeColor = System.Drawing.SystemColors.Window;
            this.WorkTimeLB.Location = new System.Drawing.Point(86, 42);
            this.WorkTimeLB.Name = "WorkTimeLB";
            this.WorkTimeLB.Size = new System.Drawing.Size(207, 17);
            this.WorkTimeLB.TabIndex = 3;
            this.WorkTimeLB.Text = "How long do you want to work? ";
            // 
            // BreakLengthLB
            // 
            this.BreakLengthLB.AutoSize = true;
            this.BreakLengthLB.BackColor = System.Drawing.Color.Transparent;
            this.BreakLengthLB.ForeColor = System.Drawing.SystemColors.Window;
            this.BreakLengthLB.Location = new System.Drawing.Point(86, 84);
            this.BreakLengthLB.Name = "BreakLengthLB";
            this.BreakLengthLB.Size = new System.Drawing.Size(254, 17);
            this.BreakLengthLB.TabIndex = 4;
            this.BreakLengthLB.Text = "How long do you want the break to be?";
            // 
            // BreakLenTB
            // 
            this.BreakLenTB.Location = new System.Drawing.Point(347, 84);
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
            this.RemindRB.Size = new System.Drawing.Size(48, 21);
            this.RemindRB.TabIndex = 7;
            this.RemindRB.TabStop = true;
            this.RemindRB.Text = "On";
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
            this.ReminderGB.Controls.Add(this.RemindRB);
            this.ReminderGB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReminderGB.Location = new System.Drawing.Point(380, 132);
            this.ReminderGB.Name = "ReminderGB";
            this.ReminderGB.Size = new System.Drawing.Size(169, 77);
            this.ReminderGB.TabIndex = 8;
            this.ReminderGB.TabStop = false;
            this.ReminderGB.Text = "Health Reminders";
            // 
            // TimeBetweenReminder
            // 
            this.TimeBetweenReminder.Tick += new System.EventHandler(this.TimeBetweenReminder_Tick);
            // 
            // MedSlidL
            // 
            this.MedSlidL.AutoSize = true;
            this.MedSlidL.BackColor = System.Drawing.Color.Transparent;
            this.MedSlidL.ForeColor = System.Drawing.Color.White;
            this.MedSlidL.Location = new System.Drawing.Point(383, 212);
            this.MedSlidL.Name = "MedSlidL";
            this.MedSlidL.Size = new System.Drawing.Size(223, 17);
            this.MedSlidL.TabIndex = 10;
            this.MedSlidL.Text = "Please Select Background images";
            this.MedSlidL.Visible = false;
            // 
            // OptionsLB
            // 
            this.OptionsLB.AllowDrop = true;
            this.OptionsLB.BackColor = System.Drawing.Color.White;
            this.OptionsLB.FormattingEnabled = true;
            this.OptionsLB.ItemHeight = 16;
            this.OptionsLB.Items.AddRange(new object[] {
            "Space Scenory",
            "Nature Scenory",
            "Abstract Art",
            "Mixture"});
            this.OptionsLB.Location = new System.Drawing.Point(429, 234);
            this.OptionsLB.Name = "OptionsLB";
            this.OptionsLB.Size = new System.Drawing.Size(120, 84);
            this.OptionsLB.TabIndex = 9;
            this.OptionsLB.Visible = false;
            // 
            // PainAreaSelectGB
            // 
            this.PainAreaSelectGB.BackColor = System.Drawing.Color.Transparent;
            this.PainAreaSelectGB.Controls.Add(this.FullBodyRB);
            this.PainAreaSelectGB.Controls.Add(this.BackRb);
            this.PainAreaSelectGB.Controls.Add(this.NeckShouldRB);
            this.PainAreaSelectGB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PainAreaSelectGB.Location = new System.Drawing.Point(218, 134);
            this.PainAreaSelectGB.Name = "PainAreaSelectGB";
            this.PainAreaSelectGB.Size = new System.Drawing.Size(162, 184);
            this.PainAreaSelectGB.TabIndex = 11;
            this.PainAreaSelectGB.TabStop = false;
            this.PainAreaSelectGB.Text = "Select Troubled Areas";
            // 
            // NeckShouldRB
            // 
            this.NeckShouldRB.AutoSize = true;
            this.NeckShouldRB.Location = new System.Drawing.Point(6, 39);
            this.NeckShouldRB.Name = "NeckShouldRB";
            this.NeckShouldRB.Size = new System.Drawing.Size(129, 21);
            this.NeckShouldRB.TabIndex = 3;
            this.NeckShouldRB.TabStop = true;
            this.NeckShouldRB.Text = "Neck/Shoulders";
            this.NeckShouldRB.UseVisualStyleBackColor = true;
            // 
            // BackRb
            // 
            this.BackRb.AutoSize = true;
            this.BackRb.Location = new System.Drawing.Point(6, 66);
            this.BackRb.Name = "BackRb";
            this.BackRb.Size = new System.Drawing.Size(145, 21);
            this.BackRb.TabIndex = 4;
            this.BackRb.TabStop = true;
            this.BackRb.Text = "Upper/Lower Back";
            this.BackRb.UseVisualStyleBackColor = true;
            // 
            // FullBodyRB
            // 
            this.FullBodyRB.AutoSize = true;
            this.FullBodyRB.Location = new System.Drawing.Point(6, 93);
            this.FullBodyRB.Name = "FullBodyRB";
            this.FullBodyRB.Size = new System.Drawing.Size(87, 21);
            this.FullBodyRB.TabIndex = 5;
            this.FullBodyRB.TabStop = true;
            this.FullBodyRB.Text = "Full Body";
            this.FullBodyRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeskHealthApp.Properties.Resources.FormBackfround1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(609, 465);
            this.Controls.Add(this.PainAreaSelectGB);
            this.Controls.Add(this.MedSlidL);
            this.Controls.Add(this.OptionsLB);
            this.Controls.Add(this.ReminderGB);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BreakLenTB);
            this.Controls.Add(this.BreakLengthLB);
            this.Controls.Add(this.WorkTimeLB);
            this.Controls.Add(this.WorkTimeTB);
            this.Controls.Add(this.StartB);
            this.Controls.Add(this.ActivityBox);
            this.Location = new System.Drawing.Point(250, 150);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DeskHealth";
            this.ActivityBox.ResumeLayout(false);
            this.ActivityBox.PerformLayout();
            this.ReminderGB.ResumeLayout(false);
            this.ReminderGB.PerformLayout();
            this.PainAreaSelectGB.ResumeLayout(false);
            this.PainAreaSelectGB.PerformLayout();
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
        public System.Windows.Forms.Timer RemindT;
        private System.Windows.Forms.Timer TimeBetweenReminder;
        private System.Windows.Forms.RadioButton MeditateRB;
        private System.Windows.Forms.Label MedSlidL;
        private System.Windows.Forms.ListBox OptionsLB;
        private System.Windows.Forms.GroupBox PainAreaSelectGB;
        private System.Windows.Forms.RadioButton FullBodyRB;
        private System.Windows.Forms.RadioButton BackRb;
        private System.Windows.Forms.RadioButton NeckShouldRB;
    }
}


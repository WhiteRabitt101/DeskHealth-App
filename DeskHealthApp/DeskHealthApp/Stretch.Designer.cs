
namespace DeskHealthApp
{
    partial class Stretch
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PreBtn = new System.Windows.Forms.Button();
            this.BreakLengT = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PrevTimer = new System.Windows.Forms.Timer(this.components);
            this.NextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(331, 368);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 368);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PreBtn
            // 
            this.PreBtn.Location = new System.Drawing.Point(228, 454);
            this.PreBtn.Name = "PreBtn";
            this.PreBtn.Size = new System.Drawing.Size(99, 33);
            this.PreBtn.TabIndex = 3;
            this.PreBtn.Text = "Previous";
            this.PreBtn.UseVisualStyleBackColor = true;
            this.PreBtn.Click += new System.EventHandler(this.PreBtn_Click);
            // 
            // BreakLengT
            // 
            this.BreakLengT.Tick += new System.EventHandler(this.BreakLengT_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrevTimer
            // 
            this.PrevTimer.Tick += new System.EventHandler(this.PrevTimer_Tick);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(416, 454);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(99, 33);
            this.NextBtn.TabIndex = 0;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Stretch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.PreBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NextBtn);
            this.Name = "Stretch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stretch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PreBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer PrevTimer;
        private System.Windows.Forms.Button NextBtn;
        public System.Windows.Forms.Timer BreakLengT;
    }
}
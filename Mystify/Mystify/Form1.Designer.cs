namespace Mystify
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
            this.NewLineBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewLineBtn
            // 
            this.NewLineBtn.Location = new System.Drawing.Point(357, 495);
            this.NewLineBtn.Name = "NewLineBtn";
            this.NewLineBtn.Size = new System.Drawing.Size(105, 57);
            this.NewLineBtn.TabIndex = 1;
            this.NewLineBtn.Text = "NewLine";
            this.NewLineBtn.UseVisualStyleBackColor = true;
            this.NewLineBtn.Click += new System.EventHandler(this.NewLineBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(468, 495);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(126, 57);
            this.PauseBtn.TabIndex = 2;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Location = new System.Drawing.Point(600, 495);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(117, 57);
            this.ResumeBtn.TabIndex = 3;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = true;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(723, 495);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(115, 57);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 551);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.NewLineBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewLineBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button ExitBtn;


    }
}


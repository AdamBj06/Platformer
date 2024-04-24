namespace Platformer
{
    partial class GamePlay
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Creator = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_FPS = new System.Windows.Forms.Label();
            this.lbl_p1Health = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Creator
            // 
            this.lbl_Creator.AutoSize = true;
            this.lbl_Creator.BackColor = System.Drawing.Color.Black;
            this.lbl_Creator.ForeColor = System.Drawing.Color.White;
            this.lbl_Creator.Location = new System.Drawing.Point(12, 578);
            this.lbl_Creator.Name = "lbl_Creator";
            this.lbl_Creator.Size = new System.Drawing.Size(109, 13);
            this.lbl_Creator.TabIndex = 6;
            this.lbl_Creator.Text = "By Adam Ben Jeddou";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.BackColor = System.Drawing.Color.Black;
            this.lbl_Version.ForeColor = System.Drawing.Color.White;
            this.lbl_Version.Location = new System.Drawing.Point(957, 578);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(31, 13);
            this.lbl_Version.TabIndex = 7;
            this.lbl_Version.Text = "v 0.0";
            // 
            // lbl_FPS
            // 
            this.lbl_FPS.AutoSize = true;
            this.lbl_FPS.Location = new System.Drawing.Point(949, 9);
            this.lbl_FPS.Name = "lbl_FPS";
            this.lbl_FPS.Size = new System.Drawing.Size(39, 13);
            this.lbl_FPS.TabIndex = 8;
            this.lbl_FPS.Text = "000fps";
            // 
            // lbl_p1Health
            // 
            this.lbl_p1Health.AutoSize = true;
            this.lbl_p1Health.Location = new System.Drawing.Point(12, 9);
            this.lbl_p1Health.Name = "lbl_p1Health";
            this.lbl_p1Health.Size = new System.Drawing.Size(35, 13);
            this.lbl_p1Health.TabIndex = 9;
            this.lbl_p1Health.Text = "label1";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lbl_p1Health);
            this.Controls.Add(this.lbl_FPS);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_Creator);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePlay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePlay_KeyUp);
            this.Resize += new System.EventHandler(this.GamePlay_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Creator;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_FPS;
        private System.Windows.Forms.Label lbl_p1Health;
    }
}
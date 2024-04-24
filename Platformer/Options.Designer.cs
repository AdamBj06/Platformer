namespace Platformer
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_FullScreen = new System.Windows.Forms.Button();
            this.btn_ShowFPS = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FullScreen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show FPS";
            // 
            // btn_FullScreen
            // 
            this.btn_FullScreen.Location = new System.Drawing.Point(75, 17);
            this.btn_FullScreen.Name = "btn_FullScreen";
            this.btn_FullScreen.Size = new System.Drawing.Size(20, 20);
            this.btn_FullScreen.TabIndex = 2;
            this.btn_FullScreen.UseVisualStyleBackColor = true;
            this.btn_FullScreen.Click += new System.EventHandler(this.btn_FullScreen_Click);
            // 
            // btn_ShowFPS
            // 
            this.btn_ShowFPS.Location = new System.Drawing.Point(75, 47);
            this.btn_ShowFPS.Name = "btn_ShowFPS";
            this.btn_ShowFPS.Size = new System.Drawing.Size(20, 20);
            this.btn_ShowFPS.TabIndex = 3;
            this.btn_ShowFPS.UseVisualStyleBackColor = true;
            this.btn_ShowFPS.Click += new System.EventHandler(this.btn_ShowFPS_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(316, 526);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(397, 526);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 5;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_ShowFPS);
            this.Controls.Add(this.btn_FullScreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.Shown += new System.EventHandler(this.Options_Shown);
            this.Resize += new System.EventHandler(this.Options_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_FullScreen;
        private System.Windows.Forms.Button btn_ShowFPS;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button Btn_Back;
    }
}
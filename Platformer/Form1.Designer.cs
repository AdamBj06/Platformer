namespace Platformer
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_PlayerDec = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Options = new System.Windows.Forms.Button();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Creator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(323, 97);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(276, 135);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Title";
            // 
            // btn_PlayerDec
            // 
            this.btn_PlayerDec.Location = new System.Drawing.Point(207, 298);
            this.btn_PlayerDec.Name = "btn_PlayerDec";
            this.btn_PlayerDec.Size = new System.Drawing.Size(135, 23);
            this.btn_PlayerDec.TabIndex = 1;
            this.btn_PlayerDec.Text = "player customization";
            this.btn_PlayerDec.UseVisualStyleBackColor = true;
            this.btn_PlayerDec.Click += new System.EventHandler(this.btn_PlayerDec_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(432, 298);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 23);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.Text = "play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Options
            // 
            this.btn_Options.Location = new System.Drawing.Point(605, 298);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(75, 23);
            this.btn_Options.TabIndex = 3;
            this.btn_Options.Text = "options";
            this.btn_Options.UseVisualStyleBackColor = true;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(937, 539);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(31, 13);
            this.lbl_Version.TabIndex = 4;
            this.lbl_Version.Text = "v 0.0";
            // 
            // lbl_Creator
            // 
            this.lbl_Creator.AutoSize = true;
            this.lbl_Creator.Location = new System.Drawing.Point(12, 539);
            this.lbl_Creator.Name = "lbl_Creator";
            this.lbl_Creator.Size = new System.Drawing.Size(109, 13);
            this.lbl_Creator.TabIndex = 5;
            this.lbl_Creator.Text = "By Adam Ben Jeddou";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lbl_Creator);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_PlayerDec);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_PlayerDec;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Creator;
    }
}


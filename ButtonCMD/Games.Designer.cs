namespace ButtonCMD
{
    partial class Games
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
            this.Steam_pictureBox = new System.Windows.Forms.PictureBox();
            this.штащ_label = new System.Windows.Forms.Label();
            this.Epic_pictureBox = new System.Windows.Forms.PictureBox();
            this.Uplay_pictureBox = new System.Windows.Forms.PictureBox();
            this.Rock_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Steam_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epic_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uplay_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Steam_pictureBox
            // 
            this.Steam_pictureBox.Image = global::ButtonCMD.Properties.Resources.Steam1;
            this.Steam_pictureBox.Location = new System.Drawing.Point(44, 71);
            this.Steam_pictureBox.Name = "Steam_pictureBox";
            this.Steam_pictureBox.Size = new System.Drawing.Size(60, 55);
            this.Steam_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Steam_pictureBox.TabIndex = 1;
            this.Steam_pictureBox.TabStop = false;
            this.Steam_pictureBox.Click += new System.EventHandler(this.Steam_pictureBox_Click);
            // 
            // штащ_label
            // 
            this.штащ_label.AutoSize = true;
            this.штащ_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.штащ_label.Location = new System.Drawing.Point(16, 28);
            this.штащ_label.Name = "штащ_label";
            this.штащ_label.Size = new System.Drawing.Size(504, 25);
            this.штащ_label.TabIndex = 2;
            this.штащ_label.Text = "Оберіть та натисніть на одну з ігрових платформ";
            // 
            // Epic_pictureBox
            // 
            this.Epic_pictureBox.Image = global::ButtonCMD.Properties.Resources.epic;
            this.Epic_pictureBox.Location = new System.Drawing.Point(155, 71);
            this.Epic_pictureBox.Name = "Epic_pictureBox";
            this.Epic_pictureBox.Size = new System.Drawing.Size(60, 55);
            this.Epic_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Epic_pictureBox.TabIndex = 3;
            this.Epic_pictureBox.TabStop = false;
            this.Epic_pictureBox.Click += new System.EventHandler(this.Epic_pictureBox_Click);
            // 
            // Uplay_pictureBox
            // 
            this.Uplay_pictureBox.Image = global::ButtonCMD.Properties.Resources.uplay;
            this.Uplay_pictureBox.Location = new System.Drawing.Point(273, 71);
            this.Uplay_pictureBox.Name = "Uplay_pictureBox";
            this.Uplay_pictureBox.Size = new System.Drawing.Size(60, 55);
            this.Uplay_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Uplay_pictureBox.TabIndex = 4;
            this.Uplay_pictureBox.TabStop = false;
            this.Uplay_pictureBox.Click += new System.EventHandler(this.Uplay_pictureBox_Click);
            // 
            // Rock_pictureBox
            // 
            this.Rock_pictureBox.Image = global::ButtonCMD.Properties.Resources.rockstar;
            this.Rock_pictureBox.Location = new System.Drawing.Point(392, 71);
            this.Rock_pictureBox.Name = "Rock_pictureBox";
            this.Rock_pictureBox.Size = new System.Drawing.Size(60, 55);
            this.Rock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rock_pictureBox.TabIndex = 5;
            this.Rock_pictureBox.TabStop = false;
            this.Rock_pictureBox.Click += new System.EventHandler(this.Rock_pictureBox_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(532, 188);
            this.Controls.Add(this.Rock_pictureBox);
            this.Controls.Add(this.Uplay_pictureBox);
            this.Controls.Add(this.Epic_pictureBox);
            this.Controls.Add(this.штащ_label);
            this.Controls.Add(this.Steam_pictureBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Games";
            this.Text = "Games";
            ((System.ComponentModel.ISupportInitialize)(this.Steam_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epic_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uplay_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Steam_pictureBox;
        private System.Windows.Forms.Label штащ_label;
        private System.Windows.Forms.PictureBox Epic_pictureBox;
        private System.Windows.Forms.PictureBox Uplay_pictureBox;
        private System.Windows.Forms.PictureBox Rock_pictureBox;
    }
}
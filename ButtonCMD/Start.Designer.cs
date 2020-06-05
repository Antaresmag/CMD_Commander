namespace ButtonCMD
{
    partial class Start
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
            this.StartProgram = new System.Windows.Forms.Button();
            this.CloseProgram = new System.Windows.Forms.Button();
            this.free_ver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartProgram
            // 
            this.StartProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartProgram.FlatAppearance.BorderSize = 0;
            this.StartProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.StartProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartProgram.ForeColor = System.Drawing.Color.Green;
            this.StartProgram.Location = new System.Drawing.Point(116, 87);
            this.StartProgram.Name = "StartProgram";
            this.StartProgram.Size = new System.Drawing.Size(73, 45);
            this.StartProgram.TabIndex = 1;
            this.StartProgram.Text = "Start\r\n===>";
            this.StartProgram.UseVisualStyleBackColor = false;
            this.StartProgram.Click += new System.EventHandler(this.StartProgram_Click);
            // 
            // CloseProgram
            // 
            this.CloseProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseProgram.FlatAppearance.BorderSize = 0;
            this.CloseProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CloseProgram.ForeColor = System.Drawing.Color.Red;
            this.CloseProgram.Location = new System.Drawing.Point(25, 87);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.Size = new System.Drawing.Size(73, 45);
            this.CloseProgram.TabIndex = 2;
            this.CloseProgram.Text = "Close\r\n X";
            this.CloseProgram.UseVisualStyleBackColor = false;
            this.CloseProgram.Click += new System.EventHandler(this.CloseProgram_Click);
            // 
            // free_ver
            // 
            this.free_ver.AutoSize = true;
            this.free_ver.Location = new System.Drawing.Point(-1, 165);
            this.free_ver.Name = "free_ver";
            this.free_ver.Size = new System.Drawing.Size(49, 13);
            this.free_ver.TabIndex = 3;
            this.free_ver.Text = "Free ver.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Commander";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(223, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.free_ver);
            this.Controls.Add(this.CloseProgram);
            this.Controls.Add(this.StartProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.Text = "Start";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Start_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartProgram;
        private System.Windows.Forms.Button CloseProgram;
        private System.Windows.Forms.Label free_ver;
        private System.Windows.Forms.Label label1;
    }
}
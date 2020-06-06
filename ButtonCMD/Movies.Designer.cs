namespace ButtonCMD
{
    partial class Movies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movies));
            this.close_button = new System.Windows.Forms.Button();
            this.films_select_groupBox = new System.Windows.Forms.GroupBox();
            this.Anime_radioButton = new System.Windows.Forms.RadioButton();
            this.Online_lessons_radioButton = new System.Windows.Forms.RadioButton();
            this.Premieres_radioButton = new System.Windows.Forms.RadioButton();
            this.Сartoons_radioButton = new System.Windows.Forms.RadioButton();
            this.Serials_radioButton = new System.Windows.Forms.RadioButton();
            this.languages_groupBox = new System.Windows.Forms.GroupBox();
            this.ukraine_language_groupBox = new System.Windows.Forms.RadioButton();
            this.english_language_groupBox = new System.Windows.Forms.RadioButton();
            this.search_button = new System.Windows.Forms.Button();
            this.ua_picture = new System.Windows.Forms.PictureBox();
            this.usa_picture = new System.Windows.Forms.PictureBox();
            this.films_select_groupBox.SuspendLayout();
            this.languages_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ua_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usa_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(221, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(18, 28);
            this.close_button.TabIndex = 14;
            this.close_button.Text = "x";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // films_select_groupBox
            // 
            this.films_select_groupBox.Controls.Add(this.Anime_radioButton);
            this.films_select_groupBox.Controls.Add(this.Online_lessons_radioButton);
            this.films_select_groupBox.Controls.Add(this.Premieres_radioButton);
            this.films_select_groupBox.Controls.Add(this.Сartoons_radioButton);
            this.films_select_groupBox.Controls.Add(this.Serials_radioButton);
            this.films_select_groupBox.Enabled = false;
            this.films_select_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.films_select_groupBox.ForeColor = System.Drawing.Color.White;
            this.films_select_groupBox.Location = new System.Drawing.Point(12, 128);
            this.films_select_groupBox.Name = "films_select_groupBox";
            this.films_select_groupBox.Size = new System.Drawing.Size(214, 211);
            this.films_select_groupBox.TabIndex = 15;
            this.films_select_groupBox.TabStop = false;
            this.films_select_groupBox.Text = "Доступні такі варіанти";
            this.films_select_groupBox.Enter += new System.EventHandler(this.films_select_groupBox_Enter);
            // 
            // Anime_radioButton
            // 
            this.Anime_radioButton.AutoSize = true;
            this.Anime_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Anime_radioButton.Location = new System.Drawing.Point(6, 168);
            this.Anime_radioButton.Name = "Anime_radioButton";
            this.Anime_radioButton.Size = new System.Drawing.Size(93, 29);
            this.Anime_radioButton.TabIndex = 4;
            this.Anime_radioButton.TabStop = true;
            this.Anime_radioButton.Text = "Аніме";
            this.Anime_radioButton.UseVisualStyleBackColor = true;
            this.Anime_radioButton.CheckedChanged += new System.EventHandler(this.Anime_radioButton_CheckedChanged);
            // 
            // Online_lessons_radioButton
            // 
            this.Online_lessons_radioButton.AutoSize = true;
            this.Online_lessons_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Online_lessons_radioButton.Location = new System.Drawing.Point(6, 133);
            this.Online_lessons_radioButton.Name = "Online_lessons_radioButton";
            this.Online_lessons_radioButton.Size = new System.Drawing.Size(182, 29);
            this.Online_lessons_radioButton.TabIndex = 3;
            this.Online_lessons_radioButton.TabStop = true;
            this.Online_lessons_radioButton.Text = "Онлайн уроки";
            this.Online_lessons_radioButton.UseVisualStyleBackColor = true;
            this.Online_lessons_radioButton.CheckedChanged += new System.EventHandler(this.Online_lessons_radioButton_CheckedChanged);
            // 
            // Premieres_radioButton
            // 
            this.Premieres_radioButton.AutoSize = true;
            this.Premieres_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Premieres_radioButton.Location = new System.Drawing.Point(6, 98);
            this.Premieres_radioButton.Name = "Premieres_radioButton";
            this.Premieres_radioButton.Size = new System.Drawing.Size(131, 29);
            this.Premieres_radioButton.TabIndex = 2;
            this.Premieres_radioButton.TabStop = true;
            this.Premieres_radioButton.Text = "Прем\'єри";
            this.Premieres_radioButton.UseVisualStyleBackColor = true;
            this.Premieres_radioButton.CheckedChanged += new System.EventHandler(this.Premieres_radioButton_CheckedChanged);
            // 
            // Сartoons_radioButton
            // 
            this.Сartoons_radioButton.AutoSize = true;
            this.Сartoons_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сartoons_radioButton.Location = new System.Drawing.Point(6, 63);
            this.Сartoons_radioButton.Name = "Сartoons_radioButton";
            this.Сartoons_radioButton.Size = new System.Drawing.Size(175, 29);
            this.Сartoons_radioButton.TabIndex = 1;
            this.Сartoons_radioButton.TabStop = true;
            this.Сartoons_radioButton.Text = "Мультфільми";
            this.Сartoons_radioButton.UseVisualStyleBackColor = true;
            this.Сartoons_radioButton.CheckedChanged += new System.EventHandler(this.Сartoons_radioButton_CheckedChanged);
            // 
            // Serials_radioButton
            // 
            this.Serials_radioButton.AutoSize = true;
            this.Serials_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serials_radioButton.Location = new System.Drawing.Point(6, 28);
            this.Serials_radioButton.Name = "Serials_radioButton";
            this.Serials_radioButton.Size = new System.Drawing.Size(117, 29);
            this.Serials_radioButton.TabIndex = 0;
            this.Serials_radioButton.TabStop = true;
            this.Serials_radioButton.Text = "Серіали";
            this.Serials_radioButton.UseVisualStyleBackColor = true;
            this.Serials_radioButton.CheckedChanged += new System.EventHandler(this.Serials_radioButton_CheckedChanged);
            // 
            // languages_groupBox
            // 
            this.languages_groupBox.Controls.Add(this.ua_picture);
            this.languages_groupBox.Controls.Add(this.usa_picture);
            this.languages_groupBox.Controls.Add(this.ukraine_language_groupBox);
            this.languages_groupBox.Controls.Add(this.english_language_groupBox);
            this.languages_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.languages_groupBox.ForeColor = System.Drawing.Color.White;
            this.languages_groupBox.Location = new System.Drawing.Point(12, 22);
            this.languages_groupBox.Name = "languages_groupBox";
            this.languages_groupBox.Size = new System.Drawing.Size(214, 100);
            this.languages_groupBox.TabIndex = 16;
            this.languages_groupBox.TabStop = false;
            this.languages_groupBox.Text = "Обреріть мову фільмів";
            // 
            // ukraine_language_groupBox
            // 
            this.ukraine_language_groupBox.AutoSize = true;
            this.ukraine_language_groupBox.Location = new System.Drawing.Point(100, 55);
            this.ukraine_language_groupBox.Name = "ukraine_language_groupBox";
            this.ukraine_language_groupBox.Size = new System.Drawing.Size(108, 20);
            this.ukraine_language_groupBox.TabIndex = 0;
            this.ukraine_language_groupBox.TabStop = true;
            this.ukraine_language_groupBox.Text = "Українська";
            this.ukraine_language_groupBox.UseVisualStyleBackColor = true;
            this.ukraine_language_groupBox.CheckedChanged += new System.EventHandler(this.ukraine_language_groupBox_CheckedChanged);
            // 
            // english_language_groupBox
            // 
            this.english_language_groupBox.AutoSize = true;
            this.english_language_groupBox.Location = new System.Drawing.Point(6, 55);
            this.english_language_groupBox.Name = "english_language_groupBox";
            this.english_language_groupBox.Size = new System.Drawing.Size(77, 20);
            this.english_language_groupBox.TabIndex = 0;
            this.english_language_groupBox.TabStop = true;
            this.english_language_groupBox.Text = "English";
            this.english_language_groupBox.UseVisualStyleBackColor = true;
            this.english_language_groupBox.CheckedChanged += new System.EventHandler(this.english_language_groupBox_CheckedChanged);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(12, 346);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(214, 34);
            this.search_button.TabIndex = 17;
            this.search_button.Text = "ПОШУК";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // ua_picture
            // 
            this.ua_picture.Image = global::ButtonCMD.Properties.Resources.ua;
            this.ua_picture.Location = new System.Drawing.Point(100, 21);
            this.ua_picture.Name = "ua_picture";
            this.ua_picture.Size = new System.Drawing.Size(61, 28);
            this.ua_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ua_picture.TabIndex = 2;
            this.ua_picture.TabStop = false;
            // 
            // usa_picture
            // 
            this.usa_picture.Image = ((System.Drawing.Image)(resources.GetObject("usa_picture.Image")));
            this.usa_picture.Location = new System.Drawing.Point(6, 21);
            this.usa_picture.Name = "usa_picture";
            this.usa_picture.Size = new System.Drawing.Size(61, 28);
            this.usa_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usa_picture.TabIndex = 1;
            this.usa_picture.TabStop = false;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(239, 390);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.languages_groupBox);
            this.Controls.Add(this.films_select_groupBox);
            this.Controls.Add(this.close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Movies";
            this.Text = "Movies";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movies_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Movies_MouseMove);
            this.films_select_groupBox.ResumeLayout(false);
            this.films_select_groupBox.PerformLayout();
            this.languages_groupBox.ResumeLayout(false);
            this.languages_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ua_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usa_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.GroupBox films_select_groupBox;
        private System.Windows.Forms.RadioButton Online_lessons_radioButton;
        private System.Windows.Forms.RadioButton Premieres_radioButton;
        private System.Windows.Forms.RadioButton Сartoons_radioButton;
        private System.Windows.Forms.RadioButton Serials_radioButton;
        private System.Windows.Forms.RadioButton Anime_radioButton;
        private System.Windows.Forms.GroupBox languages_groupBox;
        private System.Windows.Forms.RadioButton english_language_groupBox;
        private System.Windows.Forms.RadioButton ukraine_language_groupBox;
        private System.Windows.Forms.PictureBox ua_picture;
        private System.Windows.Forms.PictureBox usa_picture;
        private System.Windows.Forms.Button search_button;
    }
}
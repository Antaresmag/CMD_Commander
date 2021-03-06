﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCMD
{
    public partial class Games : Form
    {

        public Games()
        {
            InitializeComponent();
        }
        private void steam_button_Click(object sender, EventArgs e)
        {
       
        }

        private void Steam_pictureBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
            System.Diagnostics.Process.Start("https://steamcommunity.com/");
            this.Close();
        }

        private void Epic_pictureBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
            System.Diagnostics.Process.Start("https://www.epicgames.com/");
            this.Close();
        }

        private void Uplay_pictureBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
            System.Diagnostics.Process.Start("https://uplay.ubisoft.com/");
            this.Close();
        }

        private void Rock_pictureBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
            System.Diagnostics.Process.Start("https://www.rockstargames.com/");
            this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void Games_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Games_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

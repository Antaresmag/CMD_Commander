using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCMD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void drink_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.coca-cola.ua/");
        }

        private void eat_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mcdonalds.ua/");
        }

        private void trip_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://shark-taxi.ua/");
        }

        private void drunk_button_Click(object sender, EventArgs e)
        {
            if(checkBox_year.Checked == true)
            {
                System.Diagnostics.Process.Start("https://winetime.com.ua/");
            }
            else 
            MessageBox.Show("Ви маєте підтвердити, що вам є 21 рік", "Відмова у доступі", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void checkBox_year_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
      private Process telega;

        private void telga_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.telegram.org/");
           // telega = System.Diagnostics.Process.Start("DLC\\Bhop.ahk");
        }

        private void face_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void insta_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void films_button_Click(object sender, EventArgs e)
        {

        }

        private void game_button_Click(object sender, EventArgs e)
        {

        }
    }
}

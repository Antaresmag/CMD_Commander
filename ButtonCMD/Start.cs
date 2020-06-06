using System;
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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void StartProgram_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main form_m = new Main();
           // this.Hide();
            form_m.Show();
           
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void Start_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

       
    }
}

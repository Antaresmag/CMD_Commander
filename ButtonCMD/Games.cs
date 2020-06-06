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
        }

        private void Epic_pictureBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
            System.Diagnostics.Process.Start("https://www.epicgames.com/");
        }

        private void Uplay_pictureBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
            System.Diagnostics.Process.Start("https://uplay.ubisoft.com/");
        }

        private void Rock_pictureBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
            System.Diagnostics.Process.Start("https://www.rockstargames.com/");
        }
    }
}

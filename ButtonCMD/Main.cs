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
           
        }

        private void drunk_button_Click(object sender, EventArgs e)
        {
            int g = 1;
            if(checkBox_year.Checked == true)
            {
                System.Diagnostics.Process.Start("https://steamcommunity.com/");
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
    }
}

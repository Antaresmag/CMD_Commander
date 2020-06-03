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
            Main newForm = new Main();
            newForm.Show();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool lang_e = false;
        private void english_language_groupBox_CheckedChanged(object sender, EventArgs e)
        {
            if (english_language_groupBox.Checked)
            {
                films_select_groupBox.Enabled = true;
                lang_e = true;
                return;
            }
        }
        bool lang_u = false;
        private void ukraine_language_groupBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ukraine_language_groupBox.Checked == true)
            {
                films_select_groupBox.Enabled = true;
                lang_u = true;
                return;
            }
        }

        private void films_select_groupBox_Enter(object sender, EventArgs e)
        {
            
               
        }

        private void Serials_radioButton_CheckedChanged(object sender, EventArgs e)
        {

            //if (lang_e == true)
            //{
            //    System.Diagnostics.Process.Start("https://www.netflix.com/");
            //    return;
            //}
            //else if (lang_u == true)
            //{
            //    System.Diagnostics.Process.Start("https://megogo.net/ua/series?utm_source=megogo&utm_medium=series&utm_campaign=series_series");
            //    return;
            //}
        }

        private void Сartoons_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (lang_e == true)
            //{
            //    System.Diagnostics.Process.Start("https://www.englishdom.com/blog/top-10-multfilmiv-anglijskoyu-movoyu/");
            //    return;
            //}
            //else if (lang_u == true)
            //{
            //    System.Diagnostics.Process.Start("https://megogo.net/ua/mult?utm_source=megogo&utm_medium=mult&utm_campaign=mult_mult");
            //    return;
            //}
        }

        private void Premieres_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (lang_e == true)
            //{
            //    System.Diagnostics.Process.Start("https://www.netflix.com/latest");
            //    return;
            //}
            //else if (lang_u == true)
            //{
            //    System.Diagnostics.Process.Start("https://megogo.net/ua/premiere/main");
            //    return;
            //}
        }

        private void Online_lessons_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (lang_e == true)
            //{
            //    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=nVm-DYdAsts");
            //    return;
            //}
            //else if (lang_u == true)
            //{
            //    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=g80ZUGbP6SE");
            //    return;
            //}
        }

        private void Anime_radioButton_CheckedChanged(object sender, EventArgs e)
        {

            //if (lang_e == true)
            //{
            //    System.Diagnostics.Process.Start("https://www.anime-planet.com/anime/");
            //    return;
            //}
            //else if (lang_u == true)
            //{
            //    System.Diagnostics.Process.Start("https://animevost.org/");
            //    return;
            //}
        }

        private void search_button_Click(object sender, EventArgs e)
        {

            if (lang_e == true && Serials_radioButton.Checked == true)
            {
                System.Diagnostics.Process.Start("https://www.netflix.com/");
                return;
            }
            else if (lang_u == true && Serials_radioButton.Checked == true)
            {
                System.Diagnostics.Process.Start("https://megogo.net/ua/series?utm_source=megogo&utm_medium=series&utm_campaign=series_series");
                return;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlstomVideo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btVideo1_Click(object sender, EventArgs e)
        {
            Video video = new Video(1);
            video.Show();
        }

        private void btVideo2_Click(object sender, EventArgs e)
        {
            Video video = new Video(2);
            video.Show();
        }

        private void btVideo3_Click(object sender, EventArgs e)
        {
            Video video = new Video(3);
            video.Show();
        }

        private void btVideo4_Click(object sender, EventArgs e)
        {
            Video video = new Video(4);
            video.Show();
        }

        private void btVideo5_Click(object sender, EventArgs e)
        {
            Video video = new Video(5);
            video.Show();
        }

        private void btVideo6_Click(object sender, EventArgs e)
        {
            Video video = new Video(6);
            video.Show();
        }

        private void btVideo7_Click(object sender, EventArgs e)
        {
            Video video = new Video(7);
            video.Show();
        }

        private void btVideo8_Click(object sender, EventArgs e)
        {
            Video video = new Video(8);
            video.Show();
        }




    }
}

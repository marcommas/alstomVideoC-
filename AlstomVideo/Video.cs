using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AlstomVideo
{
    public partial class Video : Form
    {
        public Video(int idVideo)
        {
            InitializeComponent();

            mostraVideo(idVideo);
        }

        public void mostraVideo(int idVideo)
        {
            if (idVideo == 1)
            {
  
                axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video1.avi";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

            if (idVideo == 2)
            {

                axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video2.avi";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

            if (idVideo == 3)
            {

                axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video3.avi";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

            if (idVideo == 4)
            {

                axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video4.avi";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

            if (idVideo == 5)
            {

                axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video5.avi";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

            if (idVideo == 6)
            {

                axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video6.avi";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

            if (idVideo == 7)
            {

                axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video7.avi";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

            if (idVideo == 8)
            {

                axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video8.avi";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }

        }


    }
}

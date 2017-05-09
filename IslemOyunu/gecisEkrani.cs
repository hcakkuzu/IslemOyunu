using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using AxWMPLib;
using WMPLib;

namespace IslemOyunu
{
    public partial class gecisEkrani : Form
    {
        public gecisEkrani()
        {
            InitializeComponent();
        }
        WindowsMediaPlayer arkaMuzik = new WindowsMediaPlayer();
        private void devamBtn_MouseEnter(object sender, EventArgs e)
        {
            devamBtn.BackgroundImage = Properties.Resources.devam2;
            Ses.Click_Play();
        }

        private void devamBtn_MouseLeave(object sender, EventArgs e)
        {
            devamBtn.BackgroundImage = Properties.Resources.devam1;
        }

        private void cikisBtn_MouseEnter(object sender, EventArgs e)
        {
            Ses.Click_Play();
            cikisBtn.BackgroundImage = Properties.Resources.cikis2;
        }

        private void cikisBtn_MouseLeave(object sender, EventArgs e)
        {
            cikisBtn.BackgroundImage = Properties.Resources.cikis1;
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gecisEkrani_Load(object sender, EventArgs e)
        {
            Degisken.toplama = false;
            Degisken.cikarma = false;
            Degisken.carpma = false;
            Degisken.bolme = false;
            Degisken.skor = 0;
            Degisken.soruBasinaPuan = 0;
            arkaMuzik.URL = "Sounds//arkamuzik.wav";
            if (Degisken.muzikcaliyormu == true)
            {
                arkaMuzik.controls.play();
                arkaMuzik.settings.setMode("Loop", true);
            }
            else
            {
                SesKis.BackgroundImage = Properties.Resources.soundless;
                arkaMuzik.controls.stop();
            }

        }

        private void SesKis_Click(object sender, EventArgs e)
        {
            if (Degisken.muzikcaliyormu == true)
            {
                arkaMuzik.controls.stop();
                SesKis.BackgroundImage = Properties.Resources.soundless;
                Degisken.muzikcaliyormu = false;
            }
            else
            {
                arkaMuzik.controls.play();
                SesKis.BackgroundImage = Properties.Resources.sound;
                Degisken.muzikcaliyormu = true;
            }
        }

        private void devamBtn_Click(object sender, EventArgs e)
        {
            if (zorluk1.Checked)
            {
                Degisken.zorluk = 1;
                Degisken.soruBasinaPuan += 10;
            }
            else if (zorluk2.Checked)
            {
                Degisken.zorluk = 2;
                Degisken.soruBasinaPuan += 25;
            }
            else if (zorluk3.Checked)
            {
                Degisken.zorluk = 3;
                Degisken.soruBasinaPuan += 50;
            }

            if (sure1.Checked)
            {
                Degisken.sure = 60;
                Degisken.soruBasinaPuan += 30;
            }
            else if (sure2.Checked)
            {
                Degisken.sure = 120;
                Degisken.soruBasinaPuan += 15;
            }
            else if (sure3.Checked)
            {
                Degisken.sure = 180;
                Degisken.soruBasinaPuan += 10;
            }

            if (!toplamaCBox.Checked && !cikarmaCBox.Checked && !carpmaCBox.Checked && !bolmeCBox.Checked) MessageBox.Show("Lütfen en az bir adet işlem seçiniz.");
            else
            {
                if (toplamaCBox.Checked)
                {
                    Degisken.toplama = true;

                }
                if (cikarmaCBox.Checked)
                {
                    Degisken.cikarma = true;

                }
                if (carpmaCBox.Checked)
                {
                    Degisken.carpma = true;

                }
                if (bolmeCBox.Checked)
                {
                    Degisken.bolme = true;

                }
                Oyun form = new Oyun();
                form.Show();
                this.Close();
                arkaMuzik.controls.stop();
            }



        }
    }
}

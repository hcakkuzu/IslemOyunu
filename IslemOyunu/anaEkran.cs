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
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer arkaMuzik = new WindowsMediaPlayer();

        bool yon = false;
        public void cikisBtn_MouseEnter(object sender, EventArgs e)
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

        private void anaEkran_Load(object sender, EventArgs e)
        {
            arkaMuzik.URL = "Sounds//arkamuzik.wav";
            arkaMuzik.controls.play();
            arkaMuzik.settings.setMode("Loop", true);
            Degisken.muzikcaliyormu = true;
            kayanYazi.Start();
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

        private void oynaBtn_MouseEnter(object sender, EventArgs e)
        {
            oynaBtn.BackgroundImage = Properties.Resources.oyna2;
            Task.Factory.StartNew(Ses.Click_Play);
        }

        private void oynaBtn_MouseLeave(object sender, EventArgs e)
        {
            oynaBtn.BackgroundImage = Properties.Resources.oyna1;
        }

        private void kayanYazi_Tick(object sender, EventArgs e)
        {
            if (label1.Left <= 15) yon = true;
            else if (label1.Left >= (this.Width - label1.Width - 20)) yon = false;

            if (yon == false)
            {
                label1.Left -= 6;
            }
            else label1.Left += 6;
        }

        private void oynaBtn_Click(object sender, EventArgs e)
        {
            arkaMuzik.controls.stop();
            Ses.Click_Play();
            gecisEkrani form = new gecisEkrani();
            form.Show();
            this.Hide();
        }

        private void yuksekSkorBtn_MouseEnter(object sender, EventArgs e)
        {
            yuksekSkorBtn.BackgroundImage = Properties.Resources.skor2;
            Ses.Click_Play();
        }

        private void yuksekSkorBtn_MouseLeave(object sender, EventArgs e)
        {
            yuksekSkorBtn.BackgroundImage = Properties.Resources.skor1;
        }

        private void yuksekSkorBtn_Click(object sender, EventArgs e)
        {
            YuksekSkorlar dialog = new YuksekSkorlar();
            dialog.ShowDialog();
        }
    }
}

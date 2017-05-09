using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Media;
using AxWMPLib;
using WMPLib;
namespace IslemOyunu
{
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }
        List<string> islemListesi = new List<string>();
        Random rastgele = new Random();
        int islem;
        public int sayi1, sayi2;
        public int islemsonucu = 0;
        WindowsMediaPlayer arkaMuzik = new WindowsMediaPlayer();
        public void yeniSoru()
        {
            islem = rastgele.Next(0, islemListesi.Count);

            if (islemListesi[islem] == "toplama") toplamaSorusuGetir();
            if (islemListesi[islem] == "cikarma") cikarmaSorusuGetir();
            if (islemListesi[islem] == "carpma") carpmaSorusuGetir();
            if (islemListesi[islem] == "bolme") bolmeSorusuGetir();
        }

        public void toplamaSorusuGetir()
        {
            int sinir = 0;

            if (Degisken.zorluk == 1) sinir = 10;
            else if (Degisken.zorluk == 2) sinir = 50;
            else if (Degisken.zorluk == 3) sinir = 100;

            sayi1 = rastgele.Next(1, sinir);
            sayi2 = rastgele.Next(1, sinir);

            islemsonucu = sayi1 + sayi2;
            isaretLbl.Text = "+";

            if (sayi1 > sayi2)
            {
                sayi1Lbl.Text = sayi1.ToString();
                sayi2Lbl.Text = sayi2.ToString();
            }
            else
            {
                sayi1Lbl.Text = sayi2.ToString();
                sayi2Lbl.Text = sayi1.ToString();
            }
        }


        public void cikarmaSorusuGetir()
        {
            int sinir = 0;

            if (Degisken.zorluk == 1) sinir = 10;
            else if (Degisken.zorluk == 2) sinir = 50;
            else if (Degisken.zorluk == 3) sinir = 100;

            sayi1 = rastgele.Next(1, sinir);
            sayi2 = rastgele.Next(1, sinir);

            isaretLbl.Text = "-";

            if (sayi1 > sayi2)
            {
                islemsonucu = sayi1 - sayi2;
                sayi1Lbl.Text = sayi1.ToString();
                sayi2Lbl.Text = sayi2.ToString();
            }
            else
            {
                islemsonucu = sayi2 - sayi1;
                sayi1Lbl.Text = sayi2.ToString();
                sayi2Lbl.Text = sayi1.ToString();
            }
        }

        public void carpmaSorusuGetir()
        {
            int sinir = 0;

            if (Degisken.zorluk == 1) sinir = 10;
            else if (Degisken.zorluk == 2) sinir = 25;
            else if (Degisken.zorluk == 3) sinir = 50;

            sayi1 = rastgele.Next(1, sinir);
            sayi2 = rastgele.Next(1, 10);

            islemsonucu = sayi1 * sayi2;
            isaretLbl.Text = "x";

            if (sayi1 > sayi2)
            {
                sayi1Lbl.Text = sayi1.ToString();
                sayi2Lbl.Text = sayi2.ToString();
            }
            else
            {
                sayi1Lbl.Text = sayi2.ToString();
                sayi2Lbl.Text = sayi1.ToString();
            }
        }

        public void bolmeSorusuGetir()
        {
            int sinir = 0;

            if (Degisken.zorluk == 1) sinir = 5;
            else if (Degisken.zorluk == 2) sinir = 25;
            else if (Degisken.zorluk == 3) sinir = 50;

            sayi1 = rastgele.Next(1, sinir);
            sayi2 = rastgele.Next(1, 10);

            int carpim = sayi1 * sayi2;
            islemsonucu = carpim / sayi2;
            isaretLbl.Text = "/";

            sayi1Lbl.Text = carpim.ToString();
            sayi2Lbl.Text = sayi2.ToString();
        }


        private void Oyun_Load(object sender, EventArgs e)
        {
            sureLbl.Text = Degisken.sure.ToString();
            Degisken.Secilensure = Degisken.sure;
            skorLbl.Text = "0";
            sonucLbl.Text = "";
            Zaman.Start();
            islemListesi.Clear();
            if (Degisken.toplama == true) islemListesi.Add("toplama");
            if (Degisken.cikarma == true) islemListesi.Add("cikarma");
            if (Degisken.carpma == true) islemListesi.Add("carpma");
            if (Degisken.bolme == true) islemListesi.Add("bolme");
            arkaMuzik.URL = "Sounds//oyunmuzik.wav";
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
            yeniSoru();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sonucLbl.Text = "";
        }

        private void Zaman_Tick(object sender, EventArgs e)
        {
            Degisken.sure--;
            sureLbl.Text = Degisken.sure.ToString();
            if (Degisken.sure <= 0)
            {
                Zaman.Stop();
                SonEkran form = new SonEkran();
                arkaMuzik.controls.stop();
                form.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "9";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            sonucLbl.Text += "0";
        }

        private void sonucLbl_TextChanged(object sender, EventArgs e)
        {
            if (sonucLbl.Text == islemsonucu.ToString())
            {
                Ses.sesCal("correct.wav");
                sonucLbl.Text = "";

                switch (isaretLbl.Text)
                {
                    case "+":
                        {
                            Degisken.toplamaDogru++;
                            if (islemsonucu <= 20) Degisken.skor += (Degisken.soruBasinaPuan);
                            else if (islemsonucu <= 100) Degisken.skor += (Degisken.soruBasinaPuan + 15);
                            else if (islemsonucu <= 200) Degisken.skor += (Degisken.soruBasinaPuan + 25);
                            break;
                        }
                    case "-":
                        {
                            Degisken.cikarmaDogru++;
                            if (islemsonucu == 0) Degisken.skor += (Degisken.soruBasinaPuan);
                            else if (islemsonucu <= 10) Degisken.skor += (Degisken.soruBasinaPuan + 15);
                            else if (islemsonucu <= 100) Degisken.skor += (Degisken.soruBasinaPuan + 25);
                            break;
                        }
                    case "x":
                        {
                            Degisken.carpmaDogru++;
                            if (sayi1 <= 10) Degisken.skor += (Degisken.soruBasinaPuan + 5);
                            else if (sayi1 <= 50) Degisken.skor += (Degisken.soruBasinaPuan + 30);
                            else if (sayi1 <= 100) Degisken.skor += (Degisken.soruBasinaPuan + 50);
                            break;
                        }
                    case "/":
                        {
                            Degisken.bolmeDogru++;
                            if (sayi1 * sayi2 <= 50) Degisken.skor += (Degisken.soruBasinaPuan + 5);
                            else if (sayi1 * sayi2 <= 100) Degisken.skor += (Degisken.soruBasinaPuan + 35);
                            else if (sayi1 * sayi2 <= 10000) Degisken.skor += (Degisken.soruBasinaPuan + 55);
                            break;
                        }
                }
                skorLbl.Text = Degisken.skor.ToString();
                yeniSoru();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sonucLbl.Text = "";
            Ses.sesCal("wrong.wav");
            switch (isaretLbl.Text)
            {
                case "+":
                    {
                        Degisken.toplamaYanlis++; break;
                    }
                case "-":
                    {
                        Degisken.cikarmaYanlis++; break;
                    }
                case "x":
                    {
                        Degisken.carpmaYanlis++; break;
                    }
                case "/":
                    {
                        Degisken.bolmeYanlis++; break;
                    }
            }

            yeniSoru();
            Degisken.skor -= (Degisken.soruBasinaPuan / 2) + 15;
            skorLbl.Text = Degisken.skor.ToString();
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



        private void SesKis_MouseEnter(object sender, EventArgs e)
        {
            Ses.Click_Play();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.geri2;
            Ses.Click_Play();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.geri1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            anaEkran form = new anaEkran();
            form.Show();
            islemListesi.Clear();
            this.Close();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace IslemOyunu
{
    public partial class SonEkran : Form
    {
        public SonEkran()
        {
            InitializeComponent();
        }

        public static string provider = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Data\\data.hs;Persist Security Info=False";
        OleDbConnection baglanti = new OleDbConnection(provider);

        public int EnYuksekSkor()
        {
            OleDbCommand YuksekSkor = new OleDbCommand("SELECT TOP 1 skor from Skorlar ORDER BY skor DESC", baglanti);
            try
            {
                baglanti.Close();
                baglanti.Open();
                OleDbDataReader oku = YuksekSkor.ExecuteReader();
                oku.Read();
                return Convert.ToInt32(oku.GetValue(0));


            }
            catch (Exception ex)
            {
                return -1;
                MessageBox.Show("İlk Yüksek Skor!");
            }
        }








        private void SonEkran_Load(object sender, EventArgs e)
        {

            zorlukLbl.Text = Degisken.zorluk.ToString();
            sureLbl.Text = Degisken.Secilensure.ToString();
            skorLbl.Text = Degisken.skor.ToString();

            toplamaDogru.Text = Degisken.toplamaDogru.ToString();
            cikarmaDogru.Text = Degisken.cikarmaDogru.ToString();
            carpmaDogru.Text = Degisken.carpmaDogru.ToString();
            bolmeDogru.Text = Degisken.bolmeDogru.ToString();

            toplamaYanlis.Text = Degisken.toplamaYanlis.ToString();
            cikarmaYanlis.Text = Degisken.cikarmaYanlis.ToString();
            carpmaYanlis.Text = Degisken.carpmaYanlis.ToString();
            bolmeYanlis.Text = Degisken.bolmeYanlis.ToString();

            if (Degisken.skor > EnYuksekSkor())
            {

                Ses.sesCal("rekor.wav");
                MessageBox.Show("Bravo! En Yüksek Skoru Geçtiniz!", "Yeni Rekor!", MessageBoxButtons.OK, MessageBoxIcon.None);
                enYuksekSkorLbl.Text = Degisken.skor.ToString();

            }
            else
            {
                enYuksekSkorLbl.Text = EnYuksekSkor().ToString();

            }

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.tekraroyna2;
            Ses.Click_Play();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.tekraroyna1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gecisEkrani form = new gecisEkrani();
            form.Show();
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.cikis2;
            Ses.Click_Play();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.cikis1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Skorlar([isim],[skor]) VALUES(@isim,@skor)", baglanti);
                cmd.Parameters.AddWithValue("@isim", isimTxt.Text);
                cmd.Parameters.AddWithValue("@skor", Degisken.skor);

                cmd.ExecuteNonQuery();
                isimTxt.Text = "Kaydedildi!";
                isimTxt.Enabled = false;
                button1.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.geri2;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.geri1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            anaEkran form = new anaEkran();
            form.Show();
            this.Close();
        }
    }
}

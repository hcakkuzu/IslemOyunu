using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.OleDb;
namespace IslemOyunu
{
    public partial class YuksekSkorlar : Form
    {
        public YuksekSkorlar()
        {
            InitializeComponent();
        }

        public static string provider = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Data\\data.hs;Persist Security Info=False";
        OleDbConnection baglanti = new OleDbConnection(provider);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YuksekSkorlar_Load(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "Select isim AS İsim,skor AS Skor FROM Skorlar ORDER BY skor DESC";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sorgu, baglanti);
                baglanti.Open();
                DataSet showing = new DataSet();
                adapter.Fill(showing, "Skorlar");
                dataGridView1.DataSource = showing.Tables["Skorlar"];
                adapter.Dispose();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına Bağlanılamadı!");
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = Interaction.InputBox("Güvenlik", "Lütfen Şifreyi Girin!", "", this.Height / 2, this.Width / 2);
            if (sifre != "islemoyunu.22") MessageBox.Show("Yanlış Şifre!");
            else
            {
                try
                {
                    baglanti.Close();
                    baglanti.Open();
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Skorlar([isim],[skor]) VALUES(@isim,@skor)", baglanti);
                    cmd.Parameters.AddWithValue("@isim", "İslemOyunu");
                    cmd.Parameters.AddWithValue("@skor", 0);
                    cmd.ExecuteNonQuery();

                    OleDbCommand cmd2 = new OleDbCommand("DELETE FROM Skorlar", baglanti);
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}

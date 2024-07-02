using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane
{
    public partial class adminkayit : Form
    {
        public adminkayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            this.Hide();
            git.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Insert into hesap (ad,soyad,tc,sifre) values (@a1,@a2,@a3,@a4)", baglanti);
            komut.Parameters.AddWithValue("@a1", txtad.Text);
            komut.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@a3", mskdtc.Text);
            komut.Parameters.AddWithValue("@a4", txtsifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
    }
}

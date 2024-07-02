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
    public partial class hastaekle : Form
    {
        public hastaekle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand kom = new NpgsqlCommand("insert into hasta (ad,soyad,tc,dogumyeri,dogumtarihi,medenidurum,adres,telno) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            kom.Parameters.AddWithValue("@p1", txtad.Text);
            kom.Parameters.AddWithValue("@p2", txtsoyad.Text);
            kom.Parameters.AddWithValue("@p3", mskdtc.Text);
            kom.Parameters.AddWithValue("@p4", txtdogumyeri.Text);
            kom.Parameters.AddWithValue("@p5", mskddogumtarih.Text);
            kom.Parameters.AddWithValue("@p6", cmbmedeni.Text);
            kom.Parameters.AddWithValue("@p7", txtadres.Text);
            kom.Parameters.AddWithValue("@p8", mskdtelno.Text);
            kom.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaekran gt = new anaekran();
            this.Hide();
            gt.Show();
        }

        private void hastaekle_Load(object sender, EventArgs e)
        {

        }
    }
}

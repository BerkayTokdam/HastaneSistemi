using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane
{
    public partial class receteyaz : Form
    {
        public receteyaz()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void receteyaz_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from muayene where tc like '" + maskedTextBox1.Text + "'", baglanti);
            NpgsqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                lblad.Text = rd[1].ToString();
                lblsoyad.Text = rd[2].ToString();
                lbltarih.Text = rd[3].ToString();
                lbltani.Text = rd[5].ToString();
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komuut = new NpgsqlCommand("insert into recete (tc,ad,soyad,tarih,dradsoyad,tani,ilac1ad,ilac1adet,ilac1tip,ilac1barkod,ilac2ad,ilac2adet,ilac2tip,ilac2barkod,ilac3ad,ilac3adet,ilac3tip,ilac3barkod,ilac4ad,ilac4adet,ilac4tip,ilac4barkod,ilac5ad,ilac5adet,ilac5tip,ilac5barkod) values (@b1,@b2,@b3,@b4,@b5,@b6,@b7,@b8,@b9,@b10,@b11,@b12,@b13,@b14,@b15,@b16,@b17,@b18,@b19,@b20,@b21,@b22,@b23,@b24,@b25,@b26)", baglanti);
            komuut.Parameters.AddWithValue("@b1", maskedTextBox1.Text);
            komuut.Parameters.AddWithValue("@b2", lblad.Text);
            komuut.Parameters.AddWithValue("@b3", lblsoyad.Text);
            komuut.Parameters.AddWithValue("@b4", lbltarih.Text);
            komuut.Parameters.AddWithValue("@b5", txtdoktoradsoyad.Text);
            komuut.Parameters.AddWithValue("@b6", lbltani.Text);
            komuut.Parameters.AddWithValue("@b7", txtilacad1.Text);
            komuut.Parameters.AddWithValue("@b8", cmbilacadet1.Text);
            komuut.Parameters.AddWithValue("@b9", cmbilactip1.Text);
            komuut.Parameters.AddWithValue("@b10", txtilacbarkod1.Text);
            komuut.Parameters.AddWithValue("@b11", txtilacad2.Text);
            komuut.Parameters.AddWithValue("@b12", cmbilacadet2.Text);
            komuut.Parameters.AddWithValue("@b13", cmbilactip2.Text);
            komuut.Parameters.AddWithValue("@b14", txtilacbarkod2.Text);
            komuut.Parameters.AddWithValue("@b15", txtilacad3.Text);
            komuut.Parameters.AddWithValue("@b16", cmbilacadet3.Text);
            komuut.Parameters.AddWithValue("@b17", cmbilactip3.Text);
            komuut.Parameters.AddWithValue("@b18", txtilacbarkod3.Text);
            komuut.Parameters.AddWithValue("@b19", txtilacad4.Text);
            komuut.Parameters.AddWithValue("@b20", cmbilacadet4.Text);
            komuut.Parameters.AddWithValue("@b21", cmbilactip4.Text);
            komuut.Parameters.AddWithValue("@b22", txtilacbarkod4.Text);
            komuut.Parameters.AddWithValue("@b23", txtilacad5.Text);
            komuut.Parameters.AddWithValue("@b24", cmbilacadet5.Text);
            komuut.Parameters.AddWithValue("@b25", cmbilactip5.Text);
            komuut.Parameters.AddWithValue("@b26", txtilacbarkod5.Text);
            komuut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into ilac (ilac1ad,ilac1adet,ilac1tip,ilac1barkod,ilac2ad,ilac2adet,ilac2tip,ilac2barkod,ilac3ad,ilac3adet,ilac3tip,ilac3barkod,ilac4ad,ilac4adet,ilac4tip,ilac4barkod,ilac5ad,ilac5adet,ilac5tip,ilac5barkod) values (@c1,@c2,@c3,@c4,@c5,@c6,@c7,@c8,@c9,@c10,@c11,@c12,@c13,@c14,@c15,@c16,@c17,@c18,@c19,@c20)", baglanti);
            komut.Parameters.AddWithValue("@c1", txtilacad1.Text);
            komut.Parameters.AddWithValue("@c2", cmbilacadet1.Text);
            komut.Parameters.AddWithValue("@c3", cmbilactip1.Text);
            komut.Parameters.AddWithValue("@c4", txtilacbarkod1.Text);
            komut.Parameters.AddWithValue("@c5", txtilacad2.Text);
            komut.Parameters.AddWithValue("@c6", cmbilacadet2.Text);
            komut.Parameters.AddWithValue("@c7", cmbilactip2.Text);
            komut.Parameters.AddWithValue("@c8", txtilacbarkod2.Text);
            komut.Parameters.AddWithValue("@c9", txtilacad3.Text);
            komut.Parameters.AddWithValue("@c10", cmbilacadet3.Text);
            komut.Parameters.AddWithValue("@c11", cmbilactip3.Text);
            komut.Parameters.AddWithValue("@c12", txtilacbarkod3.Text);
            komut.Parameters.AddWithValue("@c13", txtilacad4.Text);
            komut.Parameters.AddWithValue("@c14", cmbilacadet4.Text);
            komut.Parameters.AddWithValue("@c15", cmbilactip4.Text);
            komut.Parameters.AddWithValue("@c16", txtilacbarkod4.Text);
            komut.Parameters.AddWithValue("@c17", txtilacad5.Text);
            komut.Parameters.AddWithValue("@c18", cmbilacadet5.Text);
            komut.Parameters.AddWithValue("@c19", cmbilactip5.Text);
            komut.Parameters.AddWithValue("@c20", txtilacbarkod5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Reçeteye Kaydedilmiştir ve İlaçlar İlaç Tablosuna kaydolmuştur");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaekran gidermisin = new anaekran();
            this.Hide();
            gidermisin.Show();
        }
    }
}

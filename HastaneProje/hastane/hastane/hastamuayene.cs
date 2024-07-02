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
    public partial class hastamuayene : Form
    {
        public hastamuayene()
        {
            InitializeComponent();
        }
        public string hesap;
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void button3_Click(object sender, EventArgs e)
        {
            anaekran gtt = new anaekran();
            this.Hide();
            gtt.Show();
        }

        private void hastamuayene_Load(object sender, EventArgs e)
        {
            mskdtc.Text = hesap;
            baglanti.Open();
            NpgsqlCommand koom = new NpgsqlCommand("select * from hasta where tc=@p1", baglanti);
            koom.Parameters.AddWithValue("@p1", mskdtc.Text);
            NpgsqlDataReader dr = koom.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[0].ToString();
                txtsoyad.Text = dr[1].ToString();
            }
            baglanti.Close();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            hastamuayene hastamuayene = new hastamuayene();
            this.Hide();
            hastamuayene.hesap = mskdtc.Text;
            hastamuayene.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1000, 10000);
            mskdreceteno.Text = sayi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ko = new NpgsqlCommand("select * from muayene where \"tc\" like '" + mskdtc.Text + "' and \"muayenetarih\" like '" + mskdtarih.Text + "'", baglanti);
            NpgsqlDataReader drr = ko.ExecuteReader();
            while (drr.Read())
            {
                lbltc.Text = drr[0].ToString();
                lbltarih.Text = drr[3].ToString();
            }
            baglanti.Close();

            if (lbltc.Text == mskdtc.Text && lbltarih.Text == mskdtarih.Text)
            {
                MessageBox.Show("Bir günde Bir kere muayene olabilirsiniz");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand kom = new NpgsqlCommand("insert into muayene (tc,ad,soyad,muayenetarih,hastasikayet,tani,onerilentedavi,receteno) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                kom.Parameters.AddWithValue("@p1", mskdtc.Text);
                kom.Parameters.AddWithValue("@p2", txtad.Text);
                kom.Parameters.AddWithValue("@p3", txtsoyad.Text);
                kom.Parameters.AddWithValue("@p4", mskdtarih.Text);
                kom.Parameters.AddWithValue("@p5", rtbhastasikayet.Text);
                kom.Parameters.AddWithValue("@p6", rtbtani.Text);
                kom.Parameters.AddWithValue("@p7", rtbonerilentedavi.Text);
                kom.Parameters.AddWithValue("@p8", mskdreceteno.Text);
                kom.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sisteme Kaydedildi");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ko = new NpgsqlCommand("select * from muayene where \"tc\" like '" + mskdtc.Text + "' and \"muayenetarih\" like '"+mskdtarih.Text+"'", baglanti);
            NpgsqlDataReader dr = ko.ExecuteReader();
            while (dr.Read())
            {
                lbltc.Text = dr[0].ToString();
                lbltarih.Text = dr[3].ToString();
            }
            baglanti.Close();
            if (lbltc.Text == mskdtc.Text && lbltarih.Text == mskdtarih.Text)
            {
                MessageBox.Show("Bir günde Bir kere muayene olabilirsiniz");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand kom = new NpgsqlCommand("insert into muayene (tc,ad,soyad,muayenetarih,hastasikayet,tani,onerilentedavi,receteno) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                kom.Parameters.AddWithValue("@p1", mskdtc.Text);
                kom.Parameters.AddWithValue("@p2", txtad.Text);
                kom.Parameters.AddWithValue("@p3", txtsoyad.Text);
                kom.Parameters.AddWithValue("@p4", mskdtarih.Text);
                kom.Parameters.AddWithValue("@p5", rtbhastasikayet.Text);
                kom.Parameters.AddWithValue("@p6", rtbtani.Text);
                kom.Parameters.AddWithValue("@p7", rtbonerilentedavi.Text);
                kom.Parameters.AddWithValue("@p8", mskdreceteno.Text);
                kom.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sisteme Kaydedildi");
            }

            receteyaz giit = new receteyaz();
            this.Hide();
            giit.Show();

        }
    }
}

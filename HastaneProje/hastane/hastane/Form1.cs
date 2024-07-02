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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void button2_Click(object sender, EventArgs e)
        {
            adminkayit git = new adminkayit();
            this.Hide();
            git.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from hesap where tc=@p1 and sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mskdtc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                anaekran anamenuu = new anaekran();
                this.Hide();
                anamenuu.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girişi");
            }
            baglanti.Close();
        }
    }
}

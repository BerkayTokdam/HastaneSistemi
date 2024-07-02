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
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void button1_Click(object sender, EventArgs e)
        {
            hastaekle git = new hastaekle();
            this.Hide();
            git.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hastamuayene giit = new hastamuayene();
            this.Hide();
            giit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hasta";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele gittt = new listele();
            this.Hide();
            gittt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            recetelist gid = new recetelist();
            this.Hide();
            gid.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ilaclist giderrr = new ilaclist();
            this.Hide();
            giderrr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ilacagorehastalist sdsd = new ilacagorehastalist();
            this.Hide();
            sdsd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class ilacagorehastalist : Form
    {
        public ilacagorehastalist()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter dailachasta = new NpgsqlDataAdapter("select tc,ad,soyad from recete where \"ilac1barkod\" like   '" + txtilacbarkod.Text + "' or " + " \"ilac2barkod\" like   '" + txtilacbarkod.Text + "' or " + " \"ilac3barkod\" like   '" + txtilacbarkod.Text + "' or " + " \"ilac4barkod\" like   '" + txtilacbarkod.Text + "' or " + " \"ilac5barkod\" like   '" + txtilacbarkod.Text + "' ", baglanti); 
            DataSet dsilachasta = new DataSet(); 
            dailachasta.Fill(dsilachasta); 
            dataGridView1.DataSource = dsilachasta.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaekran gidsds = new anaekran();
            this.Hide();
            gidsds.Show();
        }
    }
}

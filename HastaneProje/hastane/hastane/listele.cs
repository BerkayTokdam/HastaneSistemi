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
    public partial class listele : Form
    {
        public listele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void listele_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from muayene";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datamuayene.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaekran git = new anaekran();
            this.Hide();
            git.Show();
        }
    }
}

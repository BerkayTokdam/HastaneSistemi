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
    public partial class recetelist : Form
    {
        public recetelist()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from recete order by tarih";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datarecetelist.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaekran giit = new anaekran();
            this.Hide();
            giit.Show();
        }
    }
}

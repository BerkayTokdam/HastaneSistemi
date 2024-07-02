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
    public partial class ilaclist : Form
    {
        public ilaclist()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbhastane; user ID=postgres; password=12345");

        private void button1_Click(object sender, EventArgs e)
        {
            
            NpgsqlDataAdapter dailac = new NpgsqlDataAdapter("select ilac1ad,ilac2ad,ilac3ad,ilac4ad,ilac5ad from recete where \"tc\" like '" + mskdtc.Text + "'", baglanti);
            DataSet dsilac = new DataSet();
            dailac.Fill(dsilac);
            datailaclist.DataSource = dsilac.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anaekran gidsd = new anaekran();
            this.Hide();
            gidsd.Show();
        }
    }
    }


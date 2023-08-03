using Dapper;
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

namespace Kitaplık
{
    public partial class KitapUpdate : Form
    {
        public KitapUpdate()
        {
            InitializeComponent();
        }
        private string ConnectionString = "Data Source=DESKTOP-458LKBF;Initial Catalog=Kitaplık;Integrated Security=True";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void guncelle(string ad, string yazar, int fiyat)
        {
            using (var baglanti = new SqlConnection(ConnectionString))
            {
                baglanti.Execute("update Kitap set KitapAd=@ad,KitapYazar=@yazar,KitapFiyat=@fiyat", new { ad, yazar, fiyat });
            }
        }

        public void dataTableRefresh()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Kitap", conn))
                {
                    DataTable dt = new DataTable();
                    ad.Fill(dt);

                    KitapDuzenle ac = new KitapDuzenle();
                    ac.dataGridView1.DataSource = dt;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt16(txtFiyatı.Text);
            guncelle(txtAd.Text, txtYazar.Text, fiyat);
            dataTableRefresh();
            MessageBox.Show("Kitap kayıt edildi");
            txtAd.Clear();
            txtYazar.Clear();
            txtFiyatı.Clear();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

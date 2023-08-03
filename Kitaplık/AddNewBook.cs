using Dapper;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kitaplık
{
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }
        private string ConnectionString = "Data Source=DESKTOP-458LKBF;Initial Catalog=Kitaplık;Integrated Security=True";

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {


        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        public void ekle(string ad, string yazar, int fiyat)
        {
            using (var baglanti = new SqlConnection(ConnectionString))
            {
              baglanti.Execute("insert into Kitap values(@ad,@yazar,@fiyat)", new { ad, yazar, fiyat });
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt16(txtFiyat.Text);
            ekle(txtAd.Text, txtYazar.Text, fiyat);
            MessageBox.Show("Kitap kayıt edildi");
            txtAd.Clear();
            txtYazar.Clear();
            txtFiyat.Clear();



        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

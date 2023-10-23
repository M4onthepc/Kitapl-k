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
    public partial class KitapDuzenle : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        public KitapDuzenle()
        {
            InitializeComponent();
        }

        private void KitapDuzenle_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void temizle()
        {
            txtAd.Clear();
            txtYazar.Clear();
            txtFiyat.Clear();
            txtId.Clear();
        }
        void yenile()
        {
            con = new SqlConnection("Data Source=DESKTOP-458LKBF;Initial Catalog=Kitaplık;Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM Kitap", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kitap");
            dataGridView1.DataSource = ds.Tables["Kitap"];
            con.Close();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            komut= new SqlCommand();
            con.Open();
            komut.Connection= con;
            komut.CommandText ="insert into Kitap (KitapAd,KitapYazar,KitapFiyat) values ('"+txtAd.Text+"','"+txtYazar.Text+"','"+txtFiyat.Text+"') ";
            komut.ExecuteNonQuery();
            con.Close();
            yenile();
            temizle();

        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand();
            con.Open();
            komut.Connection = con;
            komut.CommandText = "update Kitap set KitapAd='"+txtAd.Text+"',KitapYazar='"+txtYazar.Text+"',KitapFiyat='"+txtFiyat.Text+"'where id="+txtId.Text+" ";
            komut.ExecuteNonQuery();
            con.Close();
            yenile();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            komut = new SqlCommand();
            con.Open();
            komut.Connection = con;
            komut.CommandText = "delete from Kitap where id = '"+txtId.Text+"' ";
            komut.ExecuteNonQuery();
            con.Close();
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells["id"].Value);
                KayitSil(id);
            }
            yenile();
            temizle();
        }

        void KayitSil(int id)
        {
            komut = new SqlCommand("delete from Kitap where id=@id", con);
            komut.Parameters.AddWithValue("@id", id);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kitaplık
{
    public partial class BuyNewBook : Form
    {
        private string ConnectionString = "Data Source=DESKTOP-458LKBF;Initial Catalog=Kitaplık;Integrated Security=True";

        public BuyNewBook()
        {
            InitializeComponent();
        }

        private void BuyNewBook_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Kitap", conn))
                {
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 3)
            {
                MessageBox.Show("Kitap Satın Alındı.");

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kitaplık
{
    public partial class Kitaplar : Form
    {
        private string ConnectionString = "Data Source=DESKTOP-458LKBF;Initial Catalog=Kitaplık;Integrated Security=True";

        public void kitapListe()
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
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            kitapListe();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

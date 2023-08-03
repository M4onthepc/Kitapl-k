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
    public partial class kitapGoster : Form
    {
        void baglantiAc()
        {
            SqlConnection  con = new SqlConnection("Data Source=DESKTOP-458LKBF;Initial Catalog=Kitaplık;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select*from Kitap", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Kitap");
            dataGridView1.DataSource = ds.Tables["Kitap"];
            con.Close();
        }
        public kitapGoster()
        {
            InitializeComponent();
        }

        private void kitapGoster_Load(object sender, EventArgs e)
        {
            baglantiAc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

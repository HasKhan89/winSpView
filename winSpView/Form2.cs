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

namespace winSpView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string ConnectionString = "Server=BURAK; Database=OkulSistemiDB; user id=sa; Password=wissen;";

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand("procSeviyeyeGorePersonelAdet", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@max_kontenjan", nudMaxKontenjan.Value);

            //Store procedure geriye değer döndürmüyorsa kullanabilirsiniz.
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}

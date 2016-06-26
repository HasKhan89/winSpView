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

namespace winSpView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ConnectionString = "Server=BURAK; Database=OkulSistemiDB; user id=sa; Password=wissen;";
        private bool isDataLoaded = false;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(comboBox1.Text))
            //{
            //    return;
            //}

            if(isDataLoaded == false)
            {
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                return;
            }

            SqlConnection connection = new SqlConnection(ConnectionString);

            //DataRowView dr = (DataRowView)comboBox1.SelectedValue;
            //DataRow row = dr.Row;

            //string query = "SELECT * FROM " + row["RaporViewAdi"].ToString();
            string query = "SELECT * FROM " + comboBox1.SelectedValue.ToString();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adaptor = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adaptor.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboboxData();
        }

        private void LoadComboboxData()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "SELECT * FROM tblRaporlar";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adaptor = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adaptor.Fill(dt);

            comboBox1.DisplayMember = "RaporAdi";
            comboBox1.ValueMember = "RaporViewAdi";
            comboBox1.DataSource = dt;

            isDataLoaded = true;
        }

        private void btnViewEkle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = "INSERT INTO tblRaporlar(RaporAdi,RaporViewAdi,RaporAciklama) VALUES(@RaporAdi, @RaporViewAdi, @RaporAciklama)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RaporAdi", txtViewClearName.Text);
            command.Parameters.AddWithValue("@RaporViewAdi", txtViewName.Text);
            command.Parameters.AddWithValue("@RaporAciklama", txtViewDescription.Text);

            try
            {
                connection.Open();

                // ExecuteNonQuery bize etkilenen kayıt(satır) sayısını döner.
                int result = command.ExecuteNonQuery();

                connection.Close();

                // Eğer insert işlemi oldu ise.. result=1 dönmeli.
                if (result > 0)
                {
                    isDataLoaded = false;
                    LoadComboboxData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if(System.IO.Directory.Exists(Application.StartupPath + "//logs") == false)
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "//logs");
                }

                // 28.03.2016 09:52:65:555 --> 20160328_095265
                string dosyaAdi = "log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                string dosyaYolu = Application.StartupPath + "//logs//" + dosyaAdi;

                System.IO.File.WriteAllText(dosyaYolu,
                    DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine +
                    ex.Message + Environment.NewLine + Environment.NewLine +
                    ex.StackTrace);
            }
            finally
            {
                if(connection.State != ConnectionState.Closed || connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }
        }

        private void btnEmailGonder_Click(object sender, EventArgs e)
        {

        }
    }
}

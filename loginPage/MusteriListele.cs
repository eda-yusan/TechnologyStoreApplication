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

namespace TeknolojiMagazasi
{

    public partial class MusteriListele : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public MusteriListele()
        {
            InitializeComponent();
        }
        void MusteriGetir()
        {
            con = new SqlConnection("server=DESKTOP-7FBUO4Q\\SQLEXPRESS; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT MusteriTC,MusteriAd,MusteriSoyad FROM tbl_Musteri ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView11.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isimSoyad = txtArama.Text.Trim();

            using (SqlConnection con = new SqlConnection("server=DESKTOP-7FBUO4Q\\SQLEXPRESS; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
            {
                using (SqlCommand cmd = new SqlCommand("MusteriArama", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreyi ekleyin
                    cmd.Parameters.AddWithValue("@isimSoyad", isimSoyad);

                    // DataTable oluşturun ve SqlDataAdapter kullanarak verileri doldurun
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    // DataGridView'a DataTable'ı bağlayın
                    dataGridView11.DataSource = dt;
                }
            }
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MusteriListele_Load_1(object sender, EventArgs e)
        {
            MusteriGetir();
        }
    }
}

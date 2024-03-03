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
    public partial class SatisListele : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public SatisListele()
        {
            InitializeComponent();
        }

        void SatisGetir()
        {
            con = new SqlConnection("server=DESKTOP-7FBUO4Q\\SQLEXPRESS; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT SatisID,MusteriTC,MusteriIsim FROM tbl_Satis", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSatis.DataSource = dt;
            con.Close();
        }
       
        private void SatisListele_Load_1(object sender, EventArgs e)
        {
            SatisGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UrunAd = txtMusteriIsim.Text.Trim();

            using (SqlConnection con = new SqlConnection("server=DESKTOP-7FBUO4Q\\SQLEXPRESS; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
            {
                using (SqlCommand cmd = new SqlCommand("sp_SatisArama", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreyi ekleyin
                    cmd.Parameters.AddWithValue("@MusteriIsim", UrunAd);

                    // DataTable oluşturun ve SqlDataAdapter kullanarak verileri doldurun
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    // DataGridView'a DataTable'ı bağlayın
                    dataGridViewSatis.DataSource = dt;
                }
            }
        }
    }
}

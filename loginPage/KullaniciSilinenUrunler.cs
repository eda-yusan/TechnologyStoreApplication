using loginPage;
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
    public partial class SilinenUrulerKullanici : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public SilinenUrulerKullanici()
        {
            InitializeComponent();
        }
        void SilinenUrunGetir()
        {
            con = new SqlConnection("server=DESKTOP-7FBUO4Q\\SQLEXPRESS; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_SilinenUrunKayitlari", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView7.DataSource = dt;
            con.Close();
        }

        private void btnGeri2_Click(object sender, EventArgs e)
        {
            new UrunlerKullanici().Show();
            this.Close();
        }

        private void btnCikisYap2_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Close();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SilinenUrulerKullanici_Load_1(object sender, EventArgs e)
        {
            SilinenUrunGetir();
        }
    }
}

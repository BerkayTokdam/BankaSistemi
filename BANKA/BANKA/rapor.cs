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

namespace BANKA
{
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-SK49LK3L;Initial Catalog=dbbanka;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            anamenu anamenugit = new anamenu();
            this.Hide();
            anamenugit.Show();
        }
        DataTable DataHavale()
        {
            string data = "select *from tblhavale where HesapNo like '" + mskdhesapno.Text + "' and (Tarih between @a1 and @a2)";
            DataTable tabloo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(data, baglanti);
            adapter.SelectCommand.Parameters.Add("@a1", SqlDbType.Date).Value = date1.Value;
            adapter.SelectCommand.Parameters.Add("@a2", SqlDbType.Date).Value = date2.Value;
            adapter.Fill(tabloo);
            datagridhavale.DataSource = tabloo;
            return tabloo;
        }
        DataTable DataCek()
        {
            string data = "select *from tblcek where HesapNo like '" + mskdhesapno.Text + "' and (Tarih between @a1 and @a2)";
            DataTable tabloo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(data, baglanti);
            adapter.SelectCommand.Parameters.Add("@a1", SqlDbType.Date).Value = date1.Value;
            adapter.SelectCommand.Parameters.Add("@a2", SqlDbType.Date).Value = date2.Value;
            adapter.Fill(tabloo);
            datagridcek.DataSource = tabloo;
            return tabloo;
        }
        DataTable DataYatir()
        {
            string data = "select *from tblyatir where HesapNo like '" + mskdhesapno.Text + "' and (Tarih between @a1 and @a2)";
            DataTable tabloo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(data, baglanti);
            adapter.SelectCommand.Parameters.Add("@a1", SqlDbType.Date).Value = date1.Value;
            adapter.SelectCommand.Parameters.Add("@a2", SqlDbType.Date).Value = date2.Value;
            adapter.Fill(tabloo);
            datagridyatir.DataSource = tabloo;
            return tabloo;
        }
        private void rapor_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(CekilenMiktar) from tblcek ", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                lblgider.Text = rd[0].ToString();
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(YatirilanMiktar) from tblyatir ", baglanti);
            SqlDataReader rd2 = komut.ExecuteReader();
            while (rd2.Read())
            {
                lblgelir.Text = rd2[0].ToString();
            }
            baglanti.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataHavale();
            DataCek();
            DataYatir();

        }
    }
}

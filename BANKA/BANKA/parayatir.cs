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
    public partial class parayatir : Form
    {
        public parayatir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-SK49LK3L;Initial Catalog=dbbanka;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            anamenu anammenugit = new anamenu();
            this.Hide();
            anammenugit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc;
            sonuc = Convert.ToInt32(mskdbakiye.Text) + Convert.ToInt32(mskdyatirilanmiktar.Text);
            mskdbakiye.Text = sonuc.ToString();

            baglanti.Open();
            SqlCommand komutyatir = new SqlCommand("update tblmusteri set Bakiye=@a1 where HesapNo=@a2", baglanti);
            komutyatir.Parameters.AddWithValue("@a1", mskdbakiye.Text);
            komutyatir.Parameters.AddWithValue("@a2", mskdhesapno.Text);
            komutyatir.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutgecmisyatir = new SqlCommand("insert into tblyatir (HesapNo,Bakiye,YatirilanMiktar,Tarih) values(@p1,@p2,@p3,@p4)", baglanti);
            komutgecmisyatir.Parameters.AddWithValue("@p1", mskdhesapno.Text);
            komutgecmisyatir.Parameters.AddWithValue("@p2", mskdbakiye.Text);
            komutgecmisyatir.Parameters.AddWithValue("@p3", mskdyatirilanmiktar.Text);
            komutgecmisyatir.Parameters.AddWithValue("@p4", datetarih.Value);
            komutgecmisyatir.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Para Yatırma İşlemi Başarıyla Gerçekleştirilmiştir");
        }

        private void mskdhesapno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblmusteri where HesapNo like '" + mskdhesapno.Text + "'", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                mskdbakiye.Text = rd[4].ToString();
            }
            baglanti.Close();
        }

        private void parayatir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbbankaDataSet6.tblmusteri' table. You can move, or remove it, as needed.
            this.tblmusteriTableAdapter.Fill(this.dbbankaDataSet6.tblmusteri);

        }
    }
}

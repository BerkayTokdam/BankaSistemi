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
    public partial class havale : Form
    {
        public havale()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-SK49LK3L;Initial Catalog=dbbanka;Integrated Security=True");
             
        private void button2_Click(object sender, EventArgs e)
        {
            anamenu anamenugit = new anamenu();
            this.Hide();
            anamenugit.Show();
        }
        private void mskdhesapno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblmusteri where HesapNo like '" + mskdhesapno.Text + "'", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                mskdbakiye.Text = rd[4].ToString();
                cmbmusteritip.Text = rd[6].ToString();
            }
            baglanti.Close();
        }
        

        private void havale_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from tblbankahesabi ", baglanti);
            SqlDataReader rd2 = komut2.ExecuteReader();
            while (rd2.Read())
            {
                txtbankahesabi.Text = rd2[0].ToString();
            }
            baglanti.Close();
        }

        private void mskdalicihesapno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from tblmusteri where HesapNo like '" + mskdalicihesapno.Text + "'", baglanti);
            SqlDataReader rd3 = komut3.ExecuteReader();
            while (rd3.Read())
            {
                txtalicibakiye.Text = rd3[4].ToString();
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int gonderenhesap, alicihesap, gonderilenmiktar, BankaHesap;
            gonderilenmiktar = Convert.ToInt32(mskdgonderilenmiktar.Text);
            alicihesap = Convert.ToInt32(txtalicibakiye.Text) + Convert.ToInt32(mskdgonderilenmiktar.Text);
            
            //if (cmbmusteritip.Text=="BIREYSEL")
            //{
                gonderenhesap = Convert.ToInt32(mskdbakiye.Text) - Convert.ToInt32(mskdgonderilenmiktar.Text) - ((gonderilenmiktar * 2) / 100);
                mskdbakiye.Text = gonderenhesap.ToString();
                txtyuzde.Text = ((gonderilenmiktar * 2) / 100).ToString();
            //}
            //else if (cmbmusteritip.Text=="KURUMSAL")
            //{
            //    gonderenhesap = Convert.ToInt32(mskdbakiye.Text) - Convert.ToInt32(mskdgonderilenmiktar.Text);
            //    mskdbakiye.Text = gonderenhesap.ToString();
            //}
            txtalicibakiye.Text = alicihesap.ToString();
            BankaHesap = Convert.ToInt32(txtbankahesabi.Text) + Convert.ToInt32(txtyuzde.Text);
            txtbankahesabi.Text = BankaHesap.ToString();

            baglanti.Open();
            SqlCommand komutbankahesap = new SqlCommand("update tblbankahesabi set BankaHesabi=@b1", baglanti);
            komutbankahesap.Parameters.AddWithValue("@b1", txtbankahesabi.Text);
            komutbankahesap.ExecuteNonQuery();
            baglanti.Close();


            baglanti.Open();
            SqlCommand alicikomut = new SqlCommand("update tblmusteri set Bakiye=@p1 where HesapNo=@p2", baglanti);
            alicikomut.Parameters.AddWithValue("@p1", txtalicibakiye.Text);
            alicikomut.Parameters.AddWithValue("@p2", mskdalicihesapno.Text);
            alicikomut.ExecuteNonQuery();
            baglanti.Close();


            baglanti.Open();
            SqlCommand gonderenkomut = new SqlCommand("update tblmusteri set Bakiye=@p1 where HesapNo=@p2", baglanti);
            gonderenkomut.Parameters.AddWithValue("@p1", mskdbakiye.Text);
            gonderenkomut.Parameters.AddWithValue("@p2", mskdhesapno.Text);
            gonderenkomut.ExecuteNonQuery();
            baglanti.Close();


            baglanti.Open();
            SqlCommand havalekom = new SqlCommand("insert into tblhavale(HesapNo,Miktar,AliciHesapNo,Tarih) values(@c1,@c2,@c3,@c4)", baglanti);
            havalekom.Parameters.AddWithValue("@c1", mskdhesapno.Text);
            havalekom.Parameters.AddWithValue("@c2", mskdgonderilenmiktar.Text);
            havalekom.Parameters.AddWithValue("@c3", mskdalicihesapno.Text);
            havalekom.Parameters.AddWithValue("@c4", datetarih.Value);
            havalekom.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Başarıyla Havale Gerçekleşti.Hesap İşletim Ücreti Kesilmemiştir ");
        }

        
    }
}

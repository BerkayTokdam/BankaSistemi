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
    public partial class paracek : Form
    {
        public paracek()
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

        private void button2_Click(object sender, EventArgs e)
        {
            int cekilenmiktar = Convert.ToInt32(mskdcekilenmiktar.Text);
            int bakiyee = Convert.ToInt32(mskdbakiye.Text);

            if (cekilenmiktar > 750)
            {
                MessageBox.Show("Max 750 Tl Çekebilirsiniz!!!");
            }
            else if (cekilenmiktar > bakiyee)
            {
                MessageBox.Show("Bakiyeniz Yetersiz!!!");
            }
            else
            {
                int sonuc;
                sonuc = bakiyee - cekilenmiktar;
                mskdbakiye.Text = sonuc.ToString();

               baglanti.Open();
                SqlCommand komutcekme = new SqlCommand("update tblmusteri set Bakiye=@a1 where HesapNo=@a2", baglanti);
                komutcekme.Parameters.AddWithValue("@a1", mskdbakiye.Text);
                komutcekme.Parameters.AddWithValue("@a2", mskdhesapno.Text);
                komutcekme.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komutgecmis = new SqlCommand("insert into tblcek(HesapNo,Bakiye,CekilenMiktar,Tarih) values(@p1,@p2,@p3,@p4)", baglanti);
                komutgecmis.Parameters.AddWithValue("@p1", mskdhesapno.Text);
                komutgecmis.Parameters.AddWithValue("@p2", mskdbakiye.Text);
                komutgecmis.Parameters.AddWithValue("@p3", mskdcekilenmiktar.Text);
                komutgecmis.Parameters.AddWithValue("@p4", datetarih.Value);
                komutgecmis.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Para Çekme İşlemi Başarıyla Gerçekleştirilmiştir");
            }

        }

        private void paracek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbbankaDataSet5.tblmusteri' table. You can move, or remove it, as needed.
            this.tblmusteriTableAdapter.Fill(this.dbbankaDataSet5.tblmusteri);

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
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
    }
}

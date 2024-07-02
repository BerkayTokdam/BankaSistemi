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

namespace BANKA
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-SK49LK3L;Initial Catalog=dbbanka;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblhesap where KULLANICIADI=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                anamenu anamenuu = new anamenu();
                this.Hide();
                anamenuu.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girişi");
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitol kayitolgit = new kayitol();
            this.Hide();
            kayitolgit.Show();
        }
    }
}

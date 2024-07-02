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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            giris girisgit = new giris();
            this.Hide();
            girisgit.Show();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-SK49LK3L;Initial Catalog=dbbanka;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblhesap (AD,SOYAD,KULLANICIADI,SIFRE) values(@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sisteme Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class musteriekle : Form
    {
        public musteriekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-SK49LK3L;Initial Catalog=dbbanka;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            anamenu anamenugittt = new anamenu();
            this.Hide();
            anamenugittt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblmusteri (HesapNo,Ad,Soyad,Bakiye,Sifre,MusteriTip) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p5", textBox3.Text);
            komut.Parameters.AddWithValue("p6", comboBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000,1000000);
            maskedTextBox1.Text = sayi.ToString();
        }
    }
}

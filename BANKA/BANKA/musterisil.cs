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
using System.ComponentModel.Design;

namespace BANKA
{
    public partial class musterisil : Form
    {
        public musterisil()
        {
            InitializeComponent();
        }
        public string hesap;
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-SK49LK3L;Initial Catalog=dbbanka;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            anamenu anamenugit = new anamenu();
            this.Hide();
            anamenugit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(maskedTextBox2.Text);
            if (sonuc != 0)
            {
                MessageBox.Show("Müşteri Bakiyesi 0 TL Olmalıdır.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
            baglanti.Open();
            SqlCommand komuut = new SqlCommand("delete from tblmusteri where HesapNo=@p1", baglanti);
            komuut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komuut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Silme Başarılı");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void musterisil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbbankaDataSet4.tblmusteri' table. You can move, or remove it, as needed.
            this.tblmusteriTableAdapter.Fill(this.dbbankaDataSet4.tblmusteri);
            maskedTextBox1.Text = hesap;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblmusteri where HesapNo=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[2].ToString();
                textBox2.Text = dr[3].ToString();
                maskedTextBox2.Text = dr[4].ToString();
                textBox3.Text = dr[5].ToString();
                comboBox1.Text = dr[6].ToString();
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musterisil musterisil = new musterisil();
            this.Hide();
            musterisil.hesap = maskedTextBox1.Text;
            musterisil.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

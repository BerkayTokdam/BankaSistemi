using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKA
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris girisgit = new giris();
            this.Hide();
            girisgit.Show();
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paracek paracekgit = new paracek();
            this.Hide();
            paracekgit.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parayatir parayatirgit = new parayatir();
            this.Hide();
            parayatirgit.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            havale havalegit = new havale();
            this.Hide();
            havalegit.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musterisil musterisil = new musterisil();
            this.Hide();
            musterisil.Show();
        }

        private void müşteriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapor raporgit = new rapor();
            this.Hide();
            raporgit.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void müşteriEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            musteriekle musterieklee = new musteriekle();
            this.Hide();
            musterieklee.Show();
        }

        private void anamenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbbankaDataSet3.tblmusteri' table. You can move, or remove it, as needed.
            this.tblmusteriTableAdapter.Fill(this.dbbankaDataSet3.tblmusteri);

        }
    }
}

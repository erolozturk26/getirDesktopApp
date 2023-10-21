using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alışveriş_Uygulaması
{
    public partial class SecimEkrani : Form
    {
        public SecimEkrani()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UrunEkle urunekle = new UrunEkle();
            urunekle.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            KuryeEkle kuryeEkle = new KuryeEkle();
            kuryeEkle.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KategoriEkleme kategoriekle = new KategoriEkleme();
            kategoriekle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            var result = MessageBox.Show("Oturumu kapatmak üzeresiniz\nDevam etmek istiyor musunuz ?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                f1.Show();
                this.Hide();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MusteriEkleme musteriEkleme = new MusteriEkleme();
            musteriEkleme.Show();
            this.Hide();
        }
    }
}

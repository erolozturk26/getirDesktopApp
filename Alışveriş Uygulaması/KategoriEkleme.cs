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
    public partial class KategoriEkleme : Form
    {
        public KategoriEkleme()
        {
            InitializeComponent();
        }
        Model1Container1 baglanti = new Model1Container1();

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            if (txtKategoriID.Text == "")
            {
                if (txtKategoriAdi.Text != "" && txtKategoriTanim.Text != "")
                {
                    kategori.Kategori_Adi = txtKategoriAdi.Text;
                    kategori.Kategori_Tanim = txtKategoriTanim.Text;
                    baglanti.Kategori.Add(kategori);
                    baglanti.SaveChanges();
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Ürün Adı veya Tanımı boş bırakılamaz...");
                }
            }
            else
            {
                MessageBox.Show("Ürün mevcuttur.Lütfen 'Güncelleme' tuşuna basınız...");
            }
        }

        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Kategori.ToList();
            dataGridView1.ClearSelection();
        }
        public void Temizle()
        {
            txtKategoriTanim.Clear();
            //txtKategoriIDSilme.Clear();
            txtKategoriID.Clear();
            txtKategoriAdi.Clear();
            //txtKategoriIDSilme.Text = "KATEGORİ ID";
        }

        private void KategoriEkleme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            if (txtKategoriID.Text != "")
            {
                int id = Convert.ToInt32(txtKategoriID.Text);
                var x = baglanti.Kategori.Find(id);
                x.Kategori_Adi = txtKategoriAdi.Text;
                x.Kategori_Tanim = txtKategoriTanim.Text;
                baglanti.SaveChanges();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz alanı seçiniz.");
            }            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secim = dataGridView1.CurrentRow;
            txtKategoriID.Text = secim.Cells["KategoriID"].Value.ToString();
            //txtKategoriIDSilme.Text = secim.Cells["KategoriID"].Value.ToString();
            txtKategoriAdi.Text = secim.Cells["Kategori_Adi"].Value.ToString();
            txtKategoriTanim.Text = secim.Cells["Kategori_Tanim"].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        //private void txtKategoriIDSilme_Enter(object sender, EventArgs e)
        //{
        //    if (txtKategoriIDSilme.Text != "")
        //    {
        //        txtKategoriIDSilme.ForeColor = Color.Black;
        //        txtKategoriIDSilme.Text = "";
        //    }
        //}

        //private void txtKategoriIDSilme_Leave(object sender, EventArgs e)
        //{
        //    if (txtKategoriIDSilme.Text == "")
        //    {
        //        txtKategoriIDSilme.ForeColor = Color.DarkGray;
        //        txtKategoriIDSilme.Text = "KATEGORİ ID";
        //    }
        //}

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            SecimEkrani secimekrani = new SecimEkrani();
            secimekrani.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSil_Click(object sender, EventArgs e) // Silme İşlemi
        {
            if (txtKategoriID.Text != "")
            {
                int id = Convert.ToInt32(txtKategoriID.Text);
                var x = baglanti.Kategori.Find(id);
                baglanti.Kategori.Remove(x);
                baglanti.SaveChanges();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kategoriyi seçiniz.");
            }
        }
    }
}

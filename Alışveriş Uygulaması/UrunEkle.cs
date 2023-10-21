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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        Model1Container1 baglanti = new Model1Container1();

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Urunler.ToList();
            dataGridView1.ClearSelection();
            comboBox1.DataSource = baglanti.Kategori.ToList();
            comboBox1.ValueMember = "KategoriID";
            comboBox1.DisplayMember = "Kategori_Adi";
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            if (txtUrunID.Text == "")
            {
                if (txtUrunAdi.Text != "" && txtUrunStok.Text != "" && txtUrunFiyat.Text != "")
                {
                    urun.Urun_Adi = txtUrunAdi.Text;
                    urun.Urun_StokDuzeyi = Convert.ToInt32(txtUrunStok.Text);
                    urun.KategoriID = Convert.ToInt32(comboBox1.SelectedValue);
                    urun.UrunAciklama = txtUrunAciklamasi.Text;
                    urun.Urun_Fiyati = Convert.ToInt32(txtUrunFiyat.Text);
                    urun.Urun_image = txtUrunFoto.Text;
                    baglanti.Urunler.Add(urun);
                    baglanti.SaveChanges();
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Ürün Adı,Stok,Fiyat bilgileri boş bırakılamaz.");
                }
            }
            else
            {
                MessageBox.Show("Ürün mevcuttur.Değişiklik yapmak için 'Güncelle' butonunu kullanınız...");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HizliKategoriEkle hizliKategoriEkle = new HizliKategoriEkle();
            hizliKategoriEkle.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtUrunID.Text = satir.Cells["UrunID"].Value.ToString();
            txtUrunAdi.Text = satir.Cells["Urun_Adi"].Value.ToString();
            txtUrunStok.Text = satir.Cells["Urun_StokDuzeyi"].Value.ToString();
            txtUrunAciklamasi.Text = satir.Cells["UrunAciklama"].Value.ToString();
            txtUrunFiyat.Text = satir.Cells["Urun_Fiyati"].Value.ToString();
            string combosayi = satir.Cells["KategoriID"].Value.ToString();
            comboBox1.SelectedValue = Convert.ToInt32(combosayi);
            txtUrunFoto.Text = satir.Cells["Urun_image"].Value.ToString();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            if (txtUrunID.Text != "")
            {
                int id = Convert.ToInt32(txtUrunID.Text);
                var x = baglanti.Urunler.Find(id);
                x.Urun_Adi = txtUrunAdi.Text;
                x.UrunAciklama = txtUrunAciklamasi.Text;
                x.Urun_Fiyati = Convert.ToInt32(txtUrunFiyat.Text);
                x.Urun_StokDuzeyi = Convert.ToInt32(txtUrunStok.Text);
                x.KategoriID = Convert.ToInt32(comboBox1.SelectedValue);
                x.Urun_image = txtUrunFoto.Text;
                baglanti.SaveChanges();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Ürün seçimi yapınız...");
            }
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            if (txtUrunID.Text != "")
            {
                int id = Convert.ToInt32(txtUrunID.Text);
                var x = baglanti.Urunler.Find(id);
                baglanti.Urunler.Remove(x);
                baglanti.SaveChanges();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünü seçiniz...");
            }
        }

        public void Temizle()
        {
            txtUrunID.Clear();
            txtUrunStok.Clear();
            txtUrunFiyat.Clear();
            txtUrunAdi.Clear();
            txtUrunAciklamasi.Clear();
            txtUrunFoto.Clear();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            SecimEkrani secimekran = new SecimEkrani();
            secimekran.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}

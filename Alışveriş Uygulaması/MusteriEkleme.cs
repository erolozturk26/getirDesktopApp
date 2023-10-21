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
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
        {
            InitializeComponent();
        }
        private void MusteriEkleme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        Model1Container1 baglanti = new Model1Container1();

        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Musteriler.ToList();
            dataGridView1.ClearSelection();
            //comboAdminYetkisi.DataSource = baglanti.Musteriler.ToList();
            //comboAdminYetkisi.ValueMember = "AdminYetkisi";
            //comboAdminYetkisi.DisplayMember = "AdminYetkisi";
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtMusteriID.Text = satir.Cells["MusteriID"].Value.ToString();
            txtMusteriKullaniciAdi.Text = satir.Cells["Musteri_KullaniciAdi"].Value?.ToString();
            txtMusteriSifre.Text = satir.Cells["Musteri_Sifre"].Value?.ToString();
            txtMusteriAdi.Text = satir.Cells["Musteri_Adi"].Value?.ToString();
            txtMusteriAdres.Text = satir.Cells["Musteri_Adres"].Value?.ToString();
            txtMusteriTelefon.Text = satir.Cells["Musteri_Telefon"].Value?.ToString();
            txtMusteriSehir.Text = satir.Cells["Musteri_Sehir"].Value?.ToString();
            txtMusteriMailAdresi.Text = satir.Cells["Musteri_MailAdresi"].Value?.ToString();
            comboAdminYetkisi.ResetText();
            //comboAdminYetkisi.SelectedText = satir.Cells["AdminYetkisi"].Value?.ToString();
            if (satir.Cells["AdminYetkisi"].Value?.ToString() == "True")
                comboAdminYetkisi.SelectedText = "Yetkisi Var";
            if (satir.Cells["AdminYetkisi"].Value?.ToString() == "False")
                comboAdminYetkisi.SelectedText = "Yetkisi Yok";

        }

        public void Temizle()
        {
            txtMusteriID.Clear();
            txtMusteriKullaniciAdi.Clear();
            txtMusteriSifre.Clear();
            txtMusteriAdi.Clear();
            txtMusteriAdres.Clear();
            txtMusteriTelefon.Clear();
            txtMusteriSehir.Clear();
            txtMusteriMailAdresi.Clear();
            comboAdminYetkisi.ResetText();
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            if (txtMusteriID.Text == "")
            {
                if (txtMusteriAdi.Text != "" && txtMusteriKullaniciAdi.Text != "" && txtMusteriSifre.Text != "")
                {
                    musteriler.Musteri_KullaniciAdi = txtMusteriKullaniciAdi.Text;
                    musteriler.Musteri_Sifre = txtMusteriSifre.Text;
                    musteriler.Musteri_Adi = txtMusteriAdi.Text;
                    musteriler.Musteri_Adres = txtMusteriAdres.Text;
                    musteriler.Musteri_Telefon = txtMusteriTelefon.Text;
                    musteriler.Musteri_Sehir = txtMusteriSehir.Text;
                    musteriler.Musteri_MailAdresi = txtMusteriMailAdresi.Text;
                    //musteriler.
                    baglanti.Musteriler.Add(musteriler);
                    baglanti.SaveChanges();
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Müşteri adı,kullanıcı adı ve şifre kısmı boş bırakılamaz...");
                }
            }
            else
            {
                MessageBox.Show("Müşteri mevcuttur.Lütfen 'Güncelle' butonunu kullanınız.");
            }
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            if (txtMusteriID.Text != "")
            {
                int id = Convert.ToInt32(txtMusteriID.Text);
                var x = baglanti.Musteriler.Find(id);
                x.Musteri_KullaniciAdi = txtMusteriKullaniciAdi.Text;
                x.Musteri_Sifre = txtMusteriSifre.Text;
                x.Musteri_Adi = txtMusteriAdi.Text;
                x.Musteri_Adres = txtMusteriAdres.Text;
                x.Musteri_Telefon = txtMusteriTelefon.Text;
                x.Musteri_Sehir = txtMusteriSehir.Text;
                x.Musteri_MailAdresi = txtMusteriMailAdresi.Text;
                if (comboAdminYetkisi.SelectedItem.ToString() == "Yetkisi Var")
                    x.AdminYetkisi = true;
                if (comboAdminYetkisi.SelectedItem.ToString() == "Yetkisi Yok")
                    x.AdminYetkisi = false;
                baglanti.SaveChanges();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz alanı seçiniz...");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            if (txtMusteriID.Text != "")
            {
                int id = Convert.ToInt32(txtMusteriID.Text);
                var x = baglanti.Musteriler.Find(id);
                baglanti.Musteriler.Remove(x);
                baglanti.SaveChanges();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için müşteri seçiniz...");
            }
        }
    }
}

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
    public partial class Hesabim : Form
    {
        public Musteriler _musteri { get; set; }
        Model1Container1 baglanti = new Model1Container1();
        public Hesabim(Musteriler musteri)
        {
            InitializeComponent();
            _musteri = musteri;
        }

        private void Hesabim_Load(object sender, EventArgs e)
        {            
            var x = baglanti.Musteriler.Find(_musteri.MusteriID);
            txtMusteriID.Text = x.MusteriID.ToString();
            txtMusteriKullaniciAdi.Text = x.Musteri_KullaniciAdi;
            txtMusteriSifre.Text = x.Musteri_Sifre;
            txtMusteriAdi.Text = x.Musteri_Adi;
            txtMusteriAdres.Text = x.Musteri_Adres;
            txtMusteriTelefon.Text = x.Musteri_Telefon;
            txtMusteriSehir.Text = x.Musteri_Sehir;
            txtMusteriMailAdresi.Text = x.Musteri_MailAdresi;

            var sorgu = from sor in baglanti.Satislar // Sadece kullanıcıya ait siparişleri listeleniyor...
                        where sor.MusteriID.ToString() == txtMusteriID.Text
                        select sor;
            dataGridView1.DataSource = sorgu.ToList();
            dataGridView1.ClearSelection();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            var x = baglanti.Musteriler.Find(_musteri.MusteriID);
            x.Musteri_KullaniciAdi = txtMusteriKullaniciAdi.Text;
            x.Musteri_Sifre = txtMusteriSifre.Text;
            x.Musteri_Adi = txtMusteriAdi.Text;
            x.Musteri_Adres = txtMusteriAdres.Text;
            x.Musteri_Telefon = txtMusteriTelefon.Text;
            x.Musteri_Sehir = txtMusteriSehir.Text;
            x.Musteri_MailAdresi = txtMusteriMailAdresi.Text;
            baglanti.SaveChanges();
            MessageBox.Show("Hesap bilgileriniz başarı ile güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Hesabim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secim = dataGridView1.CurrentRow;
            int satisID = Convert.ToInt32(secim.Cells[3].Value.ToString());
            var x = baglanti.Satislar.Find(satisID);
            var y = baglanti.Musteriler.Find(x.MusteriID);
            var z = baglanti.Kuryeler.Find(x.KuryeID);
            txtBilgiMusteriAdi.Text = y.Musteri_Adi;
            txtBilgiSatisTarihi.Text = x.Satis_Tarihi;
            txtBilgiKuryeAdi.Text = z.Kurye_Adi + " - " + z.Kurye_Sirketi;
            txtBilgiAdres.Text = x.Satis_Adresi;
            txtBilgiUrunler.Text = x.UrunAdlari;
            txtBilgiOdenenMiktar.Text = x.Satis_OdenenTutar + " ₺";
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Anasayfa a1 = new Anasayfa(_musteri);
            a1.Show();
            this.Hide();
        }
    }
}

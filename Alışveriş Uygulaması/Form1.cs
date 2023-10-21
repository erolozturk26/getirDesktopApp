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
    public partial class Form1 : Form
    {
        public Musteriler _musteri { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        Model1Container1 baglanti = new Model1Container1();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelGirisYap.Visible = false;
            panelSifremiUnuttum.Visible = true;
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelGirisYap.Visible = false;
            panelKayitOl.Visible = true;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (GirisYap(txtKullaniciAdi.Text,txtSifre.Text))
            {

                Musteriler musteri = baglanti.Musteriler.FirstOrDefault(m => m.Musteri_KullaniciAdi == txtKullaniciAdi.Text);
              //  Musteriler musteri = (from p in baglanti.Musteriler
                       //     where p.Musteri_KullaniciAdi == txtKullaniciAdi.Text
                       //     select p) as Musteriler;
                if (musteri!=null && musteri.AdminYetkisi==false)
                {
                    Anasayfa anasayfagit = new Anasayfa(musteri);
                    anasayfagit.Show();
                    this.Hide();
                }
                else
                {
                    SecimEkrani secimekrani = new SecimEkrani();
                    secimekrani.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış tekrar deneyiniz...","HATA");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdiKayit.Text != "" && txtSifreKayit.Text != "" && txtSifre2Kayit.Text != "" && txtMailKayit.Text != "")
            {
                if (txtSifreKayit.Text == txtSifre2Kayit.Text)
                {
                    if (cboxKabul.Checked == true)
                    {
                        Musteriler ekle = new Musteriler(); //KULLANICI EKLEME KODU
                        ekle.Musteri_KullaniciAdi = txtKullaniciAdiKayit.Text;
                        ekle.Musteri_Sifre = txtSifreKayit.Text;
                        ekle.Musteri_MailAdresi = txtMailKayit.Text;
                        baglanti.Musteriler.Add(ekle);
                        baglanti.SaveChanges();

                        txtKullaniciAdiKayit.Clear();
                        txtSifreKayit.Clear();
                        txtSifre2Kayit.Clear();
                        txtMailKayit.Clear();
                        MessageBox.Show("Kayıt başarılı bir şekilde tamamlandı.");
                        panelKayitOl.Visible = false;
                        panelGirisYap.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı koşullarını kabul ediniz...");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Birbiriyle Uyuşmuyor...");
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş yer bırakmadan doldurunuz...");
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //ENTER İLE İŞLEM YAPIYOR.
            {
                btnGirisYap.PerformClick();
            }
        }
        private bool GirisYap(string ad,string sifre)
        {
            var sorgu = from p in baglanti.Musteriler
                        where p.Musteri_KullaniciAdi == ad && p.Musteri_Sifre == sifre
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            panelGirisYap.Visible = true;
            panelKayitOl.Visible = false;
        }

        private void btnGeriDon_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void btnGeriDon_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if (txtSifreKullaniciAdi.Text != null)
            {
               if (txtSifre1.Text == txtSifre2.Text)
               {
                    Musteriler musteri = baglanti.Musteriler.FirstOrDefault(m => m.Musteri_KullaniciAdi == txtSifreKullaniciAdi.Text);
                    if (musteri != null)
                    {
                        var x = baglanti.Musteriler.Find(musteri.MusteriID);
                        x.Musteri_Sifre = txtSifre1.Text;
                        baglanti.SaveChanges();
                        MessageBox.Show("Şifre başarıyla değiştirildi.");
                        panelSifremiUnuttum.Visible = false;
                        panelGirisYap.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız.\nTekrar Deneyiniz...");
                    }
                }

               else
               {
                 MessageBox.Show("Şifreler birbiri ile uyuşmuyor.\nLütfen tekrar deneyiniz...");
               }
            }

            else
            {
                MessageBox.Show("Kullanıcı adı kısmı boş bırakılamaz...");
            }
        }

        private void btnSifremiUnuttumGeriDon_Click(object sender, EventArgs e)
        {
            panelSifremiUnuttum.Visible = false;
            panelGirisYap.Visible = true;
        }

        private void btnSifremiUnuttumGeriDon_MouseHover(object sender, EventArgs e)
        {
            lblGeriDon.Visible = true;
        }

        private void btnSifremiUnuttumGeriDon_MouseLeave(object sender, EventArgs e)
        {
            lblGeriDon.Visible = false;
        }

        private void txtSifre2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSifreDegistir.PerformClick();
            }
        }
    }
}

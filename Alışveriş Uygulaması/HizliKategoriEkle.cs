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
    public partial class HizliKategoriEkle : Form
    {
        public HizliKategoriEkle()
        {
            InitializeComponent();
        }
        Model1Container1 baglanti = new Model1Container1();

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            //UrunEkle urunEkle = new UrunEkle();
            UrunEkle urunEkle = (UrunEkle)System.Windows.Forms.Application.OpenForms["UrunEkle"]; //Başka Formdaki void Kontrol etmek için tanımlandı.
            Kategori kategori = new Kategori();
            if (txtKategoriEkle.Text != "" && txtKategoriTanim.Text != "")
            {
                kategori.Kategori_Adi = txtKategoriEkle.Text;
                kategori.Kategori_Tanim = txtKategoriTanim.Text;
                baglanti.Kategori.Add(kategori);
                baglanti.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Eklenmiştir.", "BİLGİ");
                urunEkle.Listele();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kategori Adı ve Tanımı Boş Bırakmadan Doldurunuz.","HATA");
            }
        }
    }
}

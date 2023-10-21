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
    public partial class KuryeEkle : Form
    {
        public KuryeEkle()
        {
            InitializeComponent();
        }
        Model1Container1 baglanti = new Model1Container1();
        private void KuryeEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            dataGridView1.DataSource = baglanti.Kuryeler.ToList();
            dataGridView1.ClearSelection();
        }
        public void Temizle()
        {
            txtKuryeAdSoyad.Clear();
            txtKuryeID.Clear();
            txtKuryeSirket.Clear();
            txtKuryeTelefon.Clear();

        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            Kuryeler kurye = new Kuryeler();
            if (txtKuryeID.Text == "")
            {
                if (txtKuryeAdSoyad.Text != "" && txtKuryeSirket.Text != "" && txtKuryeTelefon.Text != "")
                {
                    kurye.Kurye_Adi = txtKuryeAdSoyad.Text;
                    kurye.Kurye_Sirketi = txtKuryeSirket.Text;
                    kurye.Kurye_Telefon = txtKuryeTelefon.Text;
                    baglanti.Kuryeler.Add(kurye);
                    baglanti.SaveChanges();
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Ad Soyad,Telefon ve Şirket kısmı boş bırakılamaz...");
                }
            }
            else
            {
                MessageBox.Show("Kurye mevcuttur.Lütfen 'Güncelle' butonunu kullanınız.");
            }
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            if (txtKuryeID.Text != "")
            {
                int id = Convert.ToInt32(txtKuryeID.Text);
                var x = baglanti.Kuryeler.Find(id);
                x.Kurye_Adi = txtKuryeAdSoyad.Text;
                x.Kurye_Telefon = txtKuryeTelefon.Text;
                x.Kurye_Sirketi = txtKuryeSirket.Text;
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
            txtKuryeID.Text = secim.Cells["KuryeID"].Value.ToString();
            txtKuryeAdSoyad.Text = secim.Cells["Kurye_Adi"].Value.ToString();
            txtKuryeTelefon.Text = secim.Cells["Kurye_Telefon"].Value.ToString();
            txtKuryeSirket.Text = secim.Cells["Kurye_Sirketi"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKuryeID.Text != "")
            {
                int id = Convert.ToInt32(txtKuryeID.Text);
                var x = baglanti.Kuryeler.Find(id);
                baglanti.Kuryeler.Remove(x);
                baglanti.SaveChanges();
                Listele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kuryeyi seçiniz.");
            }
        }

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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}

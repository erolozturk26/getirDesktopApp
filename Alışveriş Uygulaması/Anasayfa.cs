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
    public partial class Anasayfa : Form
    {
        public Musteriler _musteri { get; set; }
        public Anasayfa(Musteriler musteri)
        {
            _musteri = musteri;
            InitializeComponent();
        }
        Model1Container1 baglanti = new Model1Container1();
        static int toplamfiyat=0;
        static int silineceksatir;

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnGizleGoster.Text == "SEPETİM")
            {
                btnGizleGoster.Text = "SEPETİM: "+toplamfiyat+" ₺";
                panelSepet.Visible = false;
            }
            else if (btnGizleGoster.Text != "SEPETİM")
            {
                btnGizleGoster.Text = "SEPETİM";
                panelSepet.Visible = true;
            }
        } //SEPET BUTONU

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = baglanti.Kategori.ToList();
            comboBox1.ValueMember = "KategoriID";
            comboBox1.DisplayMember = "Kategori_Adi";
            dataGridView1.Columns[0].Visible = false;
            dataGridView2.Rows[0].Cells[0].Selected = true;
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int xsayi;
            int.TryParse(comboBox1.SelectedValue.ToString() , out xsayi) ; //TryParse gelen değeri alır ama değer gelmez ise 0 alır.

            dataGridView2.DataSource = baglanti.Urunler.Where(x => x.KategoriID == xsayi).ToList();
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow secim = dataGridView2.CurrentRow;
            lblUrunBaslik.Tag = secim.Cells["UrunID"].Value.ToString();
            lblUrunBaslik.Text = secim.Cells["Urun_Adi"].Value.ToString();
            lblUrunFiyat.Tag = secim.Cells["Urun_Fiyati"].Value.ToString();
            lblUrunFiyat.Text = (secim.Cells["Urun_Fiyati"].Value.ToString()+"₺");
            lblUrunAciklama.Text = secim.Cells["UrunAciklama"].Value.ToString();
            lblStokSayisi.Text = secim.Cells["Urun_StokDuzeyi"].Value.ToString();
            pictureBox1.ImageLocation = secim.Cells["Urun_image"].Value.ToString();
            groupBox1.Visible = true;
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            int stok = Convert.ToInt32(lblStokSayisi.Text);
            if (stok >= numericUpDown1.Value && numericUpDown1.Value > 0) //STOK KONTROLÜ
            {
                dataGridView1.Rows.Add(lblUrunBaslik.Tag,lblUrunBaslik.Text,numericUpDown1.Value,lblUrunFiyat.Tag);
                int id = Convert.ToInt32(lblUrunBaslik.Tag);
                var x = baglanti.Urunler.Find(id);
                int stokdusurme = Convert.ToInt32(x.Urun_StokDuzeyi);
                x.Urun_StokDuzeyi = stokdusurme - Convert.ToInt32(numericUpDown1.Value);
                lblStokSayisi.Text = x.Urun_StokDuzeyi.ToString();
                toplamfiyat += Convert.ToInt32(lblUrunFiyat.Tag) * Convert.ToInt32(numericUpDown1.Value);
                label4.Tag = toplamfiyat;
                label4.Text = toplamfiyat.ToString() + "₺";
                numericUpDown1.Value = 1;
                if (panelSepet.Visible == false) //Sepet paneli kapalı ise butona basılmış gibi çalışacak.
                {
                    btnGizleGoster.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz stok lütfen tekrar deneyin.","HATA");
            }
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label4.Tag) > 0)
            {
                DialogResult result = MessageBox.Show("Sipariş Tutarınız: " + label4.Text + "\nÖdemeyi Onaylıyor Musunuz ?", "ÖDEME", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Random random = new Random();
                    Kuryeler kuryeler = new Kuryeler();
                    Satislar satislar = new Satislar();
                    var x = baglanti.Musteriler.Find(_musteri.MusteriID);
                    satislar.MusteriID = x.MusteriID;
                    satislar.Satis_Tarihi = DateTime.Now.ToString();
                    satislar.Satis_OdenenTutar = toplamfiyat;
                    //satislar.Satis_KuryeUcreti = 
                    satislar.Satis_Adresi = x.Musteri_Adres;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            satislar.UrunAdlari += row.Cells[1].Value + "-" + row.Cells[2].Value + " Adet || ";
                        }
                    }
                    satislar.UrunID = 1;
                    satislar.KuryeID = random.Next(1,5);
                    baglanti.Satislar.Add(satislar);
                    baglanti.SaveChanges();
                    dataGridView1.Rows.Clear();
                    label4.Text = "0 ₺";
                    label4.Tag = 0;
                    toplamfiyat = 0;
                    MessageBox.Show("SİPARİŞİNİZ ALINMIŞTIR...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Sepetiniz Boş\nLütfen ürün ekledikten sonra tekrar deneyiniz...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            silineceksatir = dataGridView1.CurrentRow.Index;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //dataGridView1.ClearSelection();
            if (dataGridView1.RowCount >= 1) //DataGrid de olan güncel satırları gösteriyor 1den fazla değer varsa döngüye giriyor.
            {
                int urunid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int urunstok = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                int fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                var x = baglanti.Urunler.Find(urunid);
                x.Urun_StokDuzeyi = urunstok + Convert.ToInt32(x.Urun_StokDuzeyi);
                toplamfiyat -= urunstok * fiyat;
                label4.Text = toplamfiyat.ToString() + "₺";
                dataGridView1.Rows.RemoveAt(silineceksatir);
                var y = baglanti.Urunler.Find(Convert.ToInt32(lblUrunBaslik.Tag));
                lblStokSayisi.Text = y.Urun_StokDuzeyi.ToString();
            }
            else
            {
                MessageBox.Show("Silmek için seçilmiş bi ürün yok...","BİLGİ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            var result = MessageBox.Show("Oturumu kapatmak üzeresiniz\nDevam etmek istiyor musunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                f1.Show();
                this.Hide();
            }
        }

        private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHesabim_Click(object sender, EventArgs e)
        {
            Hesabim hesap = new Hesabim(_musteri);
            hesap.Show();
            this.Hide();
        }
    }
}

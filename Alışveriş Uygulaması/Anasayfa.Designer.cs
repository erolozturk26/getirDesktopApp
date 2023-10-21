namespace Alışveriş_Uygulaması
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiparisOnayla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGizleGoster = new System.Windows.Forms.Button();
            this.panelSepet = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUrunBaslik = new System.Windows.Forms.Label();
            this.lblUrunAciklama = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStokSayisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHesabim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSepet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(238, 440);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ürün No";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adet";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fiyat";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnSiparisOnayla
            // 
            this.btnSiparisOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(62)))), ((int)(((byte)(188)))));
            this.btnSiparisOnayla.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnSiparisOnayla.ForeColor = System.Drawing.Color.Yellow;
            this.btnSiparisOnayla.Location = new System.Drawing.Point(27, 478);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.Size = new System.Drawing.Size(122, 40);
            this.btnSiparisOnayla.TabIndex = 2;
            this.btnSiparisOnayla.Text = "Siparişi Onayla";
            this.btnSiparisOnayla.UseVisualStyleBackColor = false;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(62)))), ((int)(((byte)(188)))));
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(167, 478);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(61, 40);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGizleGoster
            // 
            this.btnGizleGoster.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGizleGoster.Location = new System.Drawing.Point(768, 10);
            this.btnGizleGoster.Name = "btnGizleGoster";
            this.btnGizleGoster.Size = new System.Drawing.Size(146, 41);
            this.btnGizleGoster.TabIndex = 4;
            this.btnGizleGoster.Text = "SEPETİM";
            this.btnGizleGoster.UseVisualStyleBackColor = true;
            this.btnGizleGoster.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelSepet
            // 
            this.panelSepet.AutoSize = true;
            this.panelSepet.Controls.Add(this.label4);
            this.panelSepet.Controls.Add(this.label5);
            this.panelSepet.Controls.Add(this.dataGridView1);
            this.panelSepet.Controls.Add(this.btnSil);
            this.panelSepet.Controls.Add(this.btnSiparisOnayla);
            this.panelSepet.Location = new System.Drawing.Point(765, 57);
            this.panelSepet.Name = "panelSepet";
            this.panelSepet.Size = new System.Drawing.Size(245, 521);
            this.panelSepet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(170, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 26);
            this.label4.TabIndex = 10;
            this.label4.Tag = "0";
            this.label4.Text = "0 ₺";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam Ücret :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblUrunBaslik
            // 
            this.lblUrunBaslik.AutoSize = true;
            this.lblUrunBaslik.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunBaslik.Location = new System.Drawing.Point(136, 19);
            this.lblUrunBaslik.Name = "lblUrunBaslik";
            this.lblUrunBaslik.Size = new System.Drawing.Size(142, 35);
            this.lblUrunBaslik.TabIndex = 4;
            this.lblUrunBaslik.Text = "Ürün Başlık";
            // 
            // lblUrunAciklama
            // 
            this.lblUrunAciklama.AutoSize = true;
            this.lblUrunAciklama.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Bold);
            this.lblUrunAciklama.Location = new System.Drawing.Point(139, 54);
            this.lblUrunAciklama.Name = "lblUrunAciklama";
            this.lblUrunAciklama.Size = new System.Drawing.Size(86, 18);
            this.lblUrunAciklama.TabIndex = 7;
            this.lblUrunAciklama.Text = "Ürün Açıklama";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(212, 128);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(62)))), ((int)(((byte)(188)))));
            this.btnSepeteEkle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.Yellow;
            this.btnSepeteEkle.Location = new System.Drawing.Point(257, 123);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(116, 30);
            this.btnSepeteEkle.TabIndex = 4;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 61);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(355, 505);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUrunFiyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblStokSayisi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblUrunBaslik);
            this.groupBox1.Controls.Add(this.btnSepeteEkle);
            this.groupBox1.Controls.Add(this.lblUrunAciklama);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(382, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEÇİLEN ÜRÜN";
            this.groupBox1.Visible = false;
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyat.Location = new System.Drawing.Point(294, 85);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(23, 35);
            this.lblUrunFiyat.TabIndex = 12;
            this.lblUrunFiyat.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(206, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fiyat :";
            // 
            // lblStokSayisi
            // 
            this.lblStokSayisi.AutoSize = true;
            this.lblStokSayisi.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Bold);
            this.lblStokSayisi.ForeColor = System.Drawing.Color.White;
            this.lblStokSayisi.Location = new System.Drawing.Point(177, 127);
            this.lblStokSayisi.Name = "lblStokSayisi";
            this.lblStokSayisi.Size = new System.Drawing.Size(12, 18);
            this.lblStokSayisi.TabIndex = 10;
            this.lblStokSayisi.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(139, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stok :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tüm Ürünler"});
            this.comboBox1.Location = new System.Drawing.Point(178, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kategoriler :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(468, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 49);
            this.button1.TabIndex = 44;
            this.button1.Text = "OTURUMU KAPAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHesabim
            // 
            this.btnHesabim.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesabim.Location = new System.Drawing.Point(920, 10);
            this.btnHesabim.Name = "btnHesabim";
            this.btnHesabim.Size = new System.Drawing.Size(86, 41);
            this.btnHesabim.TabIndex = 45;
            this.btnHesabim.Text = "Hesabım";
            this.btnHesabim.UseVisualStyleBackColor = true;
            this.btnHesabim.Click += new System.EventHandler(this.btnHesabim_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(62)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1010, 580);
            this.Controls.Add(this.btnHesabim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panelSepet);
            this.Controls.Add(this.btnGizleGoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Anasayfa_FormClosed);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSepet.ResumeLayout(false);
            this.panelSepet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSiparisOnayla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGizleGoster;
        private System.Windows.Forms.Panel panelSepet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUrunBaslik;
        private System.Windows.Forms.Label lblUrunAciklama;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStokSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHesabim;
    }
}
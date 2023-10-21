namespace Alışveriş_Uygulaması
{
    partial class KuryeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KuryeEkle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtKuryeTelefon = new System.Windows.Forms.TextBox();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKuryeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.txtKuryeSirket = new System.Windows.Forms.TextBox();
            this.txtKuryeAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(567, 407);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(186, 294);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 33);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.txtKuryeTelefon);
            this.groupBox1.Controls.Add(this.btnGuncelleme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKuryeID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnEkleme);
            this.groupBox1.Controls.Add(this.txtKuryeSirket);
            this.groupBox1.Controls.Add(this.txtKuryeAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 343);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KURYE EKLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "KURYE TELEFON :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Teal;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(18, 294);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 33);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtKuryeTelefon
            // 
            this.txtKuryeTelefon.Location = new System.Drawing.Point(167, 135);
            this.txtKuryeTelefon.Name = "txtKuryeTelefon";
            this.txtKuryeTelefon.Size = new System.Drawing.Size(161, 20);
            this.txtKuryeTelefon.TabIndex = 2;
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGuncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelleme.ForeColor = System.Drawing.Color.White;
            this.btnGuncelleme.Location = new System.Drawing.Point(186, 233);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(150, 55);
            this.btnGuncelleme.TabIndex = 5;
            this.btnGuncelleme.Text = "GÜNCELLE";
            this.btnGuncelleme.UseVisualStyleBackColor = false;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "KURYE ID :";
            // 
            // txtKuryeID
            // 
            this.txtKuryeID.BackColor = System.Drawing.SystemColors.Info;
            this.txtKuryeID.Enabled = false;
            this.txtKuryeID.Location = new System.Drawing.Point(167, 37);
            this.txtKuryeID.Name = "txtKuryeID";
            this.txtKuryeID.Size = new System.Drawing.Size(161, 20);
            this.txtKuryeID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "KURYE ŞİRKETİ :";
            // 
            // btnEkleme
            // 
            this.btnEkleme.BackColor = System.Drawing.Color.Navy;
            this.btnEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleme.ForeColor = System.Drawing.Color.White;
            this.btnEkleme.Location = new System.Drawing.Point(18, 233);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(150, 55);
            this.btnEkleme.TabIndex = 4;
            this.btnEkleme.Text = "EKLE";
            this.btnEkleme.UseVisualStyleBackColor = false;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // txtKuryeSirket
            // 
            this.txtKuryeSirket.Location = new System.Drawing.Point(167, 184);
            this.txtKuryeSirket.Name = "txtKuryeSirket";
            this.txtKuryeSirket.Size = new System.Drawing.Size(161, 20);
            this.txtKuryeSirket.TabIndex = 3;
            // 
            // txtKuryeAdSoyad
            // 
            this.txtKuryeAdSoyad.Location = new System.Drawing.Point(167, 85);
            this.txtKuryeAdSoyad.Name = "txtKuryeAdSoyad";
            this.txtKuryeAdSoyad.Size = new System.Drawing.Size(161, 20);
            this.txtKuryeAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "KURYE AD-SOYAD :";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeriDon.BackgroundImage")));
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeriDon.Location = new System.Drawing.Point(845, 6);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(50, 50);
            this.btnGeriDon.TabIndex = 32;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCikis.Location = new System.Drawing.Point(901, 6);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 50);
            this.btnCikis.TabIndex = 31;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // KuryeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(62)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(963, 479);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KuryeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurye Ekleme";
            this.Load += new System.EventHandler(this.KuryeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKuryeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.TextBox txtKuryeSirket;
        private System.Windows.Forms.TextBox txtKuryeAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKuryeTelefon;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
    }
}
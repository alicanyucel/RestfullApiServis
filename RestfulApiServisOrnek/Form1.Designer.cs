
namespace RestfulApiServisOrnek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKullaniciBilgiAl = new System.Windows.Forms.Button();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKullaniciMeslek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeniKullaniciEkle = new System.Windows.Forms.Button();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbSayfaNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTumKullaniciBilgileriniAl = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtYeniMeslek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYeniAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKullaniciDuzenle = new System.Windows.Forms.Button();
            this.txtDuzenleKulaniciId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.txtSilKullaniciId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.kisiResim = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kisiResim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCevap
            // 
            this.txtCevap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCevap.Location = new System.Drawing.Point(13, 13);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.ReadOnly = true;
            this.txtCevap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCevap.Size = new System.Drawing.Size(732, 260);
            this.txtCevap.TabIndex = 1;
            // 
            // txtBilgi
            // 
            this.txtBilgi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBilgi.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBilgi.Location = new System.Drawing.Point(13, 424);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.ReadOnly = true;
            this.txtBilgi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBilgi.Size = new System.Drawing.Size(732, 232);
            this.txtBilgi.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKullaniciBilgiAl);
            this.groupBox1.Controls.Add(this.txtKullaniciID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Id\'ye Göre Tek Kullanıcı Sorgulama";
            // 
            // btnKullaniciBilgiAl
            // 
            this.btnKullaniciBilgiAl.Location = new System.Drawing.Point(100, 19);
            this.btnKullaniciBilgiAl.Name = "btnKullaniciBilgiAl";
            this.btnKullaniciBilgiAl.Size = new System.Drawing.Size(113, 41);
            this.btnKullaniciBilgiAl.TabIndex = 2;
            this.btnKullaniciBilgiAl.Text = "KULLANICI BİLGİSİ AL";
            this.btnKullaniciBilgiAl.UseVisualStyleBackColor = true;
            this.btnKullaniciBilgiAl.Click += new System.EventHandler(this.btnKullaniciBilgiAl_Click);
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(6, 40);
            this.txtKullaniciID.MaxLength = 3;
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(85, 20);
            this.txtKullaniciID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı ID Giriniz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKullaniciMeslek);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnYeniKullaniciEkle);
            this.groupBox2.Controls.Add(this.txtKullaniciAd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(238, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kullanıcı Ekle";
            // 
            // txtKullaniciMeslek
            // 
            this.txtKullaniciMeslek.Location = new System.Drawing.Point(83, 40);
            this.txtKullaniciMeslek.MaxLength = 20;
            this.txtKullaniciMeslek.Name = "txtKullaniciMeslek";
            this.txtKullaniciMeslek.Size = new System.Drawing.Size(71, 20);
            this.txtKullaniciMeslek.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Meslek";
            // 
            // btnYeniKullaniciEkle
            // 
            this.btnYeniKullaniciEkle.Location = new System.Drawing.Point(160, 14);
            this.btnYeniKullaniciEkle.Name = "btnYeniKullaniciEkle";
            this.btnYeniKullaniciEkle.Size = new System.Drawing.Size(53, 46);
            this.btnYeniKullaniciEkle.TabIndex = 5;
            this.btnYeniKullaniciEkle.Text = "EKLE";
            this.btnYeniKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnYeniKullaniciEkle.Click += new System.EventHandler(this.btnYeniKullaniciEkle_Click);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(6, 40);
            this.txtKullaniciAd.MaxLength = 30;
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(71, 20);
            this.txtKullaniciAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbSayfaNo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnTumKullaniciBilgileriniAl);
            this.groupBox3.Location = new System.Drawing.Point(463, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 67);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcı Bilgilerini Alma";
            // 
            // cmbSayfaNo
            // 
            this.cmbSayfaNo.FormattingEnabled = true;
            this.cmbSayfaNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbSayfaNo.Location = new System.Drawing.Point(9, 38);
            this.cmbSayfaNo.Name = "cmbSayfaNo";
            this.cmbSayfaNo.Size = new System.Drawing.Size(83, 21);
            this.cmbSayfaNo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sayfa No";
            // 
            // btnTumKullaniciBilgileriniAl
            // 
            this.btnTumKullaniciBilgileriniAl.Location = new System.Drawing.Point(98, 14);
            this.btnTumKullaniciBilgileriniAl.Name = "btnTumKullaniciBilgileriniAl";
            this.btnTumKullaniciBilgileriniAl.Size = new System.Drawing.Size(178, 45);
            this.btnTumKullaniciBilgileriniAl.TabIndex = 1;
            this.btnTumKullaniciBilgileriniAl.Text = "TÜM KULLANICI BİLGİLERİNİ AL\r\nController ismi users";
            this.btnTumKullaniciBilgileriniAl.UseVisualStyleBackColor = true;
            this.btnTumKullaniciBilgileriniAl.Click += new System.EventHandler(this.btnTumKullaniciBilgileriniAl_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtYeniMeslek);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtYeniAd);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnKullaniciDuzenle);
            this.groupBox4.Controls.Add(this.txtDuzenleKulaniciId);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(10, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(447, 66);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kullanıcı Bilgi Düzenle";
            // 
            // txtYeniMeslek
            // 
            this.txtYeniMeslek.Location = new System.Drawing.Point(219, 40);
            this.txtYeniMeslek.MaxLength = 20;
            this.txtYeniMeslek.Name = "txtYeniMeslek";
            this.txtYeniMeslek.Size = new System.Drawing.Size(103, 20);
            this.txtYeniMeslek.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Yeni Meslek";
            // 
            // txtYeniAd
            // 
            this.txtYeniAd.Location = new System.Drawing.Point(100, 40);
            this.txtYeniAd.MaxLength = 30;
            this.txtYeniAd.Name = "txtYeniAd";
            this.txtYeniAd.Size = new System.Drawing.Size(113, 20);
            this.txtYeniAd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Yeni Ad";
            // 
            // btnKullaniciDuzenle
            // 
            this.btnKullaniciDuzenle.Location = new System.Drawing.Point(328, 19);
            this.btnKullaniciDuzenle.Name = "btnKullaniciDuzenle";
            this.btnKullaniciDuzenle.Size = new System.Drawing.Size(113, 41);
            this.btnKullaniciDuzenle.TabIndex = 2;
            this.btnKullaniciDuzenle.Text = "DÜZENLE";
            this.btnKullaniciDuzenle.UseVisualStyleBackColor = true;
            this.btnKullaniciDuzenle.Click += new System.EventHandler(this.btnKullaniciDuzenle_Click);
            // 
            // txtDuzenleKulaniciId
            // 
            this.txtDuzenleKulaniciId.Location = new System.Drawing.Point(6, 40);
            this.txtDuzenleKulaniciId.MaxLength = 3;
            this.txtDuzenleKulaniciId.Name = "txtDuzenleKulaniciId";
            this.txtDuzenleKulaniciId.Size = new System.Drawing.Size(88, 20);
            this.txtDuzenleKulaniciId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kullanıcı ID Giriniz";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnKullaniciSil);
            this.groupBox5.Controls.Add(this.txtSilKullaniciId);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(463, 358);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 66);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kullanıcı Sil";
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(100, 17);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(176, 41);
            this.btnKullaniciSil.TabIndex = 2;
            this.btnKullaniciSil.Text = "KULLANICI SİL";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // txtSilKullaniciId
            // 
            this.txtSilKullaniciId.Location = new System.Drawing.Point(6, 35);
            this.txtSilKullaniciId.MaxLength = 3;
            this.txtSilKullaniciId.Name = "txtSilKullaniciId";
            this.txtSilKullaniciId.Size = new System.Drawing.Size(85, 20);
            this.txtSilKullaniciId.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kullanıcı ID Giriniz";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblMail);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.lblSoyad);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.lblAd);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.lblID);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.kisiResim);
            this.groupBox6.Location = new System.Drawing.Point(752, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(185, 643);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kullanıcı Detay";
            // 
            // kisiResim
            // 
            this.kisiResim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kisiResim.Location = new System.Drawing.Point(42, 164);
            this.kisiResim.Name = "kisiResim";
            this.kisiResim.Size = new System.Drawing.Size(100, 115);
            this.kisiResim.TabIndex = 0;
            this.kisiResim.TabStop = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 108);
            this.label9.TabIndex = 1;
            this.label9.Text = "Soll Taraftan ID Numarası girip KULLANICI BİLGİSİ AL butonuna tıkladığınızda o ku" +
    "llanıcıya ait JSON bilgisi burada ayrıntılarına ayrıştırılmış şekilde düzenli ol" +
    "arak gösterilir.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "ID";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(8, 335);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(169, 16);
            this.lblID.TabIndex = 12;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAd.Location = new System.Drawing.Point(8, 388);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(169, 16);
            this.lblAd.TabIndex = 14;
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "AD";
            // 
            // lblSoyad
            // 
            this.lblSoyad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSoyad.Location = new System.Drawing.Point(8, 442);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(169, 16);
            this.lblSoyad.TabIndex = 16;
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "SOYAD";
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMail.Location = new System.Drawing.Point(8, 500);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(169, 16);
            this.lblMail.TabIndex = 18;
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 483);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "E-MAIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 668);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.txtCevap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kisiResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKullaniciBilgiAl;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKullaniciMeslek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniKullaniciEkle;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbSayfaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTumKullaniciBilgileriniAl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKullaniciDuzenle;
        private System.Windows.Forms.TextBox txtDuzenleKulaniciId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYeniMeslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYeniAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.TextBox txtSilKullaniciId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox kisiResim;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label label13;
    }
}


namespace PersonelForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnResimSec = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            cmbUnvan = new ComboBox();
            label9 = new Label();
            dtIseGirisTarihi = new DateTimePicker();
            label8 = new Label();
            pbResim = new PictureBox();
            label7 = new Label();
            txtAdres = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtTelefonNo = new TextBox();
            dtDogumTarihi = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            txtTCKimlikNumarasi = new TextBox();
            label1 = new Label();
            lstPersoneller = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnResimSec);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(cmbUnvan);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtIseGirisTarihi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pbResim);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefonNo);
            groupBox1.Controls.Add(dtDogumTarihi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTCKimlikNumarasi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(923, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(504, 170);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(136, 102);
            btnResimSec.TabIndex = 23;
            btnResimSec.Text = "RESİM SEÇ";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(717, 179);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(186, 32);
            btnSil.TabIndex = 22;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(717, 141);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(186, 32);
            btnGuncelle.TabIndex = 21;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(717, 101);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(186, 32);
            btnEkle.TabIndex = 20;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbUnvan
            // 
            cmbUnvan.FormattingEnabled = true;
            cmbUnvan.Location = new Point(717, 61);
            cmbUnvan.Name = "cmbUnvan";
            cmbUnvan.Size = new Size(186, 23);
            cmbUnvan.TabIndex = 19;
            // 
            // label9
            // 
            label9.Location = new Point(581, 69);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 18;
            label9.Text = "Ünvan:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // dtIseGirisTarihi
            // 
            dtIseGirisTarihi.Location = new Point(717, 19);
            dtIseGirisTarihi.Name = "dtIseGirisTarihi";
            dtIseGirisTarihi.Size = new Size(186, 23);
            dtIseGirisTarihi.TabIndex = 17;
            // 
            // label8
            // 
            label8.Location = new Point(581, 27);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 16;
            label8.Text = "İşe Giriş Tarihi:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // pbResim
            // 
            pbResim.Location = new Point(357, 69);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(141, 203);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 15;
            pbResim.TabStop = false;
            // 
            // label7
            // 
            label7.Location = new Point(15, 236);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 14;
            label7.Text = "Adres:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(148, 228);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(186, 23);
            txtAdres.TabIndex = 13;
            // 
            // label6
            // 
            label6.Location = new Point(15, 207);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 12;
            label6.Text = "Email:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 23);
            txtEmail.TabIndex = 11;
            // 
            // label5
            // 
            label5.Location = new Point(15, 178);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefon Numarası:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Location = new Point(148, 170);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new Size(186, 23);
            txtTelefonNo.TabIndex = 9;
            // 
            // dtDogumTarihi
            // 
            dtDogumTarihi.Location = new Point(148, 141);
            dtDogumTarihi.Name = "dtDogumTarihi";
            dtDogumTarihi.Size = new Size(186, 23);
            dtDogumTarihi.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(15, 149);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 7;
            label3.Text = "Doğum Tarihi:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.Location = new Point(15, 109);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 6;
            label4.Text = "Soyad:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(148, 101);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(186, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(148, 61);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(186, 23);
            txtAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 2;
            label2.Text = "Ad:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTCKimlikNumarasi
            // 
            txtTCKimlikNumarasi.Location = new Point(148, 22);
            txtTCKimlikNumarasi.Name = "txtTCKimlikNumarasi";
            txtTCKimlikNumarasi.Size = new Size(186, 23);
            txtTCKimlikNumarasi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik Numarası:";
            // 
            // lstPersoneller
            // 
            lstPersoneller.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lstPersoneller.FullRowSelect = true;
            lstPersoneller.GridLines = true;
            lstPersoneller.Location = new Point(12, 327);
            lstPersoneller.Name = "lstPersoneller";
            lstPersoneller.Size = new Size(923, 179);
            lstPersoneller.TabIndex = 24;
            lstPersoneller.UseCompatibleStateImageBehavior = false;
            lstPersoneller.View = View.Details;
            lstPersoneller.DoubleClick += lstPersoneller_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TC Kimlik No";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Doğum Tarihi";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Email";
            columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İşe GirişTarihi";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ünvan";
            columnHeader7.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 518);
            Controls.Add(lstPersoneller);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtTCKimlikNumarasi;
        private DateTimePicker dtIseGirisTarihi;
        private Label label8;
        private PictureBox pbResim;
        private Label label7;
        private TextBox txtAdres;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtTelefonNo;
        private DateTimePicker dtDogumTarihi;
        private Label label3;
        private Button btnResimSec;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private ComboBox cmbUnvan;
        private Label label9;
        private ListView lstPersoneller;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
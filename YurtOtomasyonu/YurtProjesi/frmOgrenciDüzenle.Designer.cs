namespace YurtProjesi
{
    partial class frmOgrenciDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciDüzenle));
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.rtVeliAdres = new System.Windows.Forms.RichTextBox();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbOdaNo = new System.Windows.Forms.ComboBox();
            this.cbOgrenciBolum = new System.Windows.Forms.ComboBox();
            this.mtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mtVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtOgrenciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(151, 576);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(110, 37);
            this.btnDuzenle.TabIndex = 13;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // rtVeliAdres
            // 
            this.rtVeliAdres.BackColor = System.Drawing.Color.Honeydew;
            this.rtVeliAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtVeliAdres.Location = new System.Drawing.Point(151, 470);
            this.rtVeliAdres.Name = "rtVeliAdres";
            this.rtVeliAdres.Size = new System.Drawing.Size(223, 96);
            this.rtVeliAdres.TabIndex = 12;
            this.rtVeliAdres.Text = "";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.Color.Honeydew;
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(156, 388);
            this.txtVeliAdSoyad.Multiline = true;
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(218, 26);
            this.txtVeliAdSoyad.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Veli Adı Soyadı :";
            // 
            // cbOdaNo
            // 
            this.cbOdaNo.BackColor = System.Drawing.Color.Honeydew;
            this.cbOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdaNo.FormattingEnabled = true;
            this.cbOdaNo.Location = new System.Drawing.Point(156, 345);
            this.cbOdaNo.Name = "cbOdaNo";
            this.cbOdaNo.Size = new System.Drawing.Size(218, 28);
            this.cbOdaNo.TabIndex = 9;
            // 
            // cbOgrenciBolum
            // 
            this.cbOgrenciBolum.BackColor = System.Drawing.Color.Honeydew;
            this.cbOgrenciBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOgrenciBolum.FormattingEnabled = true;
            this.cbOgrenciBolum.Location = new System.Drawing.Point(156, 261);
            this.cbOgrenciBolum.Name = "cbOgrenciBolum";
            this.cbOgrenciBolum.Size = new System.Drawing.Size(218, 28);
            this.cbOgrenciBolum.TabIndex = 7;
            // 
            // mtDogumTarihi
            // 
            this.mtDogumTarihi.BackColor = System.Drawing.Color.Honeydew;
            this.mtDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtDogumTarihi.Location = new System.Drawing.Point(156, 220);
            this.mtDogumTarihi.Mask = "00/00/0000";
            this.mtDogumTarihi.Name = "mtDogumTarihi";
            this.mtDogumTarihi.Size = new System.Drawing.Size(218, 26);
            this.mtDogumTarihi.TabIndex = 6;
            // 
            // mtVeliTelefon
            // 
            this.mtVeliTelefon.BackColor = System.Drawing.Color.Honeydew;
            this.mtVeliTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtVeliTelefon.Location = new System.Drawing.Point(156, 429);
            this.mtVeliTelefon.Mask = "(999) 000-0000";
            this.mtVeliTelefon.Name = "mtVeliTelefon";
            this.mtVeliTelefon.Size = new System.Drawing.Size(218, 26);
            this.mtVeliTelefon.TabIndex = 11;
            // 
            // mtOgrenciTelefon
            // 
            this.mtOgrenciTelefon.BackColor = System.Drawing.Color.Honeydew;
            this.mtOgrenciTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtOgrenciTelefon.Location = new System.Drawing.Point(156, 179);
            this.mtOgrenciTelefon.Mask = "(999) 000-0000";
            this.mtOgrenciTelefon.Name = "mtOgrenciTelefon";
            this.mtOgrenciTelefon.Size = new System.Drawing.Size(218, 26);
            this.mtOgrenciTelefon.TabIndex = 5;
            // 
            // mtTcNo
            // 
            this.mtTcNo.BackColor = System.Drawing.Color.Honeydew;
            this.mtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtTcNo.Location = new System.Drawing.Point(156, 138);
            this.mtTcNo.Mask = "00000000000";
            this.mtTcNo.Name = "mtTcNo";
            this.mtTcNo.Size = new System.Drawing.Size(218, 26);
            this.mtTcNo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(71, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Oda No :";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Honeydew;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(156, 304);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(218, 26);
            this.txtMail.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(81, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "E-Mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Öğrenci Bölüm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(9, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Veli Telefon No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Doğum Tarihi  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Telefon No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Öğrenci TC No :";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.BackColor = System.Drawing.Color.Honeydew;
            this.txtOgrenciSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(156, 97);
            this.txtOgrenciSoyad.Multiline = true;
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(218, 26);
            this.txtOgrenciSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Öğrenci Soyad :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(49, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Veli Adres :";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.BackColor = System.Drawing.Color.Honeydew;
            this.txtOgrenciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciAd.Location = new System.Drawing.Point(156, 56);
            this.txtOgrenciAd.Multiline = true;
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(218, 26);
            this.txtOgrenciAd.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(44, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Öğrenci Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 4);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(51, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "Öğrenci ID :";
            this.label13.Visible = false;
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.BackColor = System.Drawing.Color.Honeydew;
            this.txtOgrenciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciID.Location = new System.Drawing.Point(156, 15);
            this.txtOgrenciID.Multiline = true;
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(218, 26);
            this.txtOgrenciID.TabIndex = 1;
            this.txtOgrenciID.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(263, 576);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 37);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmOgrenciDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 625);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.rtVeliAdres);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbOdaNo);
            this.Controls.Add(this.cbOgrenciBolum);
            this.Controls.Add(this.mtDogumTarihi);
            this.Controls.Add(this.mtVeliTelefon);
            this.Controls.Add(this.mtOgrenciTelefon);
            this.Controls.Add(this.mtTcNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrenciSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOgrenciID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOgrenciDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Düzenle";
            this.Load += new System.EventHandler(this.frmOgrenciDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.RichTextBox rtVeliAdres;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbOdaNo;
        private System.Windows.Forms.ComboBox cbOgrenciBolum;
        private System.Windows.Forms.MaskedTextBox mtDogumTarihi;
        private System.Windows.Forms.MaskedTextBox mtVeliTelefon;
        private System.Windows.Forms.MaskedTextBox mtOgrenciTelefon;
        private System.Windows.Forms.MaskedTextBox mtTcNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Button btnSil;
    }
}
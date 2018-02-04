namespace YurtProjesi
{
    partial class frmOgrenciKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciKayıt));
            this.btnKaydet = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(186, 548);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(154, 37);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rtVeliAdres
            // 
            this.rtVeliAdres.BackColor = System.Drawing.Color.Honeydew;
            this.rtVeliAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtVeliAdres.Location = new System.Drawing.Point(157, 446);
            this.rtVeliAdres.Name = "rtVeliAdres";
            this.rtVeliAdres.Size = new System.Drawing.Size(223, 96);
            this.rtVeliAdres.TabIndex = 11;
            this.rtVeliAdres.Text = "";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.Color.Honeydew;
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(162, 360);
            this.txtVeliAdSoyad.Multiline = true;
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(218, 26);
            this.txtVeliAdSoyad.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Veli Adı Soyadı :";
            // 
            // cbOdaNo
            // 
            this.cbOdaNo.BackColor = System.Drawing.Color.Honeydew;
            this.cbOdaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdaNo.FormattingEnabled = true;
            this.cbOdaNo.Location = new System.Drawing.Point(162, 315);
            this.cbOdaNo.Name = "cbOdaNo";
            this.cbOdaNo.Size = new System.Drawing.Size(218, 28);
            this.cbOdaNo.TabIndex = 8;
            // 
            // cbOgrenciBolum
            // 
            this.cbOgrenciBolum.BackColor = System.Drawing.Color.Honeydew;
            this.cbOgrenciBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOgrenciBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOgrenciBolum.FormattingEnabled = true;
            this.cbOgrenciBolum.Location = new System.Drawing.Point(162, 227);
            this.cbOgrenciBolum.Name = "cbOgrenciBolum";
            this.cbOgrenciBolum.Size = new System.Drawing.Size(218, 28);
            this.cbOgrenciBolum.TabIndex = 6;
            // 
            // mtDogumTarihi
            // 
            this.mtDogumTarihi.BackColor = System.Drawing.Color.Honeydew;
            this.mtDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtDogumTarihi.Location = new System.Drawing.Point(162, 184);
            this.mtDogumTarihi.Mask = "00/00/0000";
            this.mtDogumTarihi.Name = "mtDogumTarihi";
            this.mtDogumTarihi.Size = new System.Drawing.Size(218, 26);
            this.mtDogumTarihi.TabIndex = 5;
            // 
            // mtVeliTelefon
            // 
            this.mtVeliTelefon.BackColor = System.Drawing.Color.Honeydew;
            this.mtVeliTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtVeliTelefon.Location = new System.Drawing.Point(162, 403);
            this.mtVeliTelefon.Mask = "(999) 000-0000";
            this.mtVeliTelefon.Name = "mtVeliTelefon";
            this.mtVeliTelefon.Size = new System.Drawing.Size(218, 26);
            this.mtVeliTelefon.TabIndex = 10;
            // 
            // mtOgrenciTelefon
            // 
            this.mtOgrenciTelefon.BackColor = System.Drawing.Color.Honeydew;
            this.mtOgrenciTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtOgrenciTelefon.Location = new System.Drawing.Point(162, 141);
            this.mtOgrenciTelefon.Mask = "(999) 000-0000";
            this.mtOgrenciTelefon.Name = "mtOgrenciTelefon";
            this.mtOgrenciTelefon.Size = new System.Drawing.Size(218, 26);
            this.mtOgrenciTelefon.TabIndex = 4;
            // 
            // mtTcNo
            // 
            this.mtTcNo.BackColor = System.Drawing.Color.Honeydew;
            this.mtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtTcNo.Location = new System.Drawing.Point(162, 98);
            this.mtTcNo.Mask = "00000000000";
            this.mtTcNo.Name = "mtTcNo";
            this.mtTcNo.Size = new System.Drawing.Size(218, 26);
            this.mtTcNo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(77, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Oda No :";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Honeydew;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(162, 272);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(218, 26);
            this.txtMail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(87, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "E-Mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Öğrenci Bölüm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(15, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Veli Telefon No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Doğum Tarihi  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Telefon No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Öğrenci TC No :";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.BackColor = System.Drawing.Color.Honeydew;
            this.txtOgrenciSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(162, 55);
            this.txtOgrenciSoyad.Multiline = true;
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(218, 26);
            this.txtOgrenciSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Öğrenci Soyad :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(50, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Veli Adres :";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.BackColor = System.Drawing.Color.Honeydew;
            this.txtOgrenciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciAd.Location = new System.Drawing.Point(162, 12);
            this.txtOgrenciAd.Multiline = true;
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(218, 26);
            this.txtOgrenciAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(37, 529);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 13);
            this.lblid.TabIndex = 47;
            this.lblid.Text = "0";
            this.lblid.Visible = false;
            // 
            // frmOgrenciKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 602);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnKaydet);
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
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOgrenciKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.frmOgrenciKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
    }
}


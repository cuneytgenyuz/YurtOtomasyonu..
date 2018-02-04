using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtProjesi
{
    public partial class frmOgrenciDüzenle : Form
    {
        public frmOgrenciDüzenle()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            txtMail.Clear();
            txtVeliAdSoyad.Clear();
            mtDogumTarihi.Clear();
            mtOgrenciTelefon.Clear();
            mtTcNo.Clear();
            mtVeliTelefon.Clear();
            rtVeliAdres.Clear();
            cbOdaNo.Text = "";
            cbOgrenciBolum.Text = "";


        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        public string id, ad, soyad, tc, tel, dTarihi, bolum, mail, odano, veliadsoyad, velitel, veliadres;

        private void btnSil_Click(object sender, EventArgs e)
        {
            int öid = Convert.ToInt32(txtOgrenciID.Text);
            kyt.ogrenciSil(öid, cbOdaNo.Text);
            temizle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int oid = Convert.ToInt32(txtOgrenciID.Text);
            kyt.ogrenciGuncelle(oid,txtOgrenciAd.Text, txtOgrenciSoyad.Text, mtTcNo.Text, mtOgrenciTelefon.Text, mtDogumTarihi.Text, cbOgrenciBolum.Text, txtMail.Text, cbOdaNo.Text, txtVeliAdSoyad.Text, mtVeliTelefon.Text, rtVeliAdres.Text);
        }

        private void frmOgrenciDüzenle_Load(object sender, EventArgs e)
        {
            txtOgrenciID.Text = id;
            txtOgrenciAd.Text = ad;
            txtOgrenciSoyad.Text = soyad;
            mtTcNo.Text = tc;
            mtOgrenciTelefon.Text = tel;
            mtDogumTarihi.Text = dTarihi;
            cbOgrenciBolum.Text = bolum;
            txtMail.Text = mail;
            cbOdaNo.Text = odano;
            txtVeliAdSoyad.Text = veliadsoyad;
            mtVeliTelefon.Text = velitel;
            rtVeliAdres.Text = veliadres;

            Bolumler blm = new Bolumler();
            blm.bolum(cbOgrenciBolum);

            Odalar odlr = new Odalar();
            odlr.oda(cbOdaNo);

        }
    }
}

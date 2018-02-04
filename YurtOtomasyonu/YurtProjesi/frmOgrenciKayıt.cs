using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtProjesi
{
    public partial class frmOgrenciKayıt : Form
    {
        public frmOgrenciKayıt()
        {
            InitializeComponent();
        }

         void temizle()
        {
            txtMail.Clear();
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            txtVeliAdSoyad.Clear();
            mtDogumTarihi.Clear();
            mtOgrenciTelefon.Clear();
            mtTcNo.Clear();
            mtVeliTelefon.Clear();
            rtVeliAdres.Clear();
            cbOdaNo.SelectedIndex = -1;
            cbOgrenciBolum.SelectedIndex = -1;

        }

        private void frmOgrenciKayıt_Load(object sender, EventArgs e)
        {
            Bolumler blm = new Bolumler();
            blm.bolum(cbOgrenciBolum);

            Odalar odlr = new Odalar();
            odlr.oda(cbOdaNo);

        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmAnaForm ana = new frmAnaForm();
            
            kyt.ogrenciKayıt(txtOgrenciAd.Text, txtOgrenciSoyad.Text, mtTcNo.Text, mtOgrenciTelefon.Text, mtDogumTarihi.Text, cbOgrenciBolum.Text, txtMail.Text, cbOdaNo.Text, txtVeliAdSoyad.Text, mtVeliTelefon.Text, rtVeliAdres.Text);

            kyt.BorcEkle(lblid.Text, txtOgrenciAd.Text, txtOgrenciSoyad.Text);

            kyt.odaDurum(cbOdaNo.Text);


        }
    }
}

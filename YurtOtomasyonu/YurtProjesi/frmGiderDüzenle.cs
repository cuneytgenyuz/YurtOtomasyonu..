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
    public partial class frmGiderDüzenle : Form
    {
        public frmGiderDüzenle()
        {
            InitializeComponent();
        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        public string elektrik, su, dogalgaz, internet, gıda, personel, diger,id;

        private void frmGiderDüzenle_Load(object sender, EventArgs e)
        {
            txtGiderId.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtInternet.Text = internet;
            txtGıda.Text = gıda;
            txtPersonel.Text = personel;
            txtDiger.Text = diger;
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            int Gid = Convert.ToInt32(txtGiderId.Text);
            kyt.giderGuncelle(Gid, txtElektrik.Text, txtSu.Text, txtDogalgaz.Text, txtInternet.Text, txtGıda.Text, txtPersonel.Text, txtDiger.Text);
        }

        
    }
}

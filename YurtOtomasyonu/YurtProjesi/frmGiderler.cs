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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtDiger.Clear();
            txtDogalgaz.Clear();
            txtElektrik.Clear();
            txtGıda.Clear();
            txtInternet.Clear();
            txtPersonel.Clear();
            txtSu.Clear();
            
        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kyt.giderler(txtElektrik.Text, txtSu.Text, txtDogalgaz.Text, txtInternet.Text, txtGıda.Text, txtPersonel.Text, txtDiger.Text);
            temizle();
        }
    }
}

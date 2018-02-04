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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            kyt.adminGiris(txtKullanici.Text, txtSifre.Text);
            this.Hide();
        }

        private void frmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

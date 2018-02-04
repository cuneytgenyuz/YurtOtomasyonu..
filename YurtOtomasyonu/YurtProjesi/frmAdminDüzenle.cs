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
    public partial class frmAdminDüzenle : Form
    {
        public frmAdminDüzenle()
        {
            InitializeComponent();
        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        private void btnEkle_Move(object sender, EventArgs e)
        {
           
        }

        private void btnEkle_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int yid= Convert.ToInt32(txtYöneticiID.Text);
            kyt.adminGuncelle(yid, txtKullaniciAd.Text, txtSifre.Text);
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.admin);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kyt.adminKayıt(txtKullaniciAd.Text, txtSifre.Text);
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.admin);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int yid = Convert.ToInt32(txtYöneticiID.Text);
            kyt.adminSil(yid);
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.admin);
        }

        private void frmGirisDüzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet8.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet8.admin);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad,id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            //sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYöneticiID.Text = id;
            txtKullaniciAd.Text = ad;
            //txtSifre.Text = sifre;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

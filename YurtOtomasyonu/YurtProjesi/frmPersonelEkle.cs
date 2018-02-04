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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet9.personeller' table. You can move, or remove it, as needed.
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.personeller);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, soyad, id,gorev;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtPersonelID.Text = id;
            txtPersonelAd.Text = ad;
            txtPersonelSoyad.Text = soyad;
            txtPersonelGorev.Text = gorev;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kyt.personelEkle(txtPersonelAd.Text, txtPersonelSoyad.Text, txtPersonelGorev.Text);
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.personeller);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(txtPersonelID.Text);
            kyt.personelGuncelle(pid, txtPersonelAd.Text, txtPersonelSoyad.Text, txtPersonelGorev.Text);
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.personeller);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(txtPersonelID.Text);
            kyt.personelSil(pid);
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet9.personeller);
        }
    }
}

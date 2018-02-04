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
    public partial class frmBolumEkle : Form
    {
        public frmBolumEkle()
        {
            InitializeComponent();
        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        private void Bölüm_Ekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet.bölümler' table. You can move, or remove it, as needed.
            this.bölümlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.bölümler);
            txtBolumId.Enabled = false;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, bolum;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolum = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumId.Text = id;
            txtBolumAd.Text = bolum;

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            kyt.bolumEkle(txtBolumAd.Text);
            this.bölümlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.bölümler);
        }

        private void btnEkle_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnEkle_Move(object sender, EventArgs e)
        {

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int Bid = Convert.ToInt32(txtBolumId.Text);
            kyt.bolumSil(Bid);
            this.bölümlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.bölümler);

        }

        private void btnDuzenle_Click_1(object sender, EventArgs e)
        {
            int bid = Convert.ToInt32(txtBolumId.Text);
            kyt.bolumGuncelle(bid, txtBolumAd.Text);
            this.bölümlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.bölümler);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id,bolum;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolum = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            

            txtBolumId.Text = id;
            txtBolumAd.Text = bolum;
            
        }
    }
}

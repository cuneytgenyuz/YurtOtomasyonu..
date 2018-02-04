using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtProjesi
{
    public partial class frmOgrenciListe : Form
    {
        public frmOgrenciListe()
        {
            InitializeComponent();
        }

        private void frmOgrenciListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet6.ögrenciler' table. You can move, or remove it, as needed.
            this.ögrencilerTableAdapter3.Fill(this.yurtOtomasyonuDataSet6.ögrenciler);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet5.ögrenciler' table. You can move, or remove it, as needed.
            this.ögrencilerTableAdapter2.Fill(this.yurtOtomasyonuDataSet5.ögrenciler);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet4.ögrenciler' table. You can move, or remove it, as needed.
            this.ögrencilerTableAdapter1.Fill(this.yurtOtomasyonuDataSet4.ögrenciler);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet3.ögrenciler' table. You can move, or remove it, as needed.
            this.ögrencilerTableAdapter.Fill(this.yurtOtomasyonuDataSet3.ögrenciler);

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frmOgrenciDüzenle frm = new frmOgrenciDüzenle();
            frm.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.tel = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.dTarihi = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frm.veliadsoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            frm.velitel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            frm.veliadres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            frm.Show();
            this.Hide();
        }
    }
}

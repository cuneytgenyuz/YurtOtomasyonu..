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
    public partial class frmGiderListe : Form
    {
        public frmGiderListe()
        {
            InitializeComponent();
        }

        private void frmGiderListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet7.giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonuDataSet7.giderler);

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frmGiderDüzenle frm = new frmGiderDüzenle();
            frm.id= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.gıda = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm.Show();
            this.Hide();
        }
    }
}

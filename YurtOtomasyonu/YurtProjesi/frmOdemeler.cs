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
    public partial class frmOdemeler : Form
    {
        public frmOdemeler()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtAdı.Clear();
            txtKalanBorc.Clear();
            txtOdenen.Clear();
            txtOdenenAy.Clear();
            txtSoyad.Clear();
        }

        private void frmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.borclar);

        }

        Genel gnl = new Genel();
        Kayıt kyt = new Kayıt();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalanBorc;

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalanBorc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtAdı.Text = ad;
            txtSoyad.Text = soyad;
            txtKalanBorc.Text = kalanBorc;
            txtOgrenciId.Text = id;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ödenen, kalan, yeniborc;
            ödenen = Convert.ToInt16(txtOdenen.Text);
            kalan = Convert.ToInt16(txtKalanBorc.Text);
            yeniborc = (kalan) - (ödenen); 
            txtKalanBorc.Text = yeniborc.ToString();

            int id = Convert.ToInt32(txtOgrenciId.Text);
            kyt.odemeler(id, txtKalanBorc.Text, txtOdenenAy.Text, txtOdenen.Text);
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.borclar);
            temizle();
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.borclar);


        }
    }
}

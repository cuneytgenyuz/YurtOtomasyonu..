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
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }


        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBolumEkle frm = new frmBolumEkle();
            frm.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiderListe frm = new frmGiderListe();
            frm.Show();
        }

        private void şifreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminDüzenle frm = new frmAdminDüzenle();
            frm.Show();
        }

        public string yenile()
        {
            object ad;
           ad = this.ögrencilerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.ögrenciler);
            return ad.ToString();
            
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet1.ögrenciler' table. You can move, or remove it, as needed.
            this.ögrencilerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.ögrenciler);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciKayıt frm = new frmOgrenciKayıt();
            frm.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciListe frm = new frmOgrenciListe();
            frm.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciListe frm = new frmOgrenciListe();
            frm.Show();
        }

        private void bölümDüzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBolumEkle frm = new frmBolumEkle();
            frm.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdemeler frm = new frmOdemeler();
            frm.Show();
        }

        private void giderEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGiderler frm = new frmGiderler();
            frm.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelirIstatistik frm = new frmGelirIstatistik();
            frm.Show();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotEkle frm = new frmNotEkle();
            frm.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program 18.11.2017'de Cüneyt Genyüz tarafından yapılmıştır.","Hakkımızda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

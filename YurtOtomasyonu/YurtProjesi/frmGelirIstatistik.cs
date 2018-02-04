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
    public partial class frmGelirIstatistik : Form
    {
        public frmGelirIstatistik()
        {
            InitializeComponent();
        }

        Genel gnl = new Genel();

        

        private void frmGelirIstatistik_Load(object sender, EventArgs e)
        {

            SqlCommand k = new SqlCommand("select ödemeAy, sum(ödemeMiktar) from kasa group by ödemeAy ", gnl.baglanti());
            SqlDataReader o = k.ExecuteReader();

            while (o.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(o[0],o[1]);
            }
            gnl.baglanti().Dispose();
            gnl.baglanti().Close();


            lblToplamOdenen.Text = "";
            lblAy.Text = "";

            SqlCommand kmt = new SqlCommand("select sum (ödemeMiktar) from kasa", gnl.baglanti());
            SqlDataReader oku = kmt.ExecuteReader();

            while (oku.Read())
            {
                lblPara.Text = oku[0].ToString() +" TL ";

            }

            SqlCommand komut = new SqlCommand("select distinct(ödemeAy) from kasa", gnl.baglanti());
            SqlDataReader oku1 = komut.ExecuteReader();

            while (oku1.Read())
            {
                cbAy.Items.Add(oku1[0].ToString());
            }

            gnl.baglanti().Dispose();
            gnl.baglanti().Close();

            
        }

        private void cbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAy.Text = cbAy.SelectedItem.ToString();

            SqlCommand kmt = new SqlCommand("select sum(ödemeMiktar) from kasa where ödemeAy=@p1", gnl.baglanti());
            kmt.Parameters.AddWithValue("@p1", cbAy.Text);
            SqlDataReader oku = kmt.ExecuteReader();

            while (oku.Read())
            {
                lblToplamOdenen.Text = oku[0].ToString();
                
            }
            gnl.baglanti().Dispose();
            gnl.baglanti().Close();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

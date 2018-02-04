using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtProjesi
{
    class Bolumler
    {
        Genel gnl = new Genel();

        public void bolum(ComboBox cb)
        {

            cb.Items.Clear();


            SqlCommand komut = new SqlCommand("select bolumAd from bölümler", gnl.baglanti());

            if (gnl.baglanti().State == ConnectionState.Closed)
            {
                gnl.baglanti().Open();
            }

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cb.Items.Add(oku[0].ToString());
            }

            oku.Close();
            gnl.baglanti().Dispose();
            gnl.baglanti().Close();
        }
    }
}

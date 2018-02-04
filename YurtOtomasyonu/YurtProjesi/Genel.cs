using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtProjesi
{
    public class Genel
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=USER-BILGISAYAR;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            //SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\YurtOtomasyonu.mdf'");
            baglan.Open();
            return baglan;
        }
    }
}

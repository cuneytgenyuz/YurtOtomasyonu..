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
    class Kayıt
    {
        Genel gnl = new Genel();

        public void ogrenciKayıt(string ogrenciAd, string ogrenciSoyad, string ogrenciTc, string ogrenciTelefon, string dogum, string ogrenciBolum, string ogrenciMail, string ogrenciOdaNo, string veliAdSoyad, string veliTelefon, string veliAdres)
        {
            SqlCommand cmdKayt = new SqlCommand("insert into ögrenciler values (@ad, @soyad, @tc, @tel, @dogum, @bolum, @mail, @oda, @veliad, @velitel, @veliadres)", gnl.baglanti());
            cmdKayt.Parameters.AddWithValue("@ad", ogrenciAd);
            cmdKayt.Parameters.AddWithValue("@soyad", ogrenciSoyad);
            cmdKayt.Parameters.AddWithValue("@tc", ogrenciTc);
            cmdKayt.Parameters.AddWithValue("@tel", ogrenciTelefon);
            cmdKayt.Parameters.AddWithValue("@dogum", dogum);
            cmdKayt.Parameters.AddWithValue("@bolum", ogrenciBolum);
            cmdKayt.Parameters.AddWithValue("@mail", ogrenciMail);
            cmdKayt.Parameters.AddWithValue("@oda", ogrenciOdaNo);
            cmdKayt.Parameters.AddWithValue("@veliad", veliAdSoyad);
            cmdKayt.Parameters.AddWithValue("@velitel", veliTelefon);
            cmdKayt.Parameters.AddWithValue("@veliadres", veliAdres);

            cmdKayt.ExecuteNonQuery();

        }

        public void ogrenciGuncelle(int id, string ogrenciAd, string ogrenciSoyad, string ogrenciTc, string ogrenciTelefon, string dogum, string ogrenciBolum, string ogrenciMail, string ogrenciOdaNo, string veliAdSoyad, string veliTelefon, string veliAdres)
        {
            try
            {

                SqlCommand komut = new SqlCommand("update ögrenciler set ögrenciAd=@p2,ögrenciSoyad=@p3,ögenciTc=@p4,ögrenciTelefon=@p5,ögrenciDogum=@p6,ögrenciBolum=@p7,ögrenciMail=@p8,ögrenciOdaNo=@p9,ögrenciVeli=@p10,ögrenciVeliTelefon=@p11,ögrenciVeliAdres=@p12 where ögrenciId=@p1", gnl.baglanti());

                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", ogrenciAd);
                komut.Parameters.AddWithValue("@p3", ogrenciSoyad);
                komut.Parameters.AddWithValue("@p4", ogrenciTc);
                komut.Parameters.AddWithValue("@p5", ogrenciTelefon);
                komut.Parameters.AddWithValue("@p6", dogum);
                komut.Parameters.AddWithValue("@p7", ogrenciBolum);
                komut.Parameters.AddWithValue("@p8", ogrenciMail);
                komut.Parameters.AddWithValue("@p9", ogrenciOdaNo);
                komut.Parameters.AddWithValue("@p10", veliAdSoyad);
                komut.Parameters.AddWithValue("@p11", veliTelefon);
                komut.Parameters.AddWithValue("@p12", veliAdres);

                komut.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("İşleminiz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void ogrenciSil(int öid,string odano)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from ögrenciler where ögrenciId=@p1", gnl.baglanti());
                komut.Parameters.AddWithValue("@p1", öid);
                komut.ExecuteNonQuery();
                SqlCommand kmt = new SqlCommand("update odalar set odaAktif=odaAktif-1 where odaNo=@p2", gnl.baglanti());
                kmt.Parameters.AddWithValue("@p2", odano);
                kmt.ExecuteNonQuery();
                
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
            }
        }

        public void BorcEkle(string id,string ad,string soyad)
        {
            SqlCommand cmdBorclar = new SqlCommand("insert into borclar (ögrenciId,ögrenciAd,ögrenciSoyad) values (@ögrenciID,@ögrenciad,@ögrencisoyad)", gnl.baglanti());
            cmdBorclar.Parameters.AddWithValue("@ögrenciID", id);
            cmdBorclar.Parameters.AddWithValue("@ögrenciad", ad);
            cmdBorclar.Parameters.AddWithValue("@ögrencisoyad", soyad);
            cmdBorclar.ExecuteNonQuery();
            gnl.baglanti().Dispose();
            gnl.baglanti().Close();
        }

        public void odaDurum(string oda)
        {
            SqlCommand cmdOda = new SqlCommand("update odalar set odaAktif=odaAktif+1 where odaNo=@oda", gnl.baglanti());
            cmdOda.Parameters.AddWithValue("@oda", oda);
            cmdOda.ExecuteNonQuery();
            gnl.baglanti().Dispose();
            gnl.baglanti().Close();
            
        }

        //public void b (string id)
        //{
        //    SqlCommand cmd = new SqlCommand("select ögrenciId from ögrenciler", gnl.baglanti());
        //    SqlDataReader oku = cmd.ExecuteReader();

        //    while (oku.Read())
        //    {
        //        id = oku[0].ToString();
        //    }
        //    gnl.baglanti().Dispose();
        //    gnl.baglanti().Close();
        //}

        public void adminKayıt(string kullaniciAd,string sifre)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut = new SqlCommand("insert into admin(yoneticiAd,yoneticiSifre) values(@p1,@p2)", gnl.baglanti());
                komut.Parameters.AddWithValue("@p1", kullaniciAd);
                komut.Parameters.AddWithValue("@p2", sifre);
                komut.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("Kayıt başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        public void adminGuncelle(int yid, string klnciAd, string sifre)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut2 = new SqlCommand("update admin set yoneticiAd=@p1,yoneticiSifre=@p3 where yoneticiId=@p2", gnl.baglanti());
                komut2.Parameters.AddWithValue("@p2",yid);
                komut2.Parameters.AddWithValue("@p1", klnciAd);
                komut2.Parameters.AddWithValue("@p3", sifre);
                komut2.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();

                MessageBox.Show("İşleminiz başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleşemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        public void adminSil(int yid)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut1 = new SqlCommand("delete from admin where yoneticiId=@p1", gnl.baglanti());
                komut1.Parameters.AddWithValue("@p1", yid);
                komut1.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("Silmek istediğinizden emin misiniz ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                


            }
            catch (Exception)
            {

                MessageBox.Show("İşlem gerçekleşemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void adminGiris(string ad, string sifre)
        {
            SqlCommand komut = new SqlCommand("select * from admin where yoneticiAd=@p1 and yoneticiSifre=@p2", gnl.baglanti());
            komut.Parameters.AddWithValue("@p1", ad);
            komut.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                frmAdminGiris giris = new frmAdminGiris();
                frmAnaForm frm = new frmAnaForm();
                giris.Hide();
                frm.Show();
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }

            gnl.baglanti().Dispose();
            gnl.baglanti().Close();
        }

        public void bolumEkle(string bolumAdi)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut = new SqlCommand("insert into bölümler(bolumAd) values(@bölümad)", gnl.baglanti());
                komut.Parameters.AddWithValue("@bölümAd", bolumAdi);
                komut.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("Kayıt başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        public void bolumGuncelle(int bid, string bAd)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut2 = new SqlCommand("update bölümler set bolumAd=@p1 where bolumId=@p2", gnl.baglanti());
                komut2.Parameters.AddWithValue("@p2",bid);
                komut2.Parameters.AddWithValue("@p1", bAd);
                komut2.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                
                MessageBox.Show("İşleminiz başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleşemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        public void bolumSil(int Bid)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut1 = new SqlCommand("delete from bölümler where bolumId=@p1", gnl.baglanti());
                komut1.Parameters.AddWithValue("@p1", Bid);
                komut1.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("Silmek istediğinizden emin misiniz ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
               

            }
            catch (Exception)
            {

                MessageBox.Show("İşlem gerçekleşemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void giderGuncelle(int Gid,string elektrik,string su,string dgaz,string net,string gıda,string prsnl,string digerler)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update giderler set elektrikFatura=@p1,suFatura=@p2,dogalgazFatura=@p3,internetFatura=@p4,gıdaTutar=@p5,personelTutar=@p6,diger=@p7 where odemeId=@p8 ", gnl.baglanti());
                komut.Parameters.AddWithValue("@p8", Gid);
                komut.Parameters.AddWithValue("@p1", elektrik);
                komut.Parameters.AddWithValue("@p2", su);
                komut.Parameters.AddWithValue("@p3", dgaz);
                komut.Parameters.AddWithValue("@p4", net);
                komut.Parameters.AddWithValue("@p5", gıda);
                komut.Parameters.AddWithValue("@p6", prsnl);
                komut.Parameters.AddWithValue("@p7", digerler);

                komut.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("İşleminiz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void giderler(string elektrik, string su, string dgaz, string net, string gıda, string prsnl, string digerler)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into giderler (elektrikFatura,suFatura,dogalgazFatura,internetFatura,gıdaTutar,personelTutar,diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", gnl.baglanti());
                komut.Parameters.AddWithValue("@p1", elektrik);
                komut.Parameters.AddWithValue("@p2", su);
                komut.Parameters.AddWithValue("@p3", dgaz);
                komut.Parameters.AddWithValue("@p4", net);
                komut.Parameters.AddWithValue("@p5", gıda);
                komut.Parameters.AddWithValue("@p6", prsnl);
                komut.Parameters.AddWithValue("@p7", digerler);
                komut.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("İşlem başarıyla kayıt edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        public void odemeler(int id,string kalanBorc,string oAy,string odenen)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update borclar set ögrenciBorc=@p1 where ögrenciId=@p2", gnl.baglanti());
                komut.Parameters.AddWithValue("@p2", id);
                komut.Parameters.AddWithValue("@p1", kalanBorc);
                komut.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                
                MessageBox.Show("Borç Ödendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            SqlCommand kmt = new SqlCommand("insert into kasa (ödemeAy,ödemeMiktar) values (@k1,@k2)", gnl.baglanti());
            kmt.Parameters.AddWithValue("@k1", oAy);
            kmt.Parameters.AddWithValue("@k2", odenen);
            kmt.ExecuteNonQuery();
            gnl.baglanti().Dispose();
            gnl.baglanti().Close();
        }

        public void personelEkle(string ad,string soyad,string gorev)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut = new SqlCommand("insert into personeller(personelAd,personelSoyad,personelDepartman) values(@p1,@p2,@p3)", gnl.baglanti());
                komut.Parameters.AddWithValue("@p1", ad);
                komut.Parameters.AddWithValue("@p2", soyad);
                komut.Parameters.AddWithValue("@p3", gorev);
                komut.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("Kayıt başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        public void personelGuncelle(int id,string ad,string soyad,string gorev)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut2 = new SqlCommand("update personeller set personelAd=@p1,personelSoyad=@p3,personelDepartman=@p4 where personelId=@p2", gnl.baglanti());
                komut2.Parameters.AddWithValue("@p2", id);
                komut2.Parameters.AddWithValue("@p1", ad);
                komut2.Parameters.AddWithValue("@p3", soyad);
                komut2.Parameters.AddWithValue("@p4", gorev);
                komut2.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();

                MessageBox.Show("İşleminiz başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleşemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        public void personelSil(int id)
        {
            try
            {
                if (gnl.baglanti().State == ConnectionState.Closed)
                {
                    gnl.baglanti().Open();
                }

                SqlCommand komut1 = new SqlCommand("delete from personeller where personelId=@p1", gnl.baglanti());
                komut1.Parameters.AddWithValue("@p1", id);
                komut1.ExecuteNonQuery();
                gnl.baglanti().Dispose();
                gnl.baglanti().Close();
                MessageBox.Show("Silmek istediğinizden emin misiniz ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                


            }
            catch (Exception)
            {

                MessageBox.Show("İşlem gerçekleşemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }

}


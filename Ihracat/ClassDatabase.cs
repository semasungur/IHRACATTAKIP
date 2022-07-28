using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ihracat
{
    public static class ClassDatabase
    {
        public static string cs()
        {
            string cs = ConfigurationManager.ConnectionStrings["Ihr"].ConnectionString;
            return cs;
        }
        public static DataTable dtCariListe()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Cari";
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception EX)
            {
                0.ToString();
            }
            return dt;
        }
        public static DataTable dtSiparisListe()
        {
            DataTable dt = new DataTable();
            string sql = "select Sip_No,Sip_Tarih,Cari_Isim  from Siparis sip, Cari car where sip.Cari_ID=car.Cari_ID";
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception EX)
            {
                0.ToString();
            }
            return dt;
        }
        public static DataTable dtSiparisListe1()
        {
            DataTable dt = new DataTable();
            string sql = "select Sip_No,Sip_Tarih,Cari_Isim,Kont_Adet,Kont_No,Lojistik_Firma,Teslimat_Sekli,Navlun from Siparis sip, Cari car where sip.Cari_ID=car.Cari_ID";
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception EX)
            {
                0.ToString();
            }
            return dt;
        }
        public static DataTable dtSiparisListe2()
        {
            DataTable dt = new DataTable();
            string sql = "select Sip_No,Sip_Tarih,Cari_Isim,Lojistik_Firma,Teslimat_Sekli,Navlun,Mus,Diib,Nak,Tev,Tnt,Kom,Note from Siparis sip, Cari car where sip.Cari_ID=car.Cari_ID";
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                conn.Open();
                da.Fill(dt);
                da.Dispose();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception EX)
            {
                0.ToString();
            }
            return dt;
        }
        public static string insCariEkle(string Cari_Isim, string Cari_Ulke, string Cari_Yetkili)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlCommand cmd = new SqlCommand("INSERT INTO Cari (Cari_Isim,Cari_Ulke,Cari_Yetkili) VALUES (@Cari_Isim,@Cari_Ulke,@Cari_Yetkili);", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Cari_Isim", Cari_Isim);
                cmd.Parameters.AddWithValue("@Cari_Ulke", Cari_Ulke);
                cmd.Parameters.AddWithValue("@Cari_Yetkili", Cari_Yetkili);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return "basarili"  ;  
            }
            catch (Exception ex)
            {
                return "İşlem yapılmadı.Hata detayı:" + ex.Message;
            }
        }
        public static string insSiparisEkle(string Sip_No, DateTime Sip_Tarih, int Cari_Id, string Termin)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlCommand cmd = new SqlCommand("INSERT INTO Siparis (Sip_No,Sip_Tarih,Cari_Id,Termin) VALUES (@Sip_No,@Sip_Tarih,@Cari_Id,@Termin);", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Sip_No", Sip_No);
                cmd.Parameters.AddWithValue("@Sip_Tarih", Sip_Tarih);
                cmd.Parameters.AddWithValue("@Cari_Id", Cari_Id);
                cmd.Parameters.AddWithValue("@Termin", Termin);
               
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return "basarili";
            }
            catch (Exception ex)
            {
                return "İşlem yapılmadı.Hata detayı:" + ex.Message;
            }
        }
        public static string updCariGuncelle(string Cari_Isim, string Cari_Ulke, string Cari_Yetkili)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlCommand cmd = new SqlCommand("UPDATE Cari SET Cari_Ulke=@Cari_Ulke,Cari_Yetkili=@Cari_Yetkili WHERE Cari_Isim=@Cari_Isim ;", conn);
                conn.Open();
                
                cmd.Parameters.AddWithValue("@Cari_Isim", Cari_Isim);
                cmd.Parameters.AddWithValue("@Cari_Ulke", Cari_Ulke);
                cmd.Parameters.AddWithValue("@Cari_Yetkili", Cari_Yetkili);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return "basarili";
            }
            catch (Exception ex)
            {
                return "İşlem yapılmadı.Hata detayı:" + ex.Message;
            }

        }
        public static string updSevkGuncelle(string Sip_No, string Kont_Adet,  string Kont_No, string Lojistik_Firma, string Teslimat_Sekli,string Navlun)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlCommand cmd = new SqlCommand("UPDATE Siparis SET Kont_Adet=@Kont_Adet,Kont_No=@Kont_No,Lojistik_Firma=@Lojistik_Firma,Teslimat_Sekli=@Teslimat_Sekli,Navlun=@Navlun WHERE Sip_No=@Sip_No ;", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Sip_No", Sip_No);
                cmd.Parameters.AddWithValue("@Kont_Adet", Kont_Adet);
                cmd.Parameters.AddWithValue("@Kont_No", Kont_No);
                cmd.Parameters.AddWithValue("@Lojistik_Firma", Lojistik_Firma);
                cmd.Parameters.AddWithValue("@Teslimat_Sekli", Teslimat_Sekli);
                cmd.Parameters.AddWithValue("@Navlun", Navlun);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return "basarili";
            }
            catch (Exception ex)
            {
                return "İşlem yapılmadı.Hata detayı:" + ex.Message;
            }

        }
        public static string updYonGuncelle(string Sip_No, string Mus, string Diib, string Nak, string Tev, string Tnt,string Kom,string Note)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cs());
                SqlCommand cmd = new SqlCommand("UPDATE Siparis SET  Mus=@Mus, Diib=@Diib, Nak=@Nak, Tev=@Tev, Tnt=@Tnt, Kom=@Kom, Note=@Note WHERE Sip_No=@Sip_No ;", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Sip_No", Sip_No);
                cmd.Parameters.AddWithValue("@Mus", Mus);
                cmd.Parameters.AddWithValue("@Diib", Diib);
                cmd.Parameters.AddWithValue("@Nak", Nak);
                cmd.Parameters.AddWithValue("@Tev", Tev);
                cmd.Parameters.AddWithValue("@Tnt", Tnt);
                cmd.Parameters.AddWithValue("@Kom", Kom);
                cmd.Parameters.AddWithValue("@Note", Note);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return "basarili";
            }
            catch (Exception ex)
            {
                return "İşlem yapılmadı.Hata detayı:" + ex.Message;
            }

        }



    }
}

using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.DataAccessLayer
{
   public class OgrenciDAL
    {
        private DBHelper dbHelper;
        public OgrenciDAL()
        {
            dbHelper = new DBHelper();
        }


        public int GirisKontrolu(string kullaniciAD, string parola)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Ogrenci WHERE ogrenciKullaniciAd = @p1 and ogrenciSifre = @p2";
            cmd.Parameters.AddWithValue("@p1", kullaniciAD);
            cmd.Parameters.AddWithValue("@p2", parola);
            SqlDataReader dr = cmd.ExecuteReader();

            int ogrenciID;
            if (dr.Read())
            {

                ogrenciID = int.Parse(dr["ogrenciID"].ToString());
            }

            else ogrenciID = -1;

            

            return ogrenciID;
        }

        public List<OgrenciEntity> OgrencileriGetir()
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Ogrenci";
            List<OgrenciEntity> ogrenciler = new List<OgrenciEntity>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                OgrenciEntity ogrenci = new OgrenciEntity();
                ogrenci.ogrenciID = int.Parse(dr["ogrenciID"].ToString());
                ogrenci.ogrenciAd = dr["ogrenciAd"].ToString();
                ogrenci.ogrenciSoyad = dr["ogrenciSoyad"].ToString();
                ogrenci.ogrenciKullaniciAd = dr["ogrenciKullaniciAd"].ToString();
                ogrenci.ogrenciSifre = dr["ogrenciSifre"].ToString();

                ogrenciler.Add(ogrenci);
            }
            return ogrenciler;

        }

    }
}

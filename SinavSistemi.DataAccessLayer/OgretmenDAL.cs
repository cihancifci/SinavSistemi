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
   public class OgretmenDAL
    {
        private DBHelper dbHelper;
        public OgretmenDAL()
        {
            dbHelper = new DBHelper();
        }

        public DataTable GetAllItems(OgretmenEntity ogretmen)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Ogretmen";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool GirisKontrolu(string kullaniciAD, string parola)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Ogretmen WHERE ogretmenKullaniciAd = @p1 and ogretmenSifre = @p2";
            cmd.Parameters.AddWithValue("@p1", kullaniciAD);
            cmd.Parameters.AddWithValue("@p2", parola);
            SqlDataReader dr = cmd.ExecuteReader();

            bool kontrol;
            if (dr.Read())
            {

                kontrol = true;
            }

            else kontrol = false;



            return kontrol;
        }
    }
}

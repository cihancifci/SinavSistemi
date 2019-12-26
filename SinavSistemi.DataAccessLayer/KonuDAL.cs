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
   public class KonuDAL
    {
        private DBHelper dbHelper;
        public KonuDAL()
        {
            dbHelper = new DBHelper();
        }

        
        public List<KonuEntity> KonuGetir()
        {
            

            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT konuAdi FROM tbl_Konu";
            cmd.ExecuteNonQuery();

            List<KonuEntity> konular = new List<KonuEntity>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KonuEntity konu = new KonuEntity();
                konu.konuAdi = dr["konuAdi"].ToString();

                konular.Add(konu);
            }
            return konular;
        }

        public void KonuEkle(KonuEntity konu)
        {
            
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "INSERT INTO tbl_Konu(konuAdi) VALUES(@p1)";
            cmd.Parameters.AddWithValue("@p1", konu.konuAdi);
           
            cmd.ExecuteNonQuery();
        }

    }
}

using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.DataAccessLayer
{
    public class BasariDAL
    {
        private DBHelper dbHelper;
        public BasariDAL()
        {
            dbHelper = new DBHelper();
        }

        public SqlDataReader BasariGetir(int ogrenciID,int sinavNo)
        {


            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "OgrenciBasariGetir @ogrenciID = @p1, @sinavNo = @p2 ";
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            cmd.Parameters.AddWithValue("@p2", sinavNo);
            cmd.ExecuteNonQuery();

            List<BasariEntity> basarilar = new List<BasariEntity>();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }


        public int SinavSayisiGetir(int ogrenciID)
        {
            int sinavSayisi = 0;
            SqlCommand cmd1 = dbHelper.GetSqlCommand();
            cmd1.CommandText = "select count(distinct cevapSinavID)  as 'sinavSayi' from tbl_Cevap where cevapOgrenciID = @p1";
            cmd1.Parameters.AddWithValue("@p1", ogrenciID);
            cmd1.ExecuteNonQuery();

            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                sinavSayisi = int.Parse(dr["sinavSayi"].ToString());
            }
            return sinavSayisi;

        }

        public SqlDataReader SinavOrtalamalariGetir(int ogrenciID)
        {


            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM OrtalamalariGetir(@p1)";
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            cmd.ExecuteNonQuery();

            List<BasariEntity> basarilar = new List<BasariEntity>();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }


    }
}
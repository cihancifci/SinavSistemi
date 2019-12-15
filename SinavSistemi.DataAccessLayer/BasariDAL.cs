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
    }
}
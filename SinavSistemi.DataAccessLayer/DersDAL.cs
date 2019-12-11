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
   public class DersDAL
    {
        private DBHelper dbHelper;
        public DersDAL()
        {
            dbHelper = new DBHelper();
        }

        public DataTable GetAllItems(DersEntity ders)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Ders";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

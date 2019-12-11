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
   public class SinavDAL
    {
        private DBHelper dbHelper;
        public SinavDAL()
        {
            dbHelper = new DBHelper();
        }

        public DataTable GetAllItems(SinavEntity sinav)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Sinav";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

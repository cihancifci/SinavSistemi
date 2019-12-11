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
   public class AdminDAL
    {
        private DBHelper dbHelper;
        public AdminDAL()
        {
            dbHelper = new DBHelper();
        }

        public DataTable GetAllItems(AdminEntity admin)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Admin";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

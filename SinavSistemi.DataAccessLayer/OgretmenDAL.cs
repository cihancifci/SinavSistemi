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
    }
}

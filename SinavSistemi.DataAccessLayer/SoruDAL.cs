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
   public class SoruDAL
    {
        private DBHelper dbHelper;
        public SoruDAL()
        {
            dbHelper = new DBHelper();
        }

        public DataTable GetAllItems(SoruEntity soru)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM tbl_Soru";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void SoruEkle(SoruEntity soru)
        {
            
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "INSERT INTO tbl_Soru(soruOnBilgi,soruIcerik,soruA,soruB,soruC,soruD,soruDogruCevap,soruKonuID,soruResim) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
            cmd.Parameters.AddWithValue("@p1", soru.soruOnBilgi);
            cmd.Parameters.AddWithValue("@p2", soru.soruIcerik);
            cmd.Parameters.AddWithValue("@p3", soru.soruA);
            cmd.Parameters.AddWithValue("@p4", soru.soruB);
            cmd.Parameters.AddWithValue("@p5", soru.soruC);
            cmd.Parameters.AddWithValue("@p6", soru.soruD);
            cmd.Parameters.AddWithValue("@p7", soru.soruDogruCevap);
            cmd.Parameters.AddWithValue("@p8", soru.soruKonuID);
            cmd.Parameters.AddWithValue("@p9", soru.resimYolu);
            cmd.ExecuteNonQuery();
        }

        public List<SoruEntity> SorularıGetir(int ogrenciID)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "EXEC Sinav @ogrenciID = @p1  SELECT * FROM tbl_Sorulan ";
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            List<SoruEntity> sorular = new List<SoruEntity>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SoruEntity soru = new SoruEntity();
                soru.soruID = int.Parse(dr["soruID"].ToString());
                soru.soruOnBilgi = dr["soruOnBilgi"].ToString();
                soru.soruIcerik = dr["soruIcerik"].ToString();
                soru.soruA = dr["soruA"].ToString();
                soru.soruB = dr["soruB"].ToString();
                soru.soruC = dr["soruC"].ToString();
                soru.soruD = dr["soruD"].ToString();
                soru.soruDogruCevap = dr["soruDogruCevap"].ToString();
                soru.soruKonuID = int.Parse(dr["soruKonuID"].ToString()) ;
                soru.resimYolu = dr["soruResim"].ToString();
                sorular.Add(soru);
            }
            return sorular;

        }
    }
}

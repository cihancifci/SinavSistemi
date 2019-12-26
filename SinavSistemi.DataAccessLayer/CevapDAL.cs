using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.DataAccessLayer
{
    public class CevapDAL
    {
        DBHelper dBHelper;
        public CevapDAL()
        {
            dBHelper = new DBHelper();
        }


        public void CevaplarıEkle(List<CevapEntity> cevaplar)
        {
            int sinavID=0;
            SqlCommand cmd1 = dBHelper.GetSqlCommand();
            cmd1.CommandText = "select count(distinct cevapSinavID)  as 'sayi' from tbl_Cevap where cevapOgrenciID = @p1";
            cmd1.Parameters.AddWithValue("@p1", cevaplar[1].cevapOgrenciID);
            cmd1.ExecuteNonQuery();

            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                sinavID = int.Parse(dr["sayi"].ToString()) +1;
            }


                for (int i = 0; i < cevaplar.Count; i++)
            {
                SqlCommand cmd = dBHelper.GetSqlCommand();
                cmd.CommandText = "INSERT INTO tbl_Cevap(cevapSoruID,cevapOgrenciID,cevapSinavID,cevapKonuID,dogruYanlisKontrol) VALUES(@p1,@p2,@p3,@p4,@p5)";
                cmd.Parameters.AddWithValue("@p1", cevaplar[i].cevapSoruID);
                cmd.Parameters.AddWithValue("@p2", cevaplar[i].cevapOgrenciID);
                cmd.Parameters.AddWithValue("@p3", sinavID);
                cmd.Parameters.AddWithValue("@p4", cevaplar[i].cevapKonuID);
                cmd.Parameters.AddWithValue("@p5", cevaplar[i].dogruYanlisKontrol);
                cmd.ExecuteNonQuery();
            }
            SqlCommand cmd2 = dBHelper.GetSqlCommand();
            cmd2.CommandText = "EXEC BasariOraniniHesapla @p1 , @p2";
            cmd2.Parameters.AddWithValue("@p1", cevaplar[1].cevapOgrenciID);
            cmd2.Parameters.AddWithValue("@p2", sinavID);

            cmd2.ExecuteNonQuery();

        }
        //public int sinavSayiHesapla()
        //{
        //    int sinavID;
        //    SqlCommand cmd1 = dBHelper.GetSqlCommand();
        //    cmd1.CommandText = "select count(distinct sinavID) from tbl_Basari";
        //    return sinavID = cmd1.ExecuteNonQuery();

        //}
    }
}

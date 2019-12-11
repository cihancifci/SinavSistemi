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
            for (int i = 0; i < cevaplar.Count; i++)
            {
                SqlCommand cmd = dBHelper.GetSqlCommand();
                cmd.CommandText = "INSERT INTO tbl_Cevap(cevapSoruID,cevapOgrenciID,cevapSinavID,cevapKonuID,dogruYanlisKontrol) VALUES(@p1,@p2,@p3,@p4,@p5)";
                cmd.Parameters.AddWithValue("@p1", cevaplar[i].cevapSoruID);
                cmd.Parameters.AddWithValue("@p2", cevaplar[i].cevapOgrenciID);
                cmd.Parameters.AddWithValue("@p3", cevaplar[i].cevapSinavID);
                cmd.Parameters.AddWithValue("@p4", cevaplar[i].cevapKonuID);
                cmd.Parameters.AddWithValue("@p5", cevaplar[i].dogruYanlisKontrol);
                cmd.ExecuteNonQuery();
            }
            
        }
    }
}

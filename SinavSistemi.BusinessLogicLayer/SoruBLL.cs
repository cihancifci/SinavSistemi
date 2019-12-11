using SinavSistemi.DataAccessLayer;
using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.BusinessLogicLayer
{
   public class SoruBLL
    {
        SoruDAL soruDAL;
        public SoruBLL()
        {
            soruDAL = new SoruDAL();
        }
        public DataTable GetAllItems(SoruEntity soru)
        {
            return soruDAL.GetAllItems(soru);
        }
        public void SoruEkle(SoruEntity soru)
        {
             soruDAL.SoruEkle(soru);
        }

        public List<SoruEntity> SorularıGetir()
        {
            return soruDAL.SorularıGetir();
        }
    }
}

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
    public class KonuBLL
    {
        KonuDAL konuDAL;
        public KonuBLL()
        {
            konuDAL = new KonuDAL();
        }
        public DataTable GetAllItems(KonuEntity konu)
        {
            return konuDAL.GetAllItems(konu);
        }
        public List<KonuEntity> KonuGetir()
        {
            return konuDAL.KonuGetir();
        }

        public void KonuEkle(KonuEntity konu)
        {
            konuDAL.KonuEkle(konu);
        }
        }
}

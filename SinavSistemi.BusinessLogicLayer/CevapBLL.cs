using SinavSistemi.DataAccessLayer;
using SinavSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.BusinessLogicLayer
{
    public class CevapBLL
    {
        CevapDAL cevapDAL;

        public CevapBLL()
        {
            cevapDAL = new CevapDAL();
        }

        public void CevaplarıEkle(List<CevapEntity> cevaplar)
        {
            cevapDAL.CevaplarıEkle(cevaplar);
        }
    }
}

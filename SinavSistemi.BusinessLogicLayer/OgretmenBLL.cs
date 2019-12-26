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
   public class OgretmenBLL
    {
        OgretmenDAL ogretmenDAL;
        public OgretmenBLL()
        {
            ogretmenDAL = new OgretmenDAL();
        }
        public DataTable GetAllItems(OgretmenEntity ogretmen)
        {
            return ogretmenDAL.GetAllItems(ogretmen);
        }

        public bool GirisKontrolu(string kullaniciAd, string parola)
        {

            return ogretmenDAL.GirisKontrolu(kullaniciAd, parola);
        }
    }
}

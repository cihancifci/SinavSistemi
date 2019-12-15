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
    public class OgrenciBLL
    {
        OgrenciDAL ogrenciDAL;
        public OgrenciBLL()
        {
            ogrenciDAL = new OgrenciDAL();
        }
        public DataTable GetAllItems(OgrenciEntity ogrenci)
        {
            return ogrenciDAL.GetAllItems(ogrenci);
        }

        public int GirisKontrolu(string kullaniciAd, string parola)
        {
            return ogrenciDAL.GirisKontrolu(kullaniciAd,parola);
        }
    }
}

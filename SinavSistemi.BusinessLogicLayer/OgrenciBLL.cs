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
        public List<OgrenciEntity> OgrenciGetir()
        {
            return ogrenciDAL.OgrencileriGetir();
        }

        public int GirisKontrolu(string kullaniciAd, string parola)
        {
            return ogrenciDAL.GirisKontrolu(kullaniciAd,parola);
        }
    }
}

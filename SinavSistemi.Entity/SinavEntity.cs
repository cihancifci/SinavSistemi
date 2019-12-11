using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Entity
{
   public class SinavEntity
    {
        public int sinavID { get; set; }
        public string sinavAd { get; set; }
        public int sinavDersID { get; set; }
        public int sinavOgretmenID { get; set; }
        public DateTime sinavTarih { get; set; }


    }
}

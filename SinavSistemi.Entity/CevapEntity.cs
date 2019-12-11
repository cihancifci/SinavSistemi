using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Entity
{
    public class CevapEntity
    {
        public int cevapID { get; set; }
        public int cevapSoruID { get; set; }
        public int cevapOgrenciID { get; set; }
        public int cevapSinavID { get; set; }
        public int cevapKonuID { get; set; }
        public int dogruYanlisKontrol { get; set; }
        
    }
}

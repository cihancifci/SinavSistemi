using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi.Entity
{
   public class SoruEntity
    {
        public int soruID { get; set; }
        public int soruKonuID { get; set; }
        public int soruDersID { get; set; }
        public int soruSinavID { get; set; }
        public string soruOnBilgi { get; set; }
        public int soruNumara { get; set; }
        public string soruIcerik { get; set; }
        public string soruA { get; set; }
        public string soruB { get; set; }
        public string soruC { get; set; }
        public string soruD { get; set; }
        public string soruDogruCevap { get; set; }
        public string resimYolu { get; set; }

    }
}

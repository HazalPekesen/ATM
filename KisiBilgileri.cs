using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class KisiBilgileri
    {
        public string isim { get; set; }
        public string sifre { get; set; }
        public int TC { get; set; }
        public int hesapNo { get; set; }
        public int cüzdan { get; set; }

        public KisiBilgileri(string isim, string sifre, int cüzdan)
        {
            this.isim = isim;
            this.sifre = sifre;
            this.cüzdan = cüzdan;
        }
        public KisiBilgileri()
        {

        }
    }
}

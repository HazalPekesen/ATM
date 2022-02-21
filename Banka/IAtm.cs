using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public interface IAtm
    {
        public int AtmID { get; set; }
        public double AtmKasa { get; set; }

        public void AtmAnasayfa(Kisi kisi);
        public void AtmIslemYonet(Kisi kisi, int deger);
        public bool ParaYatir(Kisi kisi);
        public bool ParaCek(Kisi kisi);
     
        public void paraTransferi(Kisi kisi);
        
        public double DovizAl(Kisi kisi);

    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public abstract class AtmGirisi
    {
        public Kisi girisKontrol(Kisi kisi, string deger)
        {
            foreach (var item in kisi.GetKisis())
            {
                if (deger.Length == 4)
                {
                    if (item.sifre == deger)
                    {
                        kisi = item;
                        kisi.kisiGiris = true;
                        return kisi;
                    }
                    else
                    {
                        return kisi;
                    }
                }
                else if (deger.Length == 11)
                {
                    if (item.TC == deger)
                    {
                        kisi = item;
                        kisi.kisiGiris = true;
                        return kisi;
                    }
                    else
                    {
                        return kisi;
                    }
                }
            }
            return kisi;
        }

    }
}

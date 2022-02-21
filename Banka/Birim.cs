using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Birim
    {
        public double euro { get; set; } = 15.45;
        public double Dolar { get; set; } = 13.65;
        public enum ParaBirimi
        {
            TürkLirasi=1,
            Dolar,
            Euro,
        }
        public static string enumtoStr(Enum e,Kisi kisi,string a)
        {
            Birim.ParaBirimi x = (Birim.ParaBirimi)Enum.Parse(typeof(Birim.ParaBirimi), a);
            return Enum.GetName(x);
        }
        public double paraCevir(double para, string paraBirimi, int enumIndex)
        {
            ParaBirimi e = (ParaBirimi)enumIndex;
            ParaBirimi gecerliBirim = (ParaBirimi)Enum.Parse(typeof(ParaBirimi), paraBirimi);
            switch (gecerliBirim)
            {
                case ParaBirimi.TürkLirasi:
                    if (gecerliBirim == e)
                    {
                        return para;
                    }
                    else if (((int)e) ==2)
                    {
                        para /= Dolar;
                        return para;

                    }
                    else if (((int)e) == 3)
                    {
                        para /= euro;
                        return para;
                    }
                    break;
                case ParaBirimi.Dolar:
                    if (gecerliBirim == e)
                    {
                        return para;
                    }
                    else if (((int)e) == 1)
                    {
                        para *= Dolar;
                        return para;

                    }
                    break;
                case ParaBirimi.Euro:
                    if (gecerliBirim == e)
                    {
                        return para;
                    }
                    else if (((int)e) == 1)
                    {
                        para *= euro;
                        return para;

                    }
                    break;
                default:
                    
                    break;
            }
            return para;

        }
    }
}

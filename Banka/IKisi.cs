using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public interface IKisi
    {
        public int KisiID { get; set; }
        public string TC { get; set; }
        public string KisiIsim { get; set; }
        public double Para { get; set; }
        public bool kisiGiris { get; set; }
        public string sifre { get; set; }
        public string paraBirimi { get; set; }
        public Kisi GetKisi(Kisi kisi);
        public List<Kisi> GetKisis();
        public bool paraDüs(double miktar);
        public void paraEkle(double miktar);
        public List<string> getKayit();
        public void kayitYap(string kayit);
        public bool Transfer(string gönderecentc, string tc, double miktar);

}


}

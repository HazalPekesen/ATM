using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Kisi : IKisi
    {
        static List<Kisi> kisiList = new List<Kisi>()
        {
            new Kisi(1,"12345678901","1234","Kerem",300,"TürkLirasi"),
            new Kisi(2, "12345678902","5939", "Mustafa", 30,"Dolar"),
            new Kisi(3, "12345678903","5583", "Ege", 60,"Euro")
        };
        public List<string> islemKaydi = new List<string>();
        public int KisiID { get; set; }
        public string TC { get; set; }
        public string KisiIsim { get; set; }
        public double Para { get; set; }
        public bool kisiGiris { get; set; } = false;
        public string sifre { get; set; }
        public string paraBirimi { get; set; }
        public Kisi(int KisiID, string TC,string sifre, string KisiIsim, double Para,string paraBirimi)
        {
            this.KisiID = KisiID;
            this.TC = TC;
            this.KisiIsim = KisiIsim;
            this.Para = Para;
            this.sifre = sifre;
            this.paraBirimi = paraBirimi;
        }
        public Kisi()
        {

        }
        public List<Kisi> GetKisis()
        {
            return kisiList;
        }
        public Kisi GetKisi(Kisi kisi)
        {
            foreach (var item in kisiList)
            {
                if (item==kisi)
                {
                    return kisi;
                }
            }
            return null;
        }
        
        public bool paraDüs(double miktar)
        {
            Para -= miktar;
            if (Para<0)
            {
                Para += miktar;
                return false;
            }
            else
            {
                return true;
            }
        }
        public void paraEkle(double miktar)
        {
            Para += miktar;
        }
        public List<string> getKayit()
        {
            return islemKaydi;
        }
        public void kayitYap(string kayit)
        {

            int i= islemKaydi.Count;
            islemKaydi.Add(i+" "+kayit);
        }
        public bool Transfer(string gönderecentc,string tc,double miktar)
        {
            if (tc == gönderecentc)
            {
                return false;
            }
            Kisi kisi2 = new Kisi();
            foreach (var item in kisiList)
            {
                if (item.TC==tc)
                {
                    item.paraEkle(miktar);
                    kisi2.kayitYap("Hesabınıza " + gönderecentc + " Tarafından " + miktar + " TL havale yapılmıştır.");
                    return true;
                }
            }
            return false;
        }
    }
}

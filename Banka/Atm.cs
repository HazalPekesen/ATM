using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Atm : AtmGirisi, IAtm
    {
       
        public double AtmKasa { get; set; } = 1000;
        public int AtmID { get; set; }

        public void AtmAnasayfa(Kisi kisi)
        {
            int deger = 0;
            do
            {
                try
                {
                    Console.WriteLine("\t\t\t\tİşlem Giriniz");
                    Console.Write("Para Yatırmak için 1\t\t\t\t\t\tPara Çekmek için 2\nİşlem Kaydı için 3\t\t\t\t\t\tPara Transferi için 4\nDöviz İşlemleri için 5\n");
                    deger = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                AtmIslemYonet(kisi, deger);
            } while (deger != 0);

            
        }
        public void AtmIslemYonet(Kisi kisi, int deger)
        {
            switch (deger)
            {
                case 1:
                    ParaYatir(kisi);
                    break;
                case 2:
                    ParaCek(kisi);
                    break;
                case 3:
                    foreach (var item in kisi.getKayit())
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 4:
                    paraTransferi(kisi);
                    break;
                case 5:
                    DovizAl(kisi);
                    break;
                case 0:
                    break;
                default:
                    break;
            }
        }
        public bool ParaYatir(Kisi kisi)
        {
            Console.WriteLine("Bakiyeniz: " + (String.Format("{0:0.00}", kisi.Para)));
            Console.WriteLine("Yatırmak istediğiniz miktarı giriniz");
            double para = double.Parse(Console.ReadLine());
            try
            {
                kisi.paraEkle(para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            AtmKasa += para;
            Birim.ParaBirimi en = new Birim.ParaBirimi();
            string y = Birim.enumtoStr(en, kisi, kisi.paraBirimi);
            kisi.kayitYap(kisi.KisiIsim + " Hesabınıza " + para + " " + y +" yatırıldı.");
            Console.WriteLine("Yeni Bakiyeniz: " + (String.Format("{0:0.00}", kisi.Para)));
            return true;

        }
        public bool ParaCek(Kisi kisi)
        {
            Console.WriteLine("Bakiyeniz: " + (String.Format("{0:0.00}", kisi.Para)));
            Console.WriteLine("Çekmek istediğiniz miktarı giriniz");
            double para = double.Parse(Console.ReadLine());
            bool x = false;

            if (AtmKasa - para < 0)
            {
                Console.WriteLine("Atmde yeterli para yok");
                return false;
            }
            else
            {
                try
                {
                    x = kisi.paraDüs(para);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                if (x)
                {
                    AtmKasa -= para;
                    Birim.ParaBirimi en = new Birim.ParaBirimi();
                    string y = Birim.enumtoStr(en, kisi, kisi.paraBirimi);
                    kisi.kayitYap(kisi.KisiIsim + " Hesabınızdan "+para+y+" çekildi.");
                    Console.WriteLine("Yeni Bakiyeniz: " + (String.Format("{0:0.00}", kisi.Para)));
                    return true;
                }
                else
                {
                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır");
                }
                return false;
            }

        }
        public void paraTransferi(Kisi kisi)
        {

            bool x = false;
            Console.WriteLine("Bakiyeniz: " + kisi.Para);
            Console.WriteLine("Havale yapmak istediğiniz kişinin TC sini giriniz");
            string tc = Console.ReadLine();
            Console.WriteLine("Havale yapmak istediğiniz miktarı giriniz");
            double miktar;
        x:
            {
                try
                {
                    miktar = double.Parse(Console.ReadLine()); ;


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto x;
                }
            }
            x = kisi.Transfer(kisi.TC, tc, miktar);

            if (x == true)
            {
                if (kisi.Para - miktar < 0)
                {
                    Console.WriteLine("Hesabınızda yeterli bakiye bulunmamaktadır");
                }
                else
                {
                    kisi.paraDüs(miktar);
                    AtmKasa += miktar;
                    Console.WriteLine("Yeni Bakiyeniz: " + kisi.Para);
                    Birim.ParaBirimi en = new Birim.ParaBirimi();
                    string y = Birim.enumtoStr(en, kisi, kisi.paraBirimi);
                    kisi.kayitYap(kisi.KisiIsim + " Hesabınızdan " + miktar + " "+y+" " + tc + " Kişisine havale edildi.");
                }
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public double DovizAl(Kisi kisi)
        {
            double temp = kisi.Para;
            Birim.ParaBirimi bir = (Birim.ParaBirimi)Enum.Parse(typeof(Birim.ParaBirimi), kisi.paraBirimi);
            String name = Enum.GetName(bir);

            Console.WriteLine("Almak istediğiniz Döviz türünü belirtiniz\nTL için 1\nDolar için 2\nEuro için 3");
            int a = int.Parse(Console.ReadLine());
            Birim birim  = new Birim();
            kisi.Para=birim.paraCevir(kisi.Para,kisi.paraBirimi,a);
            Birim.ParaBirimi x = (Birim.ParaBirimi)a;
            kisi.paraBirimi=Enum.GetName((Birim.ParaBirimi)a);
            string y = Birim.enumtoStr(x,kisi,kisi.paraBirimi);
            Console.WriteLine("Yeni Bakiyeniz: "+(String.Format("{0:0.00}",kisi.Para))+" "+kisi.paraBirimi);
            kisi.kayitYap(kisi.KisiIsim + " Hesabınızdaki "+ (String.Format("{0:0.00}", temp)) + " "+ name+" Miktar para "+kisi.paraBirimi+" Türünde "+ (String.Format("{0:0.00}", kisi.Para) + " Ya çevrildi"));
            return kisi.Para;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class KullanıcıMenu : KisiBilgileri
    {
        public void islemSec()
        {
            x:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("İşlemler:");
            Console.WriteLine("1-Para Çek " +
                "2-Para Yatır " +
                "3-Para Transferi " +
                "4-Kart İade");
            int islem = Int32.Parse(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    mevcutHesap();
                    paraÇek();
                    goto x;
                case 2:
                    mevcutHesap();
                    paraYatır();
                    goto x;
                case 3:
                    mevcutHesap();
                    paraTransferi();
                    goto x;
            }
        }

        public int mevcutHesap()
        {
            Console.WriteLine("Mevcut bakiyeniz:" + cüzdan);
            return cüzdan;
        }

        public int paraÇek()
        {
            Console.WriteLine("Çekmek istediğiniz tutarı giriniz.");
            int cekilecekMiktar = Int32.Parse(Console.ReadLine());
            if (cüzdan < cekilecekMiktar)
            {
                Console.WriteLine("İşlem gerçekleştirilememektedir.");
            }
            else if (cüzdan < 0)
            {
                Console.WriteLine("İşlem gerçekleştirilememektedir.");
            }
            else
            {
                Console.WriteLine("İşleminiz gerçekleştiriliyor. Bekleyiniz..");
            }
            int yeniCuzdan= cüzdan - cekilecekMiktar;
            Console.WriteLine("Mevcut bakiyeniz:" + yeniCuzdan);
            return yeniCuzdan;
        }

        public int paraYatır()
        {
            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz.");
            int yatırılacakMiktar = Int32.Parse(Console.ReadLine());
            Console.WriteLine("İşleminiz gerçekleştiriliyor. Bekleyiniz..");
            int yeniCuzdan = cüzdan + yatırılacakMiktar;
            Console.WriteLine("Mevcut bakiyeniz:" + yeniCuzdan);
            return yeniCuzdan;
        }

        public int paraTransferi()
        {
            Console.WriteLine("Havale edilecek tutarı ve havaleyi yapacağınız kişi ibanı giriniz.");
            int ibanTransf= Int32.Parse(Console.ReadLine()); ;
            int havaleMiktar= Int32.Parse(Console.ReadLine());
            Console.WriteLine("İşleminiz gerçekleştiriliyor. Bekleyiniz..");
            int yeniCuzdan = cüzdan + havaleMiktar;
            Console.WriteLine("Mevcut bakiyeniz:" + yeniCuzdan);
            return yeniCuzdan;
        }

    }
}

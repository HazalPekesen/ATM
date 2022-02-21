using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {


            var tahir = "Tahir";

            var atm = "alicaner";

            var behram = "behram";
            
            string samet = "samet";


            KullanıcıGiris kullanıcı = new KullanıcıGiris();
            kullanıcı.isim = "hazal";
            kullanıcı.sifre = "1234";
            kullanıcı.Login(kullanıcı);

            KullanıcıMenu menu = new KullanıcıMenu();
            menu.cüzdan= -3;
            menu.islemSec();
        }
    }
}

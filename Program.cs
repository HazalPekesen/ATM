using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var berk = "BerkKinq";
=======
            var atm = "alicaner";
>>>>>>> e0c8ce18af240fd05ae3d0c8670c95e2cb034ad2
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

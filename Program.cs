﻿using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
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

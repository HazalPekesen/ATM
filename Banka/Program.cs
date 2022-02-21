using System;

namespace Banka
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Atm atm = new Atm();
            Kisi kisi = new Kisi();
            bool x = false;
            do
            {
                Console.WriteLine("4 Haneli şifrenizi veya 11 haneli TC nizi giriniz");
                kisi = atm.girisKontrol(kisi, Console.ReadLine());
                if (kisi.kisiGiris==true)
                {
                    break;
                }
                
            } while (x!=true);
            atm.AtmAnasayfa(kisi);
        }
    }
}
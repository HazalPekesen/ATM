using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class KullanıcıGiris : KisiBilgileri
    {
        public KullanıcıGiris()
        {
            Console.WriteLine("Kullanıcı girişi açıldı.");
        }
        public static List<KisiBilgileri> kullanıcılar = new List<KisiBilgileri>()
        {
            new KisiBilgileri("hazal","1234",12000)
        };
        public bool Login(KullanıcıGiris kulGiris)
        {
            Console.WriteLine("Kullanıcı adı ve şifrenizi giriniz.");
            string kulAdı = Console.ReadLine();
            string kulSifre = Console.ReadLine();
            foreach (var item in kullanıcılar)
            {
                if (item.isim == kulAdı && item.sifre == kulSifre)
                {
                    Console.WriteLine("Giriş Başarılı. Menüye yönlendiriliyorsunuz.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifrenizi yanlış girdiniz.");
                }
            }
            return false;
        }
    }
}

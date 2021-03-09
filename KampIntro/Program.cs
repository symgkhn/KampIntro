using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety (tip güvenliği)
            //Do not repeat yourself-Kendini tekrarlama
            //kategoriEtiketi değer tutucu,alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double DolarBugun = 7.45;

            if (dolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış butonu göster.");
            }
            else if(dolarDun<DolarBugun)
            {
                Console.WriteLine("Artış butonu göster.");
            }
            else
            {
                Console.WriteLine("Eşittir butonu göster.");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi); //simüle ettim

        }
    }
}

using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //classın örneği
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+" "+urun.Fiyatı+" "+urun.Aciklama);
            }
            
        }
    }
}

//Don't repeat yourself -DRY - Clean Code - Best Practice

using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri1 = new GercekMusteri();
            gercekMusteri1.Id = 1;
            gercekMusteri1.MusteriNo = "12345";
            gercekMusteri1.Adi = "Engin";
            gercekMusteri1.Soyadi = "Demirog";
            gercekMusteri1.TCNo = "123456789";

            //Kodlama.io
            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.Id = 2;
            tuzelMusteri1.MusteriNo = "54321";
            tuzelMusteri1.SirketAdi = "Kodlama.io";
            tuzelMusteri1.VergiNo = "23423534";

            Musteri musteri1 = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(gercekMusteri1);
            customerManager.Add(tuzelMusteri1);



         
        }
    }
}

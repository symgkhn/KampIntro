using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.KursunIzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.KursunIzlenmeOrani = 59;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.KursunIzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.KursunEgitmeni + " " + kurs1.KursunIzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + ":" + kurs2.KursunEgitmeni + " " + kurs2.KursunIzlenmeOrani);
            //Console.WriteLine(kurs3.KursAdi + ":" + kurs3.KursunEgitmeni + " " + kurs3.KursunIzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni + " " + kurs.KursunIzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni  { get; set; }
        public int KursunIzlenmeOrani { get; set; }

    }
}

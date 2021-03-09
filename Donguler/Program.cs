using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] {"Yazılım geliştirici kursu","Programlamaya başlangıç için kurs","Java" ,"Python","C#"};
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("foreach bitti");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

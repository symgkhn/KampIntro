using System;
using System.Collections.Generic;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> agesOfPeople = new Dictionary<int, string>();
            agesOfPeople.Add( 16, "Ahmet");
            agesOfPeople.Add(34, "Mehmet");
            agesOfPeople.Add( 24, "Ali");
            agesOfPeople.Add( 37, "Ayşe");
            agesOfPeople.Add(21, "Fatma");

            foreach (var age in agesOfPeople)
            {
                Console.WriteLine(age);
            }

            
        }
    }
}

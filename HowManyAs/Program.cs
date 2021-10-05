using System;

namespace HowManyAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisetage oma eesnimi");
            string Nimi1 = Console.ReadLine();
            Console.WriteLine("Sisetage oma perekonna nimi");
            string Nimi2 = Console.ReadLine();

            int counter = 0;

                string NIMkokku = Nimi1 + Nimi2;
            char a = 'a';

            foreach (char character in NIMkokku)
            {
                if (character == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine($" {NIMkokku}s on {counter} A tähte."); 
        }
    }
}

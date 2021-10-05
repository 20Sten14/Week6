using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisetage oma eesnimi");
            string Nimi1 = Console.ReadLine();
            Console.WriteLine("Sisetage oma perekonna nimi");
            string Nimi2 = Console.ReadLine();

            for (int i = Nimi1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Nimi1[i]);
            }
            for (int i = Nimi2.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Nimi2[i]);
            }
        }
    }
}

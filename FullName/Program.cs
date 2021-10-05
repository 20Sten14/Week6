using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisetage oma eesnimi");
            string Nimi1 = Console.ReadLine();
            Console.WriteLine("Sisetage oma perekonna nimi");
            string Nimi2 = Console.ReadLine();

            if (Nimi1.Length > Nimi2.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikkem kui perekonna nimi!");
            }
            else if (Nimi1.Length > Nimi2.Length)
            {
                Console.WriteLine("Sinu perekonna nimi on pikkem kui su eesnimi!");
            }
            /*else
            {
                Console.WriteLine("Mõlemad on sama pikkad!");*/
            //}
        }
    }
}

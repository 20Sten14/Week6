using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt sisestada eesnimi
            //Programm kuvab kasutaja eesnime pikkust



            Console.WriteLine("Palun sisestage enda eesnimi");
            string Nimi = Console.ReadLine();

            Console.WriteLine($"Sinu nimi on {Nimi.Length} sübolit pikk.");


        }
    }
}

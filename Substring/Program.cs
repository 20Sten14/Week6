using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string HellowWorld = "Hello World";
            string partolookfor = "Hello";

            bool isThere;

            isThere = HellowWorld.ToLower().Contains(partolookfor);

            if (isThere)
            {
                Console.WriteLine($"leidsin {partolookfor} üles");
            }
            else
            {
                Console.WriteLine($"ei leitud {partolookfor}");
            }
        }
    }
}

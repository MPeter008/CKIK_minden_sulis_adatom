using System;
using System.Diagnostics.Eventing.Reader;


namespace Osztalyzat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int osztalyzat = r.Next(1, 6);
            Console.WriteLine(osztalyzat);
            /*
            if (osztalyzat == 1)
            {
                Console.WriteLine("elégtelen");
            }
            else if (osztalyzat == 2)
            {
                Console.WriteLine("elégséges");
            }
            else if (osztalyzat == 3)
            {
                Console.WriteLine("közepes");
            }
            else if (osztalyzat == 4)
            {
                Console.WriteLine("jó");
            }
            else
            {
                Console.WriteLine("jeles");
            }
            */

            switch (osztalyzat)
            {
                case 1:
                    Console.WriteLine("Elégtelen");
                    break;
                case 2:
                    Console.WriteLine("Elégséges");
                    break;
                case 3:
                    Console.WriteLine("Közepes");
                    break;
                case 4:
                    Console.WriteLine("Jó");
                    break;
                case 5:
                    Console.WriteLine("Jeles");
                    break;
            }

            Console.ReadKey();

        }
    }
}

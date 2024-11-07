using System;
using System.Runtime.InteropServices;

namespace gyumolcsok
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gyumolcsok = { "alma", "kiwi", "banán", "mangó" };
            Console.WriteLine("Egyesével: ");
            Console.WriteLine(gyumolcsok[0]);
            Console.WriteLine(gyumolcsok[1]);
            Console.WriteLine(gyumolcsok[2]);
            Console.WriteLine(gyumolcsok[3]);

            int db = 0;

            do
            {
                Console.WriteLine($" {db + 1}. { gyumolcsok[db]}");
                db += 1;
            } while (db <= gyumolcsok.Length - 1);

            Console.ReadKey();
        }
    }
}

using System;

namespace HaromKocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Addig dobálunk 3 (szabályos, hatoldalú) kockával, amíg a dobott számok összege 6-nál kisebb vagy 15-nél nagyobb nem lesz. Minden sorba írd ki a dobott értékeket, valamint a három szám összegét!
            */

            Random r = new Random();
            int osszeg;
            int a;
            int b;
            int c;

            do
            {
                a = r.Next(0, 6);
                b = r.Next(0, 6);
                c = r.Next(0, 6);
                osszeg = a + b + c;
                Console.WriteLine($"{a} {b} {c}  {osszeg}");

            } while (osszeg >= 6 && osszeg <= 15);
            
            Console.ReadKey();
        }
    }
}

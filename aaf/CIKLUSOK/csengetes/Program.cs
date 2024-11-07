using System;

namespace csengetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ido = 480;
            //for; while; if; switch; do; tab tab
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{i + 1}. óra: {ido/60:00}:{ido%60:00} - ");
                ido += 45;
                Console.WriteLine($"{ido / 60:00}:{ido % 60:00}");
                ido += 10;
            }

            Console.ReadKey();
        }
    }
}

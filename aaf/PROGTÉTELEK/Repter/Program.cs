using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = 
                { 
                "Kovács Anna", 
                "Nagy Péter", 
                "Szabó Éva", 
                "Tóth Márk",
                "Kiss Júlia", 
                "Molnár Tamás", 
                "Farkas Dóra", 
                "Horváth István", 
                "Varga Krisztina", 
                "Simon Balázs", 
                "Lukács Zoltán", 
                "Takács Emese" 
                };
            double[] tomegek = 
                { 
                22.3, 
                12, 
                7.5, 
                18.44, 
                35, 28, 
                14.12, 
                8, 
                16.9, 
                5.8, 
                30, 
                24 
                };

            int i;
            int n = tomegek.Length;
            int m = nevek.Length;

            //F1 - Minimum kiválasztás
            //mini: A legkisebb elem indexe
            int mini = 0;
            for (i = 1; i < n; i++)
            {
                if (tomegek[i] < tomegek[mini])
                {
                    mini = i;
                }
            }
            Console.WriteLine("1.\n" + nevek[mini] + "\n");

            //F2 - Keresés = Eldöntés + Kiválasztás
            i = 0;
            while (i < n && !(tomegek[i] > 30))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine("2.\n" + nevek[i] + "\n");
            }
            else
            {
                Console.WriteLine("2.\nNincs ilyen!\n");
            }

            //F3
            Console.ReadKey();
        }
    }
}

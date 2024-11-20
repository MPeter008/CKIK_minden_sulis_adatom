using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
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
            
            //double[] tomegek =
            //    {
            //    22.3,
            //    120,
            //    70.5,
            //    180.44,
            //    35, 28,
            //    140.12,
            //    80,
            //    160.9,
            //    50.8,
            //    30,
            //    24
            //    };

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

            //F3 - Feltételes átlag = Összegzés + Megszámolás
            double osszeg = 0;
            int db = 0;

            for (i = 0; i < n; i++)
            {

                if (tomegek[i] < 20)
                {
                    osszeg += tomegek[i];
                    db++;
                }
                else
                {
                    
                }
            }
            
            if (db == 0)
            {
                Console.WriteLine("3.\n Nincs 20 kg alatti csomag\n");
            }
            else
            {
                double atlag = osszeg / db;
                Console.WriteLine($"3.\n{atlag:0.00} kg\n");
            }

            //F4 - Eldöntés
            i = 0;
            while (i < n && !(tomegek[i] <= 5))
            {
                i++;
            }

            if (i < n)
            {
                Console.WriteLine("4.\n Nem igaz!\n");
            }
            else
            {
                Console.WriteLine("4.\n Igaz!\n");
            }

            //F5
            db = 0;
            for (i = 0; i < n; i++)
            {
                if (nevek[i].Length > 10)
                {
                    db++;
                }
            }
            Console.WriteLine($"5.\n{db} név hosszab 10 karakternél\n");

            //F6
            db = 0;
            for (i = 0; i < n - 1; i++)
            {
                if (tomegek[i] > tomegek[i + 1])
                {
                    db++;
                }
            }
            Console.WriteLine($"6.\n{db}\n");

            //F7 
            i = 0;
            while (nevek[i] != "Farkas Dóra")
            {
                i++;
            }
            double dora = tomegek[i];
            db = 0;
            for (i = 0; i < n; i++)
            {
                if (tomegek[i] < dora)
                {
                    db++;
                }
            }
            Console.WriteLine($"7.\n{db}\n");

            //F8 - Feltételes maximum


            //1. Megoldás

            //int maxi = 0;
            //double maxe = -1 ;
            //for (i = 1; i < n; i++)
            //{
            //    if (tomegek[i] > maxe && tomegek[i] > 9 && tomegek[i] < 21)
            //    {
            //        maxi = i;
            //        maxe = tomegek[i];
            //    }
            //}
            //if (maxe == -1)
            //{
            //    Console.WriteLine($"8.\nNincs megfelelő\n");
            //}
            //else
            //{
            //    Console.WriteLine($"8.\n{nevek[maxi]}\n");
            //}


            //2.Megoldás - Keresés + Maximum kiválasztás

            i = 0;
            while (i < n && !(9 < tomegek[i] && tomegek[i] < 21))
            {
                i++;
            }
            if (i < n)
            {
                int maxi = i;
                for (int j = i; j < n; j++)
                {
                    if (tomegek[j] > tomegek[maxi] && 9 < tomegek[j] && tomegek[j] < 21)
                    {
                        maxi = j;
                    }
                }
                Console.WriteLine($"8.\n{nevek[maxi]}\n");
            }
            else
            {
                Console.WriteLine($"8.\nNincs megfelelő\n");
            }




            Console.ReadKey();
        }
    }
}

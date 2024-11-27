using System;
using System.Runtime.InteropServices;

namespace jogositvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // Statikus tömbök: fordítási időben tudnunk kell a méretét!
            // Ez így NEM JÓ!!!
            // string[] nevek = new string[n];
            string[] nevek = new string[100];
            int[] korok = new int[100];
            bool[] jogsik = new bool[100]; // jogsik[i]: az i. adatnak van-e jogsija?

            //F1 - Beolvasás
            int i;
            for (i = 0; i < n; i++)
            {
                string sor = Console.ReadLine(); //"Daniel 30 I"
                string[] adatok = sor.Split(' '); //{"Daniel", "30", "I"}
                nevek[i] = adatok[0]; //{ "Daniel", "Marta", ...}
                korok[i] = Convert.ToInt32(adatok[1]);
                
                //1.
                //if (adatok[2] == "I") jogsik[i] = true;
                //else jogsik[i] = false;

                //2.
                //jogsik[i] = adatok[2] == "I" ? true : false; // ternary operator

                //3.
                jogsik[i] = adatok[2] == "I";
            }

            //F2 - Megszámolás

            int db = 0;
            for (i = 0; i < n; i++)
            {
                if (jogsik[i])
                {
                    db++;
                }
            }
            double szazalek = (double)db / n * 100;
            Console.WriteLine("2. " + szazalek + "%");
            //F3 - Keresés

            i = 0;
            while (i < n && !(korok[i] > 30 && !jogsik[i]))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine($"3. {nevek[i]}");
            }
            else
            {
                Console.WriteLine($"3. Nincs ilyen ember.");
            }

            //F4 - Min-Max Kiválasztás
            //int maxe = korok[0];
            //for (i = 1; i < n; i++)
            //{
            //    if (korok[i] > maxe)
            //    {
            //        maxe = korok[i];
            //    }
            //}
            //int mine = korok[0];
            //for (i = 1; i < n; i++)
            //{
            //    if (korok[i] < mine)
            //    {
            //        mine = korok[i];
            //    }
            //}

            int maxe = korok[0];
            int mine = korok[0];
            for (i = 1; i < n; i++)
            {
                if (korok[i] > maxe)
                {
                    maxe = korok[i];
                }
                if (korok[i] < mine)
                {
                    mine = korok[i];
                }

            }
            Console.WriteLine($"4. {maxe-mine}");

            // F5 - Megszamolas

            int huszfelett = 0;
            int huszalatt = 0;
            for (i = 0; i < n; i++)
            {
                if (korok[i] > 20)
                {
                    huszfelett++;
                }
                else
                {
                    huszalatt++;
                }
            }
            if (huszalatt < huszfelett)
            {
                Console.WriteLine("5. Igaz, hogy a 20 felettiek többen vannak");
            }
            else
            {
                Console.WriteLine("5. Hamis, a 20 alattiak vannak többen");
            }

            // F6 - Keresés

            i = 0;
            while (i < n && !(nevek[i][0] == 'F'))
            {
                i++;
            }
            if (i < n)
            {
                Console.WriteLine($"6. Van ilyen nev: {nevek[i]}");
            }
            else
            {
                Console.WriteLine("6. Nincs ilyen nev");
            }

            // F7 - Összegzés

            int utsotiz = 0;
            for (i = n-10; i < n; i++)
            {
                utsotiz += korok[i];
            }
            double atlag = (double) utsotiz / 10;
            Console.WriteLine("7. " + atlag);
            //Console.ReadKey();
        }
    }
}

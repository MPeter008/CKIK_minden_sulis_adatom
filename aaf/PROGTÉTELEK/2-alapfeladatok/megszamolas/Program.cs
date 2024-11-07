using System;

namespace megszamolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] x = {5, 7, 2, 2, 9, -1, 4, -3, 9, 3, 2, 1};

            //  Párosak száma

            //int db = 0;
            //for (int i = 0; i < x.Length ; i++)
            //{
            //    if (x[i] % 2 == 0)
            //    {
            //        db += 1;
            //    }
            //}
            //Console.WriteLine(db);

            //  Összegzés
            //  Add meg a párosak szorzatát
            //int szorzat = 1;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (x[i] % 1 == 0)
            //    {
            //        szorzat *= x[i];
            //    }
            //}
            //Console.WriteLine(szorzat);

            // Maximum-kiválasztás
            int maxi = x.Length - 1;
            int maxe = x[x.Length-1];
            for (int i = x.Length-2; i >= 0; i--)
            {
                if (x[i] > maxe)
                {
                    maxi = i;
                    maxe = x[i];
                }
            }
            Console.WriteLine(maxe);
            Console.WriteLine(maxi + 1);
            Console.ReadKey();
        }
    }
}

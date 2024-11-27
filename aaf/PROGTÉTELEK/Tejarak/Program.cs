using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tejarak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaráció
            int n, also, felso;
            int[] arak = new int[100];

            //Beolvasás
            string elsosor = Console.ReadLine();
            string[] adatok = elsosor.Split(' ');
            n = Convert.ToInt32(adatok[0]);
            also = Convert.ToInt32(adatok[1]);
            felso = Convert.ToInt32(adatok[2]);

            int i;
            for (i = 0; i < n; i++)
            {
                int ar = Convert.ToInt32(Console.ReadLine());
                arak[i] = ar;
            }

            //Megszámolás
            int db = 0;
            for (i = 0; i < n; i++)
            {
                if (arak[i] >= also && arak[i] <= felso)
                {
                    db++;
                }
            }

            //Kiírás
            Console.WriteLine(db);
        }
    }
}

using System;
using System.ComponentModel;

namespace fuggvenyek
{
    internal class Program
    {
        static double Kerulet(double a, double b)
        {
            return 2 * (a + b);
        }

        static bool ParosE(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Max(int[] a)
        {
            int hossz = a.Length;
            int max = a[0];
            for (int i = 0; i < hossz; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine(Kerulet(3, 5));
            Console.WriteLine(Kerulet(1.25, 4));

            //2.
            Console.WriteLine(ParosE(5));
            Console.WriteLine(ParosE(162));

            //3.
            Console.WriteLine(Max(new int[] { 4, 7, -3, 12, 7, 14, -1 }));
        }
    }
}

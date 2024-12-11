using System;
using System.CodeDom;
using System.Runtime.InteropServices;

namespace szamelmelet
{
    internal class Program
    {
        static bool PrimE(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int d = 2;
            while (d <= Math.Sqrt(n) && !(n % d == 0))
            {
                d++;
            }
            if (d <= Math.Sqrt(n))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static int[] Primszamok(int[] x)
        {
            int[] y = new int[1000];
            return y;
        }
        static int SokOsztos(int[] n)
        {
            int i = 0;
            int hossz = n.Length;
            while (i < hossz && !(n[i] % 20 == 0))
            {
                i++;
            }
            return n[i];
            
        }
        static void Main(string[] args)
        {
            int[] primek = Primszamok(new int[] { 7, 23, 6, 42, 73, 2, 3, 9, 1, 5 });
            
            Console.WriteLine(SokOsztos(new int[] { 6, 1001, 48, 360, 75 }));
        }
    }
}

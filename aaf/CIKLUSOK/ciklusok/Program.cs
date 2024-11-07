using System;

namespace ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a Első n db négyzetszám
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a) Feladat");
            for (int i = 0; i < n; i++)
            {
                //Console.Write($"{i*i} ");
                Console.Write(i * i + " ");
            }


            //b N-ig írjuk ki a négyzetszámokat
            Console.WriteLine("\nb) Feladat");
            int j = 0;
            while (j*j < n)
            {
                Console.Write(j * j + " ");
                j++;
            }
            //Processzornak plusz munka!


            //c N-ig írjuk ki a négyzetszámokat
            Console.WriteLine("\nc) Feladat");
            int k = 0;
            int negyzet = k * k;
            while (negyzet < n)
            {
                Console.Write(negyzet + " ");
                k++;
                negyzet = k * k;
            }
            //Memóriában több ==> Processzornak kevesebb a dolga 
            

            Console.ReadKey();
        }
    }
}

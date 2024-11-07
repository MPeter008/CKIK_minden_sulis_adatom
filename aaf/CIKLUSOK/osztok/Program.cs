using System;

namespace osztok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            //Console.WriteLine("n: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //while (n <= 0)
            //{
            //    Console.WriteLine("Nem jó! Pozitív egész számot adj!");
            //    Console.WriteLine("n: ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //}

            do
            {
                Console.WriteLine("Adj meg egy pozitív egés számot, amelynek az osztóit szeretném tudni!");
                Console.WriteLine("n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);


            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}

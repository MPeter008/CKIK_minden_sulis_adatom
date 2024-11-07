using System;

namespace hatvanyozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double a = 2;
            const int n = 10;

            double eredmeny = 1;
            for (int i = 0; i < n; i++)
            {
                // eredmeny = eredmeny * a;
                eredmeny  *= a;
            }

            Console.WriteLine($"{a}^{n} = {eredmeny}");
            Console.ReadKey();
        }
    }
}

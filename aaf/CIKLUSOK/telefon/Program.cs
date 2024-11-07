using System;


namespace telefon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Írjuk ki n-szer, hogy "Nem mobilozok az iskolában"
            //a1) For ciklussal
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. Nem mobilozok az iskolában");
            }

            Console.WriteLine();
            //Console.WriteLine("\n")
            //Console.WriteLine("\t");

            //a2) For ciklussal
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\t{i}. Nem mobilozok az iskolában");
            }

            Console.WriteLine();

            //b) While ciklussal

            int j = 1;

            while(j <= n)
            {
                Console.WriteLine($"{j++}. Nem mobilozok az iskolában");
            }
            Console.ReadKey();
        }
    }
}

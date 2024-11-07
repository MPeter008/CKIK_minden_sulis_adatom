using System;

namespace erme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 50;
            Random r = new Random();

            // a) Dobjunk fel egy érmét 50x
            int dbF = 0, dbI=0;
            for (int i = 0; i < n; i++)
            {
                int dobas = r.Next(1, 3); //1..2
                if (dobas == 1)
                {
                    Console.Write("F ");
                    dbF++;
                }
                else
                {
                    Console.Write("I ");
                    dbI++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Fejek száma: {dbF}");
            Console.WriteLine($"Írások száma: {dbI}");

            // b) Dobáljukaz érmét, amíg egymás négy írást nem kapunk
            Console.WriteLine("b)");
            int db = 0; // Egymás utáni írások száma
            do
            {
                int dobas = r.Next(1, 3);
                if (dobas == 1)
                {
                    Console.Write("F ");
                    db = 0;
                }
                else
                {
                    Console.Write("I ");
                    db++;
                }
            } while (db != 4);

            Console.ReadKey();
        }
    }
}

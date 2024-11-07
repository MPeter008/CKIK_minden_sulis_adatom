using System;


namespace dobokocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //a) Dobjunk egy kockával n-szer!
            Console.WriteLine("Dobások: ");
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int kocka = r.Next(1, 7);
                Console.Write(kocka+ " ");
            }

            // b) Dobáljunk, amíg 6-ost nem kapunk!
            Console.WriteLine("");
            Console.WriteLine("Dobások 6-ig: ");
            int dobasok;
            do
            {
                dobasok = r.Next(1, 7);
                Console.Write(dobasok + " ");
            } while (dobasok != 6);
            Console.ReadKey();        
        }
    }
}

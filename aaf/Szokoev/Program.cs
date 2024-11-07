using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int ev = r.Next(2001, 2025);
            Console.WriteLine(ev);
            //if (ev % 4 == 0)
            //{
            //    Console.WriteLine("Az év szökőév");
            //}
            //else
            //{
            //    Console.WriteLine("Az év nem szökőév");
            //}

            if (ev % 4 == 0) Console.WriteLine("Az év szökőév");
            else Console.WriteLine("Az év nem szökőév");
            Console.ReadKey();
        }
    }
}

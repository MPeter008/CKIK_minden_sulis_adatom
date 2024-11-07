using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 22;
            string eredmeny = "";
            while (n != 0)
            {
                int maradek = n % 2;
                n = n / 2;
                eredmeny = maradek + eredmeny;
            }
            Console.WriteLine($"2-es számrendszerben: {eredmeny}");
            Console.ReadKey();
        }
    }
}

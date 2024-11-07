using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paratlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random r = new Random();
            int a = 0;
            for (int i = 0; i < 7; i++) 
            { 
                a = r.Next(1, 10);
                if (a % 2 == 0)
                {
                    a = a + 1;
                }
                Console.Write($"{a}");
            }    
            Console.ReadKey();
        }
    }
}

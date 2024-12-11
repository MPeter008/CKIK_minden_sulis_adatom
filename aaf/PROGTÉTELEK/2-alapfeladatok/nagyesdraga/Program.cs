using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagyesdraga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string elso = Console.ReadLine();
            string[] tomb = elso.Split(' ');
            int lakasokszama = Convert.ToInt32(tomb[0]);
            int meretkorlat = Convert.ToInt32(tomb[1]);
            int arkorlat = Convert.ToInt32(tomb[2]);


            int[] lakasokara = new int[100];
            int[] terulet = new int[100];
            int i = 0;
            for (i = 0; i < lakasokszama; i++)
            {
                string sor = Console.ReadLine();
                string[] darabok = sor.Split(' ');
                lakasokara[i] = Convert.ToInt32(darabok[0]);
                terulet[i] = Convert.ToInt32(darabok[1]);
            }

            i = 0;
            while (i < lakasokszama && !(terulet[i] > meretkorlat && lakasokara[i] > arkorlat) )
            {
                i++;
            }
            if (i < lakasokszama)
            {
                Console.WriteLine(i + 1);
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fenyofa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fenyo = Console.ReadLine();
            string[] fenyok = fenyo.Split(' ');
            int szamuk = Convert.ToInt32(fenyok[0]);
            int aruk = Convert.ToInt32(fenyok[1]);

            int i;
            int[] fenyokara = new int[100];
            for (i = 0; i < szamuk; i++)
            {
                int sor = Convert.ToInt32(Console.ReadLine());
                fenyokara[i] = sor;
            }

            int[] nagyobbak = new int[100];
            int j = 0;
            for (i = 0; i < szamuk; i++)
            {
                if (fenyokara[i] > aruk)
                {
                    nagyobbak[j] = i + 1;
                    j++;
                }
            }
            Console.Write(j + " ");
            for (i = 0; i < j; i++)
            {
                Console.Write(nagyobbak[i] + " ");
            }
        }
    }
}

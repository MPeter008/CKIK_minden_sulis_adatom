using System;

namespace Utazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jani egy szombati napon Budapestre akart jutni, de a MÁV ebben többet akadályozta, mint segítette

            //a) Olvasd be az indulási és érkezési idejét (óra, perc), majd határozd meg, hogy mennyi ideig (óra, perc) utazott. Pontosan a minta szerint jelenítsd meg az adatokat!

            Console.WriteLine("Mikor indultál?");
            Console.Write("Óra: ");
            int iora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Perc: ");
            int iperc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mikor érkeztél?");
            Console.Write("Óra: ");
            int eora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Perc: ");
            int eperc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{iora:00}:{iperc:00} , {eora:00}:{eperc:00}");

            int mora, mperc;
            mperc = eperc + iperc;
            mora = eora + iora;
            if (mperc >= 60)
            {
                mperc = mperc - 60;
                mora = mora + 1;
            }
            Console.WriteLine($"{mora}:{mperc}");


            Console.ReadKey();
        }
    }
}

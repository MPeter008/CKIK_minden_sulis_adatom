using System;

namespace eljarasok
{
    internal class Program
    {
        static void Kiir(string s)
        {
            Random r = new Random();
            int n = r.Next(3, 10); 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(s);
            }
        }

        static void Beolvas(out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
        }

        static void Duplaz(ref int a)
        {
            if (a % 2 != 0)
            {
                a *= 2;
            }
        }

        static void Novel(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                t[i]++;
            }
        }
        static void Kiir(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Kiir("kifli");

            Beolvas(out int n);
            Console.WriteLine(n);

            int a = 6;
            Duplaz(ref a);
            Console.WriteLine("Új 'a' érték: " + a);

            int[] tomb = { 5, 7, -3 };
            Novel(tomb);

            Kiir(tomb);
        }
    }
}

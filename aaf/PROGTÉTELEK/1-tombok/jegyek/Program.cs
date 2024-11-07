using System;

namespace jegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            //int[] jegyek = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

            int[] jegyek = new int[16]; //0 az első elem!!!!!!!!!!!!!

            //Jegyek generálása
            for (int i = 0; i < jegyek.Length; i++)
            {
                jegyek[i] = r.Next(1, 6);
            }

            //Kiírás
            for (int i = 0; i < jegyek.Length; i++)
            {
                Console.Write(jegyek[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace jogositvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // Statikus tömbök: fordítási időben tudnunk kell a méretét!
            // Ez így NEM JÓ!!!
            // string[] nevek = new string[n];
            string[] nevek = new string[100];
            int[] korok = new int[100];
            bool[] jogsik = new bool[100]; // jogsik[i]: az i. adatnak van-e jogsija?

            //F1 - Beolvasás
            int i;
            for (i = 0; i < n; i++)
            {
                string sor = Console.ReadLine(); //"Daniel 30 I"
                string[] adatok = sor.Split(' '); //{"Daniel", "30", "I"}
                nevek[i] = adatok[0]; //{ "Daniel", "Marta", ...}
                korok[i] = Convert.ToInt32(adatok[1]);
                
                //1.
                //if (adatok[2] == "I") jogsik[i] = true;
                //else jogsik[i] = false;

                //2.
                //jogsik[i] = adatok[2] == "I" ? true : false; // ternary operator

                //3.
                jogsik[i] = adatok[2] == "I";
            }
            Console.WriteLine(jogsik[0]);
            
            //Console.ReadKey();
        }
    }
}

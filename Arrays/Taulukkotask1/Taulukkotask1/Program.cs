using System;

namespace Taulukkotask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] iT = new int[100];
            double sum = 0;
            double average;

            Console.WriteLine("100 arvottua lukua: ");

            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(0, 51);
                Console.WriteLine($"{ i + 1 }. { iT[i] }");
                sum = (double)sum + iT[i];
            }
            
            average = sum / iT.Length;

            Console.WriteLine($"Arvottujen lukujen keskiarvo: { average }.");
            Console.ReadKey();
        }
    }
}

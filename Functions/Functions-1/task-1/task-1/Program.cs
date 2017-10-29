using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä luku: ");
            string userInput = Console.ReadLine();
            int luku = int.Parse(userInput);
            Console.WriteLine(Tulostus(luku));
            Console.ReadKey();
        }

        static string Tulostus(int luku)
        {
            char merkki = '*';
            string star;
            star = "";

            for (int i = 1; i <= luku; i++)
            {
                star = star + merkki;
            }
            return star;
        }
    }
}

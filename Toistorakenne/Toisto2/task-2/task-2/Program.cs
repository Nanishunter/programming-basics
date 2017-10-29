using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa N ensimmäisten lukujen arvon. Syötä arvo");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 1; //Counter
            int f = 1; //Factorial

            while (i < number)
            {
                i = i + 1; // Laskurin kasvatus yhdellä
                f = f + i;
            }

            Console.WriteLine($"Luvun {number} summa on {f}");
            Console.ReadLine();

        }
    }
}

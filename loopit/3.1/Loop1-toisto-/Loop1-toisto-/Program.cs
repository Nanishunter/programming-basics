using System;

namespace Loop1_toisto_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa N! arvon. Syötä arvo");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 0; //Counter
            int f = 1; //Factorial

            while (i < number)
            {
                i = i + 1; // Laskurin kasvatus yhdellä
                f = f *i;
            }

            Console.WriteLine($"Luvun {number} kertoma on {f}");
            Console.ReadLine();

            {




            }

            

        }
    }
}

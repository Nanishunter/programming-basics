using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(HaeNumerot());
            Console.ReadKey();
        }

        static string HaeNumerot()
        {
            int j;
            string userInput = "";
            int biggestNumber = 0;
            int rowNumber = 0;
            string result = "";
            string lukujono = "";

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Syötä luku {i}.");
                userInput = Console.ReadLine();
                j = int.Parse(userInput);

                Console.WriteLine(j);

                if (j > biggestNumber)
                {
                    biggestNumber = j;
                    rowNumber = i;
                }

                lukujono = lukujono + " " + j;

            }

            result = ($"Syötit luvut { lukujono }. \n Suurin { biggestNumber } oli { rowNumber }. luku.");

            return result;
        }
    }
}

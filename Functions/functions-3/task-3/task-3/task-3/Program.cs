using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int lowerBound = 1;
            int upperBound = 20;
            Console.WriteLine(NumberFromRange(lowerBound, upperBound));
            Console.ReadKey();
        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {
            bool numberIsOkay;
            int number;
            number = 0;

            do
            {
                Console.WriteLine("Syötä luku väliltä 1-20: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);

                if (number >= lowerBound && number <= upperBound)
                {
                    numberIsOkay = true;
                }
                else
                {
                    numberIsOkay = false;
                }

            } while (numberIsOkay == false);

            return number;
        
    }
    }
}

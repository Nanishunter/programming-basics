using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
      
            Console.WriteLine("Syötä numero: ");

            String userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            bool isNumber = int.TryParse(userInput, out evaluatedNumber);
       
            if (isNumber == true)
            {

                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on parillinen.");
                }
                else
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on pariton.");
                }
            }
            else
            {
                Console.WriteLine("Syötit muuta kuin numeroita");
            }

            Console.ReadKey();

        }
    }
}

using System;

namespace task_3
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

                if (evaluatedNumber > 0)
                {
                    Console.Write($"Numero {evaluatedNumber} on positiivinen ja se on");

                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine(" parillinen.");
                    }
                    else
                    {
                        Console.WriteLine(" pariton.");
                    }

                }
                else if (evaluatedNumber < 0)
                {
                    Console.Write($"Numero {evaluatedNumber} on negatiivinen ja se on");

                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine(" parillinen.");
                    }
                    else
                    {
                        Console.WriteLine(" pariton.");
                    }

                }
                else
                {
                    Console.Write($"Numero {evaluatedNumber} on nolla ja se on");
                    Console.WriteLine(" parillinen.");
                }

            }
            else
            {
                Console.WriteLine("Syötit muuta kuin numeroita.");
            }
            Console.ReadKey();
        }
    }
}

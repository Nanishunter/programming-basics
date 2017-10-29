using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee ensimmäisen parillisen ja parittoman luvun summan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;
            do
            
                if (i % 2 == 0)
                    evenSum += i;

                else
                    oddSum += i;

                   i++;
            
            }
            
    }
}

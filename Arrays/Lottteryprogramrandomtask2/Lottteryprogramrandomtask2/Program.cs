using System;

namespace Lottteryprogramrandomtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[7];

            for (int i = 0; i <= 6; i++)
            {
                numbers[i] = rnd.Next(1, 41);
            }
            Console.WriteLine("Lottorivi on: ");

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.Write(number);
                Console.Write(' ');
            }
            Console.ReadKey();
        }
    }
}
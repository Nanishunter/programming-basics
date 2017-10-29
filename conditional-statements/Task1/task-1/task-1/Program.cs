using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int number;

            Console.WriteLine("Syötä luku, ohjelma kertoo onko se positiivinen, negatiivinen vai nolla.");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
                Console.WriteLine("numerosi on positiivinen");
            else
                if (number < 0)
                Console.WriteLine("numerosi on negatiivinen");
            else
                Console.WriteLine("Numerosi on nolla");

            Console.ReadLine();



        }
    }
}

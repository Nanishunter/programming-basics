using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä sana, ohjelma näyttää kirjainmäärän.");
       
            string userInput = Console.ReadLine();
            int kirjainmaara = userInput.Length;
            Console.WriteLine($"Syötteessä on { kirjainmaara } merkkiä.");
            Console.ReadKey();
        }

    }
}
        
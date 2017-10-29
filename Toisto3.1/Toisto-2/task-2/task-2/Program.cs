using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9");

            for (int i = 1; i < 10; i++)
            {


                for (int j = 1; j < 10; j++)
                {
                    int tulos;
                    tulos = j * i;
                    Console.WriteLine($" {i}*{j} = {i * j} ");
                }
            }
            Console.ReadLine();

        }
    }
}

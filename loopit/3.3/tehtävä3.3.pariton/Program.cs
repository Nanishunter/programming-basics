using System;

namespace tehtävä3._3.pariton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäisen parillisen ja parittoman luvun summan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;
            do
            {
                if (i % 2 == 0)
                    evenSum += i;

                else
                    oddSum += i;

                i++;


            }
            while (i <= number);
            Console.WriteLine($"Parillisten lukujen summa on {evenSum} ja parittomien lukujen summa on {oddSum}");
            Console.ReadLine();




                
                
            
                

            
                
           
            



        }
    }
}

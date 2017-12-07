using System;

namespace Vokaalilaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee vokaalien määrän, syötä sana tai lause.");
            string userinput;
            userinput = Console.ReadLine();
            string syote = userinput.ToUpper();
            int vokaali = 0;
            foreach (char x in syote) 
            {
                if (x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U' || x == 'Y' || x == 'Ä' || x == 'Ö')
                {
                    vokaali = vokaali + 1;
                }
            }
            Console.WriteLine($"Sanassa {userinput} on {vokaali} vokaalia");
            Console.ReadLine();
        }
    }
}

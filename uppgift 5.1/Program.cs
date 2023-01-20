using System;
namespace Uppgift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv antalet meningar du vill skriva ");
            int meningar = int.Parse(Console.ReadLine());
            string[] mening = new string[meningar];


            for(int i=0; i < meningar; i++)
            {
                Console.WriteLine("Skriv mening");
                mening[i] = Console.ReadLine();
            }

            Console.WriteLine("Du har skrivit meningar:");
            Console.Write("");

            for (int i=0; i < meningar; i++)
            {
                Console.Write($" \n{mening[i]}");
            }


        }
    }
}

using System;
using System.ComponentModel;

namespace PrintNumberSeriesWithoutUsingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintFirstSetOfNumbersWitLoop();
            PrintFirstSetOfNumbers();
            Console.WriteLine("The End");
        }

        private static void PrintFirstSetOfNumbers()
        {
            int number = 'Z' - 'A';
            for (int i = 'A'-'A'; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void PrintFirstSetOfNumbersWitLoop()
        {
            int number = 25;
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

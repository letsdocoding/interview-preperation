using System;
using System.Reflection;

namespace LoopRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number till where series is to be printed: ");
            var input = Console.ReadLine();
            var number = int.Parse(input);

            //PrintSeries(number)
            IncrementAndPrint(0, number);


            Console.WriteLine("The End");
            Console.ReadLine();
        }


        private static void IncrementAndPrint(int currentNumber, int printTill)
        {
            currentNumber++;
            Console.WriteLine(currentNumber);
            if (currentNumber < printTill)
            {
                IncrementAndPrint(currentNumber, printTill);
            }
        }

        private static void PrintSeries(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

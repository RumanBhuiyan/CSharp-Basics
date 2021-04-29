using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // using static methods or functions
            Console.WriteLine("Summation between 1,100: " + getSumBetween(1, 100));
            Console.WriteLine("Summation between 0 to 50: "+getSumBetween(50));

        }
        static int getSumBetween(int start, int end)
        {
            int summation = 0;

            while (start <= end)
            {
                summation += start;
                start++;
            }
            return summation;
        }

        // method overloading 
        static int getSumBetween(int number)
        {
            int summation = 0;

            while (number >0)
            {
                summation += number;
                number--;
            }
            return summation;
        }

    }
}

using System;
using System.Linq; // using to sort array,finding min max of array

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Looping 
            // while loop
            int i = 0;
            while (i<5)
            {
                Console.WriteLine("i = "+(i+1));
                i++;
            }

            // do while loop
            int j = 5;
            do
            {
                Console.WriteLine("j = " + (j));
                j--;
            } while (j>0);

            // for loop 
            for (int k = 6; k<10; k++)
            {
                Console.WriteLine("k = "+(k));
            }

            // for each loop 
            int[] numbers = { 3,4,1,2,5};
            // Sorting array elements
            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

        }

    }
}

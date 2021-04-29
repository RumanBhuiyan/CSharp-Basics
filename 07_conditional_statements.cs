using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Conditional Statements
            // Ternary Opetator 
            bool isPositive = number > 0 ? true : false;
            Console.WriteLine("Number is " + (isPositive ? "positive" : "negative"));

            // if-else ladder 
            if (number > 0)
            {
                Console.WriteLine("Number is Positive");
            }else if (number < 0)
            {
                Console.WriteLine("Number is Negative");
            }else
            {
                Console.WriteLine("Number is zero");
            }

            //Switch Statement 
            int checking = number > 0 ? 1 : number < 0 ? 2 : 3;

            switch (checking)
            {
                case 1:
                    Console.WriteLine("Number is Postive");
                    break;
                case 2:
                    Console.WriteLine("Number is Negative");
                    break;
                default:
                    Console.WriteLine("Number is zero");
                    break;
            }

        }

    }
}

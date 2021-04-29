using System;

namespace ConsoleApp1
{
    // Exception Handling 
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quotient is " +getQuotient(first,second));
        }

        static double getQuotient(double first,double second)
        {
            double result = 0;
            bool isAnyProblem = false;

            try
            {
                if (second == 0)
                {
                    isAnyProblem = true;
                    result = 0;
                }else
                {
                    result = first / second;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (isAnyProblem)
                {
                    Console.WriteLine("Cant't divide by 0");
                }
            }
            return result;
        }
  
    }
    
}

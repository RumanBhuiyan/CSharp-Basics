using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking User Input
            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Program prog = new Program();
            Console.WriteLine("The factorial is : "+prog.getFactorial(first));

           

        }
        public int getFactorial(int number)
        {
            return number == 1 ? 1 : number * getFactorial(number - 1);
        }
    }
}

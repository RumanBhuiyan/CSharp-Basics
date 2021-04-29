using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 5.6;
            // explicit type casting
            Console.WriteLine("Integer value : " + (int)number);

            
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            // type conversion
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

        }
    }
}


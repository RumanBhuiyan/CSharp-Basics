using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // String library functions 
            string name = "Bangladesh";

            Console.WriteLine("Length of a string: "+name.Length);
            Console.WriteLine("UpperCase string: "+name.ToUpper());
            Console.WriteLine("Lowercase string: "+name.ToLower());

            // String Interpolation
            string sentence = $"My Country is {name}";
            Console.WriteLine(sentence);

        }

    }
}

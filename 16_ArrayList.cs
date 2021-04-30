using System;
using System.Collections; // for using ArrayList

namespace ConsoleApp1
{
    //ArrayList of Collection 
    class Program 
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();

            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(5);

            // sorting 
            numbers.Sort();

            Console.WriteLine("Capacity: "+numbers.Capacity);
            Console.WriteLine("Count: "+numbers.Count);
            Console.WriteLine("Third elememnt: "+numbers[2]);
        }
    }
    
}

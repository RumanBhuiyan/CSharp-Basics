using System;
using System.Collections; // for using ArrayList

namespace ConsoleApp1
{
    //HashTable of Collection 
    class Program 
    {
        static void Main(string[] args)
        {
            Hashtable myDictionary = new Hashtable();

            myDictionary.Add("first", "C");
            myDictionary.Add("second", "C++");
            myDictionary.Add("third", "Java");
            myDictionary.Add("fourth", "C#");

            // Accessing values
            Console.WriteLine("first value : "+myDictionary["first"]);

            // Iterating over items
            foreach (string key in myDictionary.Keys)
            {
                Console.WriteLine("Key : " +key+" value : "+myDictionary[key]);
            }
        }
    }
    
}

using System;
using System.Collections;

namespace ConsoleApp1
{
    //Stack of Collection 
    class Program 
    {
        static void Main(string[] args)
        {
            Stack numbers = new Stack();

            // pushing into stack
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(1);
            numbers.Push(5);
            numbers.Push(4);

            Console.Write("Before Poping: ");
            showItems(numbers);

            // numbers.Peek() returns last inserted item but dont remove it
            // numbers.Pop() returns and remove last inserted item
            int last_item = (int)numbers.Pop();

            Console.WriteLine("Last item : "+last_item);
            Console.Write("After poping: ");
            showItems(numbers);
        }
        static void showItems(Stack keep)
        {
            foreach (int item in keep)
            {
                // reading items from top of stack to bottom of stack
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    
}

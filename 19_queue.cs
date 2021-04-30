using System;
using System.Collections;

namespace ConsoleApp1
{
    //Queue of Collection 
    class Program 
    {
        static void Main(string[] args)
        {
            Queue numbers = new Queue();

            // Adding items at last sequentially into Queue
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(1);
            numbers.Enqueue(5);
            numbers.Enqueue(4);

            Console.Write("Before Poping: ");
            showItems(numbers);

            // numbers.Dequeue() returns and remove first inserted item
            int first_item = (int)numbers.Dequeue();

            Console.WriteLine("first item : "+first_item);
            Console.Write("After Dequeing: ");
            showItems(numbers);
        }
        static void showItems(Queue keep)
        {
            foreach (int item in keep)
            {
                
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    
}

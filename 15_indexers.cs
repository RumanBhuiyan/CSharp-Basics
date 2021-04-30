using System;

namespace ConsoleApp1
{
    //Indexers is creating virtual array 
    class Program 
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            // using setter here
            prog[0] = "C";
            prog[1] = "C++";
            prog[2] = "Java";
            prog[3] = "C#";

            // using getter here 
            Console.WriteLine(prog[2]);

        }
       
        public string[] names = new string[5];

        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }

  
    }
    
}

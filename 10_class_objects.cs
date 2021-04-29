using System;

namespace ConsoleApp1
{
    class Program
    {
        double length;
        double width; 
        static void Main(string[] args)
        {

            Program prog = new Program();
            prog.setLength(4);
            prog.setWidth(5);

            Console.WriteLine("Length is : "+prog.getLength());
            Console.WriteLine("Width is : "+prog.getWidth());
            Console.WriteLine("Area is "+prog.getArea());
        }
        public Program()
        {
            this.length = 0;
            this.width = 0;
        }
        public void setLength(double len)
        {
            this.length = len;
        }
        public double getLength()
        {
            return this.length;
        }
        public void setWidth(double wid)
        {
            this.width = wid;
        }
        public double getWidth()
        {
            return this.width;
        }
        public double getArea()
        {
            return this.length * this.width;
        }
    }
}

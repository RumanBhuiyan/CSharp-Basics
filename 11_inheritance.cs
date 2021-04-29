using System;

namespace ConsoleApp1
{
    // Program class is inheriting Circle class where
    // parent class is Circle and Derived class is Program
    class Program : Circle
    {
        static void Main(string[] args)
        {
            // Inheritance 
            Program prog = new Program();
            prog.setRadius(2.5);

            Console.WriteLine("Radius is : "+prog.getRadius());
            Console.WriteLine("Circle area is : "+prog.getArea());
           
        }
       
    }

    // if you use sealed keyword before any class then other class cant
    // inherit it

    class Circle
    {
        private double radius;
        public Circle()
        {
            this.radius = 0;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public double getArea()
        {
            return Math.PI * (Math.Pow(this.radius, 2));
        }
    }

}

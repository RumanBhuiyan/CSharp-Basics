using System;

namespace ConsoleApp1
{
    // Program class is implementing or overriding methods of
    // abstract class Circle
    class Program : Circle
    {
        private double radius;
        static void Main(string[] args)
        {
            // Inheritance 
            Program prog = new Program();
            prog.setRadius(2.5);

            Console.WriteLine("Radius is : "+prog.getRadius());
            Console.WriteLine("Circle area is : "+prog.getArea());
           
        }
        // Implementing or overrding abstract class methods 
        public override void setRadius(double radius)
        {
            this.radius = radius;
        }
        public override double getRadius()
        {
            return this.radius;
        }
        public override double getArea()
        {
            return Math.PI * (Math.Pow(this.radius,2));
        }

    }
    
     abstract class Circle
    {
        public abstract void setRadius(double radius);
        public abstract double getRadius();
        public abstract double getArea();
    }

}

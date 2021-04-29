using System;

namespace ConsoleApp1
{
    // Implementing Circle Interface 
    class Program : Circle
    {
        private double radius;
        static void Main(string[] args)
        {
           
            Program prog = new Program();
            prog.setRadius(2.5);

            Console.WriteLine("Radius is : "+prog.getRadius());
            Console.WriteLine("Circle area is : {0:F3}",prog.getArea());
           
        }
        // Implementing interface methods
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public  double getArea()
        {
            return Math.PI * (Math.Pow(this.radius,2));
        }

    }
    
    interface Circle
    {
         void setRadius(double radius);
         double getRadius();
         double getArea();
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void printInfo()
        {
            try
            {
                Console.WriteLine($"Circle with Radius: {Radius}");
                Console.WriteLine($"Perimeter: {getPerimeter()}");
                Console.WriteLine($"Area: {getArea()}");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}

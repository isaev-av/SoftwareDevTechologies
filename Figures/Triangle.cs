using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Triangle : Figure
    {
        private Point Point1 { get; set; }
        private Point Point2 { get; set; }
        private Point Point3 { get; set; }

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public override double getArea()
        {
            var HalfPerimeter = getPerimeter() / 2;
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - FindSide(Point1, Point2)) * (HalfPerimeter - FindSide(Point2, Point3)) * (HalfPerimeter - FindSide(Point1, Point3)));
        }

        public override double getPerimeter()
        {
            return FindSide(Point1, Point2) + FindSide(Point2, Point3) + FindSide(Point1, Point3);
        }

        public override void printInfo()
        {
            try
            {
                Console.WriteLine($"Triangle: {Point1}, {Point2}, {Point3}");
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

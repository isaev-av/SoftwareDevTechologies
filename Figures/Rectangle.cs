using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Figures
{
    class Rectangle : Figure
    {
        private Point Point1 { get; set; }
        private Point Point2 { get; set; }
        private Point Point3 { get; set; }
        private Point Point4 { get; set; }

        public Rectangle(Point point1, Point point2, Point point3, Point point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }

        public override double getArea()
        {
            return FindSide(Point1, Point2) * FindSide(Point2, Point3);
        }

        public override double getPerimeter()
        {
            return (FindSide(Point1, Point2) + FindSide(Point2, Point3)) * 2;
        }

        public override void printInfo()
        {
            try
            {
                Console.WriteLine($"Rectangle: {Point1}, {Point2}, {Point3}, {Point4}");
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

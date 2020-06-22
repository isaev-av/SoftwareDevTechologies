using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    /// <summary>
    /// Abstract class for all figures
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Abstract method for getting perimeter of any figure
        /// </summary>
        public abstract double getPerimeter();

        /// <summary>
        /// Abstract method for getting area of any figure
        /// </summary>
        public abstract double getArea();

        /// <summary>
        /// Get the information about the figure
        /// </summary>
        public abstract void printInfo();

        /// <summary>
        /// Finds lenght between two points
        /// </summary>
        /// <param name="a">First point</param>
        /// <param name="b">Second point</param>
        /// <returns></returns>
        internal double FindSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }
    }
}

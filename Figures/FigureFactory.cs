using System;

namespace Figures
{
    /// <summary>
    /// Factory for creating figures based on metadata from file
    /// </summary>
    class FigureFactory
    {
        public static Rectangle CreateRectangle(string[] metadata)
        {
            if (metadata.Length != 5)
            {
                throw new ArgumentException();
            }
            
            return new Rectangle
                (
                    new Point(Int32.Parse(metadata[1].Trim().Split(" ")[0]), Int32.Parse(metadata[1].Trim().Split(" ")[1])),
                    new Point(Int32.Parse(metadata[2].Trim().Split(" ")[0]), Int32.Parse(metadata[2].Trim().Split(" ")[1])),
                    new Point(Int32.Parse(metadata[3].Trim().Split(" ")[0]), Int32.Parse(metadata[3].Trim().Split(" ")[1])),
                    new Point(Int32.Parse(metadata[4].Trim().Split(" ")[0]), Int32.Parse(metadata[4].Trim().Split(" ")[1]))
                );
        }

        internal static Circle CreateCircle(string[] metadata)
        {
            if (metadata.Length != 2 || Double.Parse(metadata[1].Trim()) <= 0)
            {
                throw new ArgumentException();
            }
            return new Circle(Double.Parse(metadata[1].Trim()));
        }

        internal static Triangle CreateTriangle(string[] metadata)
        {
            if (metadata.Length != 4)
            {
                throw new ArgumentException();
            }
            return new Triangle
                (
                    new Point(Int32.Parse(metadata[1].Trim().Split(" ")[0]), Int32.Parse(metadata[1].Trim().Split(" ")[1])),
                    new Point(Int32.Parse(metadata[2].Trim().Split(" ")[0]), Int32.Parse(metadata[2].Trim().Split(" ")[1])),
                    new Point(Int32.Parse(metadata[3].Trim().Split(" ")[0]), Int32.Parse(metadata[3].Trim().Split(" ")[1]))
                );
        }
    }
}

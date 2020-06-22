using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Figures
{
    /// <summary>
    /// Manager for creating and printing figures
    /// </summary>
    public class FigureManager
    {
        private string Path { get; set; }

        public FigureManager() { }

        public FigureManager(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Creates and prints figures inputed in test file
        /// </summary>
        public void printFiguresInfo()
        {
            List<Figure> figures = new List<Figure>();

            Trace.WriteLine("Starting to parse input file...");
            List<string[]> listWithMetadata = ParseMetadataFromFile();
            foreach (string[] line in listWithMetadata)
            {
                switch (line[0].Trim())
                {
                    case "r":
                        Trace.WriteLine("Creating rectangle...");
                        figures.Add(FigureFactory.CreateRectangle(line));
                        break;
                    case "c":
                        Trace.WriteLine("Creating circle...");
                        figures.Add(FigureFactory.CreateCircle(line));
                        break;
                    case "t":
                        Trace.WriteLine("Creating triangle...");
                        figures.Add(FigureFactory.CreateTriangle(line));
                        break;
                }
            }

            foreach (Figure figure in figures)
            {
                figure.printInfo();
                Console.WriteLine();
            }
        }

        private List<string[]> ParseMetadataFromFile()
        {
            using var sr = new StreamReader(Path);

            List<string[]> listWithMetadata = new List<string[]>();
            if (Int32.TryParse(sr.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    listWithMetadata.Add(sr.ReadLine().Split(", "));
                }
            }
            else
            {
                Trace.TraceError("Can not parse number of figures");
            }
            return listWithMetadata;
        }
    }
}

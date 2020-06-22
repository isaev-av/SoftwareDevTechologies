using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Figures
{
    /// <summary>
    /// Manager for creating and printing figures
    /// </summary>
    class FigureManager
    {
        private string Path { get; set; }

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

            List<string[]> listWithMetadata = ParseMetadataFromFile();
            foreach (string[] line in listWithMetadata)
            {
                switch (line[0].Trim())
                {
                    case "r":
                        figures.Add(FigureFactory.CreateRectangle(line));
                        break;
                    case "c":
                        figures.Add(FigureFactory.CreateCircle(line));
                        break;
                    case "t":
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
                Console.Write("Can not parse number of figures");
            }
            return listWithMetadata;
        }
    }
}

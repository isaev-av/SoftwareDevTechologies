using System;
using System.IO;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureManager figureManager = new FigureManager(Path.Combine(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")), "input.txt"));
            figureManager.printFiguresInfo();
        }
    }
}

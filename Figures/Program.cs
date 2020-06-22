using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureManager figureManager = new FigureManager(Path.Combine(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")), "input.txt"));
            figureManager.printFiguresInfo();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(FigureManager));
            using var sww = new StringWriter();
            using XmlWriter writer = XmlWriter.Create(sww);

            xmlSerializer.Serialize(writer, figureManager);
            Console.WriteLine(sww.ToString());
        }
    }
}

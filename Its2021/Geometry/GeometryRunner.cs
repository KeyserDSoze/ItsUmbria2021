using Its2021.Geometry.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Geometry
{
    internal class GeometryRunner
    {
        public static void Run()
        {
            Console.WriteLine("1 per Triangolo, 2 per Cerchio, 3 per Quadrato, 4 per Punto");
            //IAreable geometry = GeometryFactory.GetPerimeterableFigure((GeometryType)int.Parse(Console.ReadLine()));
            IAreable geometry = GeometryFactory.GetFigure<IAreable>((GeometryType)int.Parse(Console.ReadLine()));
            IPerimeterable geometry2 = GeometryFactory.GetFigure<IPerimeterable>((GeometryType)int.Parse(Console.ReadLine()));
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"L'area è: {geometry.CalculateArea()}");
        }
    }
}

using Its2021.Geometry.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Geometry.Implementations
{
    public class Triangle : IInputable, IPerimeterable, IAreable
    {
        public double Side { get; private set; }
        public Triangle()
        {
        }

        public double CalculatePerimeter() => Side * 3;

        public double CalculateArea() => Side * Side / 2;

        public void ConfigureValues()
        {
            Console.WriteLine("Dammi il valore del lato");
            Side = double.Parse(Console.ReadLine());
            Console.WriteLine("Dammi il valore dell'altezza");
        }
    }
}

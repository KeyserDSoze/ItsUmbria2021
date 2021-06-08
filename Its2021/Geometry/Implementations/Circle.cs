using Its2021.Geometry.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Geometry.Implementations
{
    internal class Circle : IAreable, IPerimeterable, IInputable
    {
        private double Radius;
        public double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
        public void Input()
        {
            Console.WriteLine("Dammi il valore del raggio");
            Radius = double.Parse(Console.ReadLine());
        }
    }
}

using Its2021.Geometry.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Geometry.Implementations
{
    public class Square : IInputable, IAreable, IPerimeterable
    {
        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculatePerimeter()
        {
            return Side * 4;
        }
        private double Side;
        public void ConfigureValues()
        {
            Console.WriteLine("Inserisci il lato del quadrato");
            Side = double.Parse(Console.ReadLine());
        }
    }
}

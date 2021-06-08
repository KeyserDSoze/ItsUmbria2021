using Its2021.Geometry.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Geometry.Implementations
{
    class Point : IAreable, IPerimeterable
    {
        public double CalculateArea()
        {
            return 0;
        }

        public double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}

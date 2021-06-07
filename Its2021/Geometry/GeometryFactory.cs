using Its2021.Geometry.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Geometry.Abstractions
{
    public class GeometryFactory
    {
        public static IAreable GetGeometry(GeometryType type)
        {
            //, 3 per Quadrato, 4 per Pentagono
            IAreable areable = default;
            switch (type)
            {
                case GeometryType.Triangle:
                    areable = new Triangle();
                    break;
                case GeometryType.Circle:
                    areable = new Circle();
                    break;
                case GeometryType.Square:
                    areable = new Square();
                    break;
                default:
                    return default;
            }
            if (areable is IInputable)
                (areable as IInputable).ConfigureValues();
            return areable;
        }
    }
}

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
        public static IAreable GetAreableFigure(GeometryType type)
        {
            List<int> items = new List<int>();
            items.Add(0);
            List<object> items2 = new List<object>();
            items2.Add(3);
            items2.Add(4);
            items2.Add("");
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
                case GeometryType.Point:
                    areable = new Point();
                    break;
                default:
                    return default;
            }
            //if (areable is IInputable)
            //    (areable as IInputable).Input();
            (areable as IInputable)?.Input();
            //IInputable object1 = null;
            //if (areable is IInputable)
            //    object1 = (IInputable)areable;
            //if (object1 != null)
            //    object1.Input();
            return areable;
        }
        public static IPerimeterable GetPerimeterableFigure(GeometryType type)
        {
            //, 3 per Quadrato, 4 per Pentagono
            IPerimeterable perimeterable = default;
            switch (type)
            {
                case GeometryType.Triangle:
                    perimeterable = new Triangle();
                    break;
                case GeometryType.Circle:
                    perimeterable = new Circle();
                    break;
                case GeometryType.Square:
                    perimeterable = new Square();
                    break;
                case GeometryType.Point:
                    perimeterable = new Point();
                    break;
                default:
                    return default;
            }
            //if (areable is IInputable)
            //    (areable as IInputable).Input();
            (perimeterable as IInputable)?.Input();
            //IInputable object1 = null;
            //if (areable is IInputable)
            //    object1 = (IInputable)areable;
            //if (object1 != null)
            //    object1.Input();
            return perimeterable;
        }
        public static T GetFigure<T>(GeometryType type)
        {
            object instance = default;
            switch (type)
            {
                case GeometryType.Triangle:
                    instance = new Triangle();
                    break;
                case GeometryType.Circle:
                    instance = new Circle();
                    break;
                case GeometryType.Square:
                    instance = new Square();
                    break;
                case GeometryType.Point:
                    instance = new Point();
                    break;
                default:
                    return default;
            }
            (instance as IInputable)?.Input();
            if (!(instance is T))
                throw new ArgumentException($"{instance.GetType().FullName} is not a {typeof(T).FullName}");
            return (T)instance;
        }

        public static bool GetResponse()
        {
            bool response = SampleRequest();
            return response;
        }
        public static bool GetResponse2() => SampleRequest();
        private static bool SampleRequest()
            => new Random().Next(10) > 5;

    }
}

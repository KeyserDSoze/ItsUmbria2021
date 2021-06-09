using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Car
{
    public class CarRunner
    {
        public static void Run()
        {
            CarFactory carFactory = new FactoryV1();
            Car car = carFactory.Create("FC405OD", CarType.Coupe);
            Console.WriteLine(car);
            carFactory = new FactoryV2();
            Car carV2 = carFactory.Create("FC405V2", CarType.Coupe);
            Console.WriteLine(carV2);
        }
    }
}

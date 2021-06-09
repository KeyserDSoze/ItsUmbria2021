using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Car
{
    public abstract class CarFactory
    {
        public abstract Car Create(string plate, CarType type);
    }
}

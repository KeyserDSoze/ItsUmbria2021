using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Car
{
    public enum CarType
    {
        Suv,
        Coupe,
        Sportive
    }
    public abstract class Car
    {
        private protected CarType Type { get; }
        public string Plate { get; }
        public Car(CarType type, string plate)
        {
            Type = type;
            Plate = plate;
        }
        public override string ToString()
        {
            return $"{Type} {Plate}";
        }
    }
}

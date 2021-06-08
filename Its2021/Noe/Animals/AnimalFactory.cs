using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Noe
{
    internal class AnimalFactory
    {
        public static Animal Create(AnimalType type, string name)
        {
            switch (type)
            {
                case AnimalType.Herbivore:
                    return new Herbivore(name);
                case AnimalType.Carnivour:
                    return new Carnivour(name);
                default:
                    return default;
            }
        }
    }
}
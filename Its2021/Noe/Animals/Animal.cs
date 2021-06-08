using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Noe
{
    public abstract class Animal
    {
        public string Name { get; }
        public AnimalType Type { get; }
        public Animal(string name, AnimalType type)
        {
            Name = name;
            Type = type;
        }
        public virtual void Eat()
        {
            Console.WriteLine($"Ciao sono Noè ed ho dato da mangiare all'animale {Type} {Name}.");
        }
        public override string ToString()
        {
            return $"Io sono {Name} un {Type}";
        }
    }
}

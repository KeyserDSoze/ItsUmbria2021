using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Noe
{
    internal class Herbivore : Animal
    {
        public Herbivore(string name) : base(name, AnimalType.Herbivore)
        {
        }
        public override void Eat()
        {
            Console.WriteLine($"Ciao sono Noè ed ho dato da mangiare all'animale {Type} {Name} dell'erba.");
        }
    }
}

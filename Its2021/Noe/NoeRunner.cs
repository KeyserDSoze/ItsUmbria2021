using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.Noe
{
    public class NoeRunner
    {
        public static void Run()
        {
            Animal animal = AnimalFactory.Create(AnimalType.Herbivore, "tartaruga");
            Console.WriteLine(animal.ToString());
            animal.Eat();
            Animal animal2 = AnimalFactory.Create(AnimalType.Carnivour, "gatto");
            animal2.Eat();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.CardGame.Library.Base.Abstractions
{
    public abstract class Healer: Character
    {
        public Healer() : base() { }

        public Healer(string name) : base(name) { }

        public int Heal(Character target, int amount)
        {
            target.HealthPoint += amount;
            if(target.HealthPoint > target.MaxHealth)
            {
                target.HealthPoint = target.MaxHealth;
            }
            return target.HealthPoint;
        }
    }
}

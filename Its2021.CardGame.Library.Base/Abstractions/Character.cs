using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.CardGame.Library.Base.Abstractions
{
    public abstract class Character: GameObject, IAttacker, IDamageable 
    {
        private readonly string name = null;
        public Character()
        {
            HealthPoint = MaxHealth;
            ManaPoint = MaxMana;
        }
        public Character(string _name) : this()
        {
            this.name = _name;
        }

        public virtual string DefaultName => GetType().Name;

        public virtual string Name
        {
            get
            {
                if (!string.IsNullOrEmpty(name)) {
                    return name;
                }
                else
                {
                    return DefaultName;
                }
            }
        }

        public abstract CharacterClass CharacterClass { get;}

        public abstract int BaseHealth { get; }
        public int MaxHealth => BaseHealth * LevelWeight();

        public abstract int BaseMana { get; }
        public int MaxMana => BaseMana * LevelWeight();

        public int HealthPoint { get; set; } = 100;
        public int ManaPoint { get; set; }


        public int Level { get; set; } = 1;
        public int LevelWeight() => 1 + (int)((Level - 1) * 0.2);

        public abstract int BaseDamage { get; }
        public abstract int BaseDefense { get; }

        public virtual void PrintInfo() => Console.WriteLine($"{name} --> Health {HealthPoint}, Mana {ManaPoint} ");

        public void Attack(Character target)
        {
            Console.WriteLine($"{name} attacking {target.Name}");
            target.GetDamage(BaseDamage);
        }

        public int GetDamage(int amount)
        {
            int weightedDamage = amount - BaseDefense;

            if(weightedDamage < 0)
            {
                weightedDamage = 0;
            }

            HealthPoint = HealthPoint - weightedDamage;

            if(HealthPoint < 0) { HealthPoint = 0; }

            Console.WriteLine($"{name} gets {weightedDamage} damages. HealthPoint = {HealthPoint}");
            return HealthPoint;
        }
    }
}

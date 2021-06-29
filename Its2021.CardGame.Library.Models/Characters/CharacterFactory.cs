using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.CardGame.Library.Models.Characters
{
    public class CharacterFactory
    {
        public Character Create(string name = null)
        {
            var randomCharacter = (CharacterClass)(new Random((int)DateTime.UtcNow.Millisecond).Next(0,3));
            return this.Create(randomCharacter, name);
        }

        public Character Create(CharacterClass characterClass, string name =null) {

            switch (characterClass)
            {
                default:
                case CharacterClass.Fighter:
                    return new Fighter(name);
                case CharacterClass.Barbarian:
                    return new Barbarian(name);
                case CharacterClass.Cleric:
                    return new Cleric(name);
                case CharacterClass.Ranger:
                    return new Ranger(name);
                case CharacterClass.Rogue:
                    return new Rogue(name);
                case CharacterClass.Wizard:
                    return new Wizard(name);
            }
        }
    }
}

using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Base.Interfaces;

namespace Its2021.CardGame.Library.Models.Characters
{
    public class Barbarian : Character, IMelee
    {
        public Barbarian() : base() { }

        public Barbarian(string name) : base(name) { }

        public override int BaseHealth => 50;

        public override int BaseMana => 0;

        public override int BaseDamage => 5;

        public override int BaseDefense => 3;

        public override CharacterClass CharacterClass => CharacterClass.Barbarian;
    }
}

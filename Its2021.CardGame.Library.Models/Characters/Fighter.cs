using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Base.Interfaces;

namespace Its2021.CardGame.Library.Models.Characters
{
    public class Fighter : Character, IMelee
    {
        public Fighter() : base() { }

        public Fighter(string name): base(name) { }

        public override int BaseHealth => 40;

        public override int BaseMana => 0;

        public override int BaseDamage => 5;

        public override int BaseDefense => 4;

        public override CharacterClass CharacterClass => CharacterClass.Fighter;
    }
}

using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Base.Interfaces;

namespace Its2021.CardGame.Library.Models.Characters
{
    public class Rogue : Character, IMelee, IRanged
    {
        public Rogue():base() { }
        public Rogue(string name) : base(name) { }

        public override int BaseHealth => 30;

        public override int BaseMana => 0;

        public override int BaseDamage => 3;

        public override int BaseDefense => 2;

        public override CharacterClass CharacterClass => CharacterClass.Rogue;

        public void ThrowRangedAttack(Character target)
            => Actions.ThrowRangedAttack.Do(this, target);
    }
}

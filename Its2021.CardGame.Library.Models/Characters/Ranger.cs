using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Base.Interfaces;

namespace Its2021.CardGame.Library.Models.Characters
{
    public class Ranger : Healer, IDivine, IRanged, IMelee
    {
        public Ranger() : base() { }
        public Ranger(string name) : base(name) { }

        public override int BaseHealth => 40;

        public override int BaseMana => 0;

        public override int BaseDamage => 4;

        public override int BaseDefense => 3;

        public override CharacterClass CharacterClass => CharacterClass.Ranger;

        public void CastPrayer(Character target) => Actions.CastPrayer.Do(this, target);

        public void ThrowRangedAttack(Character target)
            => Actions.ThrowRangedAttack.Do(this, target);
    }
}

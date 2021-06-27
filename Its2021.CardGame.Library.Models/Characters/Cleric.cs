using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Base.Interfaces;

namespace Its2021.CardGame.Library.Models.Characters
{
    public class Cleric : Healer, IMelee, IDivine
    {
        public Cleric() : base(){}
        public Cleric(string name) : base(name) { }

        public override int BaseHealth => 30;

        public override int BaseMana => 20;

        public override int BaseDamage => 2;

        public override int BaseDefense => 4;

        public override CharacterClass CharacterClass => CharacterClass.Cleric;

        public void CastPrayer(Character target) => Actions.CastPrayer.Do(this, target);
    }
}

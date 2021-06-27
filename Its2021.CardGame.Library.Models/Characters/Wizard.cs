using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Base.Interfaces;

namespace Its2021.CardGame.Library.Models.Characters
{
    public class Wizard : Character, ISpell
    {
        public Wizard() : base() { }
        public Wizard(string name): base(name) { }

        public override int BaseHealth => 20;

        public override int BaseMana => 50;

        public override int BaseDamage => 1;

        public override int BaseDefense => 1;

        public override CharacterClass CharacterClass => CharacterClass.Wizard;

        public void ThrowSpell(Character target) => Actions.ThrowSpell.Do(this, target);

    }
}

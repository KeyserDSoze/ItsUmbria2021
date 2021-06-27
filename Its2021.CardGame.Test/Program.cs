using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Models.Characters;
using System;

namespace Its2021.CardGame.Test
{
    class Program
    {
        public static CharacterFactory characterFactory = new CharacterFactory();
        static void Main(string[] args)
        {
            var test = characterFactory.Create(CharacterClass.Rogue, "Lupin");
        }
    }
}

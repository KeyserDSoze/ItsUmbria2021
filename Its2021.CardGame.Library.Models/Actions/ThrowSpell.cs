using Its2021.CardGame.Library.Base.Abstractions;
using System;

namespace Its2021.CardGame.Library.Models.Actions
{
    public static class ThrowSpell
    {
        public static void Do(Character executor, Character target)
        {
            Console.WriteLine($"{executor.Name} hit with a magic {target.Name}");
        }
    }
}

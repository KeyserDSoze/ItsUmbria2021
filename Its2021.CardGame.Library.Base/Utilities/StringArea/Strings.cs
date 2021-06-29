using System;

namespace Its2021.CardGame.Library.Base.Utilities.StringArea
{
    public static class Strings
    {
        public static string GetUniqueGuid() => Guid.NewGuid().ToString();
    }
}

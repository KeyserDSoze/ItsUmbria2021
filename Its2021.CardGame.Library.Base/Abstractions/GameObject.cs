using System;

namespace Its2021.CardGame.Library.Base.Abstractions
{
    public class GameObject
    {
        public string Id { get; } = Guid.NewGuid().ToString();
    }
}

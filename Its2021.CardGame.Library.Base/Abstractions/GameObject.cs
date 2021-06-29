using Its2021.CardGame.Library.Base.Utilities.Primitives;
using Its2021.CardGame.Library.Base.Utilities.StringArea;

namespace Its2021.CardGame.Library.Base.Abstractions
{
    public class GameObject
    {
        public string Id { get; } = Strings.GetUniqueGuid();

        public Vector Position { get; set; } = Vector.Zero;
    }
}

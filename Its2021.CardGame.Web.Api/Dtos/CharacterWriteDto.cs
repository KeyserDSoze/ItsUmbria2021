using Its2021.CardGame.Library.Base.Enumerator;

namespace Its2021.CardGame.Web.Api.Dtos
{
    public class CharacterWriteDto
    {
        public string Name { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }
}

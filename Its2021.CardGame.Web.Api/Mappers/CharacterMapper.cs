using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Web.Api.Dtos;

namespace Its2021.CardGame.Web.Api.Mappers
{
    public class CharacterMapper
    {
        public CharacterReadDto Map(Character character)
        {
            return new CharacterReadDto()
            {
                Name = character.Name,
                CharacterClass = character.CharacterClass,
                BaseDamage = character.BaseDamage,
                BaseDefense = character.BaseDefense,
                BaseHealth = character.BaseHealth,
                BaseMana = character.BaseMana
            };
        }

    }
}

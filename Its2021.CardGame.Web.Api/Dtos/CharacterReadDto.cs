using Its2021.CardGame.Library.Base.Enumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Its2021.CardGame.Web.Api.Dtos
{
    public class CharacterReadDto
    {
        public string Name { get; set; }

        public int BaseHealth { get; set; }

        public int BaseMana { get; set; }

        public int BaseDamage { get; set; }

        public int BaseDefense { get; set; }

        public CharacterClass CharacterClass { get; set; }
    }
}

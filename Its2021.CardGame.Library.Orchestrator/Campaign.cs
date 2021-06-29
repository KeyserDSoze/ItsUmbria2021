using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Utilities.StringArea;
using System.Collections.Generic;

namespace Its2021.CardGame.Library.Orchestrator
{
    public class Campaign
    {
        public Campaign(string name) => Name = name;

        public string Id { get; } = Strings.GetUniqueGuid();

        public string Name { get; }

        public List<Character> Characters { get; } = new List<Character>();

        public void AddCharacter(Character character) => this.Characters.Add(character);

        public void RemoveCharacter(Character character) => this.Characters.Remove(character);

        public void AddCharacters(params Character[] characters) => this.Characters.AddRange(characters);

        public void RemoveCharacters(params Character[] characters)
        {
            foreach(var c in characters)
            {
                this.Characters.Remove(c);
            }
        }
    }
}

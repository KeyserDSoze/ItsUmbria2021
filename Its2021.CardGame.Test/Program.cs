using Its2021.CardGame.Library.Base.Abstractions;
using Its2021.CardGame.Library.Base.Enumerator;
using Its2021.CardGame.Library.Models.Characters;
using Its2021.CardGame.Library.Orchestrator;
using System;
using System.Collections.Generic;

namespace Its2021.CardGame.Test
{
    class Program
    {
        public static CharacterFactory characterFactory = new CharacterFactory();
        static void Main(string[] args)
        {
            //var test = characterFactory.Create(CharacterClass.Rogue, "Lupin");


            //var myCampaign = new Campaign("Vinceremo");

            //myCampaign.AddCharacters(
            //    characterFactory.Create(CharacterClass.Barbarian, "Conan2"),
            //    characterFactory.Create(CharacterClass.Barbarian, "Conan3"),
            //    characterFactory.Create("random1"),
            //    characterFactory.Create(CharacterClass.Barbarian, "Conan5"),
            //    characterFactory.Create(CharacterClass.Barbarian, "Conan6")
            //    );

            var myCampaign = CampaignManager.Instace().CreateCampaign("vinceremo-bis");
            myCampaign.AddCharacters(
                characterFactory.Create(CharacterClass.Barbarian, "Conan2"),
                characterFactory.Create(CharacterClass.Barbarian, "Conan3"),
                characterFactory.Create("random1"),
                characterFactory.Create(CharacterClass.Barbarian, "Conan5"),
                characterFactory.Create(CharacterClass.Barbarian, "Conan6")
                );
            var list = CampaignManager.Campaigns;

            CampaignManager.Instace().PrintAllCharacters();
        }
    }
}

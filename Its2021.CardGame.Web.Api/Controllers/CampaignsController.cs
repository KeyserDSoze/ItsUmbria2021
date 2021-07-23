using Its2021.CardGame.Library.Models.Characters;
using Its2021.CardGame.Library.Orchestrator;
using Its2021.CardGame.Web.Api.Dtos;
using Its2021.CardGame.Web.Api.Mappers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Its2021.CardGame.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController : ControllerBase
    {
        private readonly CampaignManager campaignManager = CampaignManager.Instace();
        public static CharacterFactory characterFactory = new CharacterFactory();

        #region Campaigns

        // GET: api/Campaigns
        [HttpGet]
        public List<CampaignReadDto> GetCampaigns()
        {
            var x1 = CampaignManager.Campaigns;
            var x2 = x1.Select(s => s.Value).ToList();


            return CampaignManager.Campaigns
                .Select(s => s.Value).ToList()
                .Select(w=> new CampaignMapper().Map(w)).ToList();
        }

        // GET api/Campaigns/{id}
        [HttpGet("{id}")]
        public CampaignReadDto GetCampaign(string id)
        {
            return new CampaignMapper().Map(CampaignManager.Campaigns[id]);
        }

        // POST api/Campaigns
        [HttpPost]
        public CampaignReadDto Post([FromBody] CampaignWriteDto campaign)
        {
             return new CampaignMapper().Map(campaignManager.CreateCampaign(campaign.Name));
        }

        // PUT api/Campaigns/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] CampaignWriteDto campaign)
        {
            campaignManager.RemoveCampaign(id);
            CampaignManager.Campaigns[id] = campaignManager.CreateCampaign(campaign.Name);

            return NoContent();
        }

        // DELETE api/Campaigns/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            campaignManager.RemoveCampaign(id);

            return NoContent();
        }

        #endregion

        #region Characters

        // GET: api/Campaigns/{id}/Characters
        [HttpGet("{id}/Characters")]
        public List<CharacterReadDto> GetCampaignCharacters(string id)
        {
            return CampaignManager.Campaigns[id].Characters
                .Select(s=> new CharacterMapper().Map(s) ).ToList();
        }

        // GET: api/Campaigns/{id}/Characters/{name}
        [HttpGet("{id}/Characters/{name}")]
        public CharacterReadDto GetCampaignCharacters(string id, string name)
        {
            return CampaignManager.Campaigns[id].Characters
                .Where(w => w.Name == name)
                .Select(s => new CharacterMapper().Map(s))
                .FirstOrDefault();
        }

        // POST api/Campaigns/{id}/Characters
        [HttpPost("{id}/Characters")]
        public CharacterReadDto PostCreateCharacter(
            [FromRoute]string id, 
            [FromBody] CharacterWriteDto character)
        {
            var characterCreate = characterFactory.Create(character.CharacterClass, character.Name);
            CampaignManager.Campaigns[id].AddCharacter(characterCreate);

            return new CharacterMapper().Map(characterCreate);
        }

        //POST con LIST
        //// POST api/Campaigns/{id}/Characters
        //[HttpPost("{id}/Characters/list")]
        //public List<CharacterReadDto> PostCreateCharacters(
        //    [FromRoute] string id,
        //    [FromBody] List<CharacterWriteDto> characters)
        //{
        //    List<CharacterReadDto> result = new List<CharacterReadDto>();

        //    foreach (var c in characters)
        //    {
        //        var characterCreate = characterFactory.Create(c.CharacterClass, c.Name);
        //        CampaignManager.Campaigns[id].AddCharacter(characterCreate);
        //        result.Add(new CharacterMapper().Map(characterCreate));
        //    }

        //    return result;
        //}


        // DELETE api/Campaigns/{id}/Characters/{id}
        [HttpDelete("{idCampaign}/Characters/{id}")]
        public IActionResult DeleteCharacter(string idCampaign, string name)
        {
            var character = CampaignManager.Campaigns[idCampaign].Characters
                .Where(w => w.Name == name)
                .FirstOrDefault();

            CampaignManager.Campaigns[idCampaign].RemoveCharacter(character);

            return NoContent();
        }

        #endregion

    }
}

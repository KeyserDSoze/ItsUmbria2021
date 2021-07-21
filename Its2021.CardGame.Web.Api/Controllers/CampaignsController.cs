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

        //// GET: api/Campaigns/{id}/Characters
        //[HttpGet("{id}/Characters")]
        //public List<CharacterReadDto> GetCharacters()
        //{
        //    var x1 = CampaignManager.Campaigns;
        //    var x2 = x1.Select(s => s.Value).ToList();


        //    return CampaignManager.Campaigns
        //        .Select(s => s.Value).ToList()
        //        .Select(w => new CampaignMapper().Map(w)).ToList();
        //}

        #endregion

    }
}

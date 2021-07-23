using Its2021.CardGame.Library.Orchestrator;
using Its2021.CardGame.Web.Api.Dtos;

namespace Its2021.CardGame.Web.Api.Mappers
{
    public class CampaignMapper
    {
        public CampaignReadDto Map(Campaign campaign)
        {
            return new CampaignReadDto()
            {
                Id = campaign.Id,
                Name = campaign.Name
            };
        }

        public Campaign Map(CampaignWriteDto campaign)
        {
            return new Campaign(campaign.Name);
        }
    }
}

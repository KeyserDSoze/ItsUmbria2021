using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.CardGame.Library.Orchestrator
{
    public class CampaignManager
    {
        private static object trafficLight = new object();
        private static CampaignManager campaignManager = null;

        public static CampaignManager Instace()
        {
            if(campaignManager == null)
            {
                lock (trafficLight)
                {
                    if (campaignManager == null)
                    {
                        campaignManager = new CampaignManager();
                    }
                }
            }
            return campaignManager;
        }

        public static Dictionary<string, Campaign> Campaigns { get; } = new Dictionary<string, Campaign>();

        public Campaign GetCampaign(string id, string name) 
        {
            string tempId = id;

            if (!Campaigns.ContainsKey(tempId))
            {
                lock (trafficLight)
                {
                    if (!Campaigns.ContainsKey(tempId))
                    {
                        tempId = CreateCampaign(name).Id;
                    }
                }
            }

            return Campaigns[tempId];
        }

        public Campaign CreateCampaign(string name) {

            var myCampaign = new Campaign(name);
            Campaigns.Add(myCampaign.Id, myCampaign);

            return myCampaign;
        }

        public void RemoveCampaign(string id) {
            Campaigns.Remove(id);
        }

        public void PrintAllCharacters() {
        
            foreach(KeyValuePair<string, Campaign> c in Campaigns)
            {
                foreach(var ch in c.Value.Characters)
                {
                    ch.PrintInfo();
                }
            }
        }

    }
}

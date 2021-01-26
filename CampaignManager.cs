using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        Campaign[]  Campaigns;

        public CampaignManager()
        {
            Campaigns = new Campaign[0];
        }
        public void Add(Campaign campaign)
        {
            Campaign[] tempArray = Campaigns;
            Campaigns = new Campaign[Campaigns.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Campaigns[i] = tempArray[i];
                Console.WriteLine("This campaign is added" + Campaigns[i]);
            }
            Campaigns[Campaigns.Length - 1] = campaign;
        }

        public void Delete(Campaign campaign)
        {
            Campaign[] campaigns = Campaigns;
            Campaigns = new Campaign[Campaigns.Length - 1];
            for (int i = 0; i < Campaigns.Length; i++)
            {
                Campaigns[i] = Campaigns[Campaigns.Length - 1];
                Console.WriteLine("This game is deleted" + Campaigns[i]);
            }
        }

        public void Update(Campaign campaign)
        {
            int i;
            for (i = 0; i < campaign.CampaignId; i++)
            {
                Console.WriteLine("The campaign is updated : ");
            }
        }
    }
}

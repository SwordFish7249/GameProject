using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Campaign : IGameService
    {
        Campaign[] Campaigns;

        public Campaign()
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
                Console.WriteLine("Our new campaign is : " + Campaigns[i]);
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
                Console.WriteLine("Our campaign is finished" + Campaigns[i]);
            }
        }

        public void Sales(Campaign[] campaigns)
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign);
            }
        }

        public void Save(Campaign campaign)
        {
            Campaign[] tempArray = Campaigns;
            Campaigns = new Campaign[Campaigns.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Campaigns[i] = tempArray[i];
                Console.WriteLine("Our campaign is adding and continue " + Campaigns[i]);
            }
            Campaigns[Campaigns.Length - 1] = campaign;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

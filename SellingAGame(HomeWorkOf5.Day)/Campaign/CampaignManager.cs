using System;
using System.Collections.Generic;
using System.Text;

namespace SellingAGame_HomeWorkOf5.Day_
{
    class CampaignManager
    {
        public void GiveCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + ":" +" "+"Done");
        }

        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : " + "Added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : " + "Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " : " + "Updated");
        }


    }
}

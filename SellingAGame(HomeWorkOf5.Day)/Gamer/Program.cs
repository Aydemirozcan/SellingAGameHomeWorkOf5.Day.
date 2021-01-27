using System;

namespace SellingAGame_HomeWorkOf5.Day_
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();

            gamer1.GamerFirstName = "Aydemir";
            gamer1.GamerLastName = "Özcan";
            gamer1.GamerNationaltyId = "13162726008";
            gamer1.GamerBirthDate = "04.08.1996";

            Gamer gamer = new Gamer();


            GamerManager gamerManager = new GamerManager();       
            gamerManager.Add(gamer1);


            Game GTA= new Game();
            GTA.GameName = "GTA";
            GTA.Price = "100TL";


            SellManager sellManager = new SellManager();
            sellManager.Sell(GTA, gamer1);


            Campaign campaign1 = new Campaign();

            campaign1.CampaignName = "newYearCampaign";
            

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.GiveCampaign(campaign1);
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);

        }
    }
}

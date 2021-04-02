using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Adapters;
using GamePlayerCampaign.Concrete;
using System;
using GamePlayerCampaign.Entities;

namespace GamePlayerCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserVerificationManager());

            Player player1 = new Player() { Id = 1, BirthYear = 1234, FirstName = "Sedat", LastName = "Gökhan", NationalityId = "123456789", NickName = "Sym" };
            playerManager.Add(player1);

            Game game1 = new Game()
            { Id = 1, GameName = "Diablo 2 Resurrected", GamePrice = 39.99 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Campaign campaign1 = new Campaign() { Id = 1, Name = "Spring Sale", Discount = 45 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            BaseOrderManager orderManager = new CampaignOrderManager(campaign1);
            orderManager.AddToCart(game1, player1);
        }
    }
}

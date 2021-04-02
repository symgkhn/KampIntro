using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlayerCampaign.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " is added by $ " + game.GamePrice + " to the system.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " is deleted from the system.");
        }
    }
}

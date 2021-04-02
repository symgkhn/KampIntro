using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Concrete;
using GamePlayerCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlayerCampaign.Entities
{
    public class Game
    {

        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}

using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlayerCampaign.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}

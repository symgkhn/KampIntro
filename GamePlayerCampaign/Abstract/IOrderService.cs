using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlayerCampaign.Abstract
{
    public interface IOrderService
    {
        void AddToCart(Game game, Player player);
        void DeleteFromCart(Game game, Player player);
    }
}

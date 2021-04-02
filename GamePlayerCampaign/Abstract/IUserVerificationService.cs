using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlayerCampaign.Abstract
{
    public interface IUserVerificationService
    {
        bool Validate(Player player);
    }
}

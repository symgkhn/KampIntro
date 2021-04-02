using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlayerCampaign.Concrete
{
    class PlayerManager : IPlayerService
    {
        private IUserVerificationService _userVerificationService;

        public PlayerManager(IUserVerificationService userVerificationService)
        {
            _userVerificationService = userVerificationService;
        }
        public void Add(Player player)
        {
            if (_userVerificationService.Validate(player))
            {
                Console.WriteLine("Player " + player.NickName + " is added to the server.");
                player.Verification = true;
            }
            else
            {
                Console.WriteLine("Player is not valid");
                player.Verification = false;
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player " + player.NickName + " is deleted from the server.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player " + player.NickName + " is updated to the server.");
        }
    }
}

using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using UserVerificationServiceReference;

namespace GamePlayerCampaign.Adapters
{
    public class UserVerificationManager : IUserVerificationService
    {
        public bool Validate(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

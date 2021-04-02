using GamePlayerCampaign.Abstract;
using GamePlayerCampaign.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlayerCampaign.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int BirthYear { get; set; }
        public string NationalityId { get; set; }
        public bool Verification { get; set; }
    }
}

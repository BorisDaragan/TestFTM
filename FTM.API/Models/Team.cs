using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FTM.API.Models
{
    public enum PlayerPosition
    {
        Goalkeeper, Back, Midfield, Forward
    }

    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }

        public virtual  ICollection<Player> Players { get; set; }
    }
}
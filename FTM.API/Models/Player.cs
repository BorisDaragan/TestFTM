using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FTM.API.Models
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public PlayerPosition Position { get; set; }

        public virtual Team Team { get; set; }
    }
}
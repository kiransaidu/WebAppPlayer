using System;
using System.Collections.Generic;

namespace WebAppPlayer.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? JerseyNumber { get; set; }
        public string? Position { get; set; }
        public string? Team { get; set; }
    }
}

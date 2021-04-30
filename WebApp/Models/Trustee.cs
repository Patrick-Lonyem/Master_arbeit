using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Trustee
    {
        public int Id { get; set; }
        public bool Delivers { get; set; }
        public decimal DeliverDistance { get; set; }
        public bool RequiresIdentification { get; set; }
        public decimal Commision { get; set; }
        public decimal MaxRadius { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}

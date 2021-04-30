using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}

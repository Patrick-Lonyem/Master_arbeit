using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class User
    {
        public User()
        {
            Customers = new HashSet<Customer>();
            Trustees = new HashSet<Trustee>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Trustee> Trustees { get; set; }
    }
}

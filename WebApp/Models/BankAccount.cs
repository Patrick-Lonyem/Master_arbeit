using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models
{
    public partial class BankAccount
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }
}

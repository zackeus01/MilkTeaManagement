using System;
using System.Collections.Generic;

namespace MilkTea.Models
{
    public partial class Account
    {
        public Account()
        {
            Products = new HashSet<Product>();
        }

        public int AccountId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }
        public int? BranchId { get; set; }
        public string? Name { get; set; }
        public bool? Gender { get; set; }
        public DateTime Dob { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Image { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual Role? Role { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

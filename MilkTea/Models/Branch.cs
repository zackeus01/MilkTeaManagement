using System;
using System.Collections.Generic;

namespace MilkTea.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Accounts = new HashSet<Account>();
            Orders = new HashSet<Order>();
        }

        public int BranchId { get; set; }
        public string? BranchName { get; set; }
        public int? ManagerId { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

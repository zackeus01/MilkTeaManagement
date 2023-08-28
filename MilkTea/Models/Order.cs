using System;
using System.Collections.Generic;

namespace MilkTea.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public double? Total { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? BranchId { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MilkTea.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProIngs = new HashSet<ProIng>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int CategoryId { get; set; }
        public int? Quantity { get; set; }
        public double Price { get; set; }
        public string? Origin { get; set; }
        public string? Image { get; set; }
        public int? ManagerId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Account? Manager { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProIng> ProIngs { get; set; }
    }
}

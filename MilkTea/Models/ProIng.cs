using System;
using System.Collections.Generic;

namespace MilkTea.Models
{
    public partial class ProIng
    {
        public int ProIngId { get; set; }
        public int? ProductId { get; set; }
        public int? IngredientId { get; set; }

        public virtual Ingredient? Ingredient { get; set; }
        public virtual Product? Product { get; set; }
    }
}

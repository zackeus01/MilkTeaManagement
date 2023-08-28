using System;
using System.Collections.Generic;

namespace MilkTea.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            ProIngs = new HashSet<ProIng>();
        }

        public int IngredientId { get; set; }
        public string? IngredientName { get; set; }
        public string? Image { get; set; }
        public int? Role { get; set; }

        public virtual ICollection<ProIng> ProIngs { get; set; }
    }
}

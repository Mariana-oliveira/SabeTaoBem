using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.RecipeIngredients
{
    public class RecipeIngredient
    {
        public int IdRecipe { get; set; }
        public int IdIngredient { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public byte UnitId { get; set; }
    }
}

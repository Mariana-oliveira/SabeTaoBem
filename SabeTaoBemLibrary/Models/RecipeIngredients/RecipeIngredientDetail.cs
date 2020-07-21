using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.RecipeIngredients
{
    public class RecipeIngredientDetail
    {
        public int idrecipe { get; set; }
        public string RecipeName { get; set; }
        public int IdIngredient { get; set; }
        public string IngredientName { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public byte UnitId { get; set; }
        public string UnitName { get; set; }
    }
}

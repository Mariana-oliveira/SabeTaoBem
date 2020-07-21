using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Ingredients
{
    public class Ingredient
    {
        public int IdIngredient { get; set; }
        public string IngredientName { get; set; }
        public byte IngCategoryId { get; set; }
    }
}

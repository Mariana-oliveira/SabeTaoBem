using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.RecipeIngredients
{
    public class RecipeByIng
    {
        public int IdIngredient { get; set; }
        public string IngredientName { get; set; }
        public int idRecipe { get; set; }
        public string RecipeName { get; set; }
        public byte RecCategoryId { get; set; }
        public string Category { get; set; }
        public int userid { get; set; }
        public string Username { get; set; }
    }
}

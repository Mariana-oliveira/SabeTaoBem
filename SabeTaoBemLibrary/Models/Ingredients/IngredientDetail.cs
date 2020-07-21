using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Ingredients
{
    public class IngredientDetail
    {
        public int idIngredient { get; set; }
        public string IngredientName { get; set; }
        public byte ingCategoryId { get; set; }
        public string category { get; set; }
    }
}

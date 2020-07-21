using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Recipes
{
    public class RecipeDetail
    {
        public int idrecipe { get; set; }
        public string RecipeName { get; set; }
        public int userid { get; set; }
        public string Username { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public byte RecCategoryId { get; set; }
        public string Category { get; set; }
        public byte RecFoodStyleId { get; set; }
        public string FoodStyle { get; set; }
        public byte RecDifficultyLevelId { get; set; }
        public string DifficultyLevel { get; set; }
        public byte RecMealCostId { get; set; }
        public string MealCost { get; set; }
        public int PreparationTime { get; set; }
        public int CookTime { get; set; }
        public int Doses { get; set; }
        public Nullable<decimal> Evaluation { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public byte idStatus { get; set; }
        public string Status { get; set; }

    }
}

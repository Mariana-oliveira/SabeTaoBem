using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SabeTaoBem_MVC.Models.Recipes
{
    public class Recipe
    {
        public int IdRecipe { get; set; }
        public string RecipeName { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public byte RecCategoryId { get; set; }
        public byte RecFoodStyleId { get; set; }
        public byte RecDifficultyLevelId { get; set; }
        public byte RecMealCostId { get; set; }
        public int PreparationTime { get; set; }
        public int CookTime { get; set; }
        public int Doses { get; set; }
        public Nullable<decimal> Evaluation { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public byte idStatus { get; set; }
    }
}
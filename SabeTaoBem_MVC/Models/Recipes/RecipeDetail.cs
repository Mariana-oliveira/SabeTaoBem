using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SabeTaoBem_MVC.Models.Recipes
{
    public class RecipeDetail
    {
        public int idrecipe { get; set; }
        [DisplayName("Nome da Receita")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string RecipeName { get; set; }
        public int userid { get; set; }
        public string Username { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        [DisplayName("Primeiro Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public byte RecCategoryId { get; set; }
        public string Category { get; set; }
        public byte RecFoodStyleId { get; set; }
        public string FoodStyle { get; set; }
        public byte RecDifficultyLevelId { get; set; }
        public string DifficultyLevel { get; set; }
        public byte RecMealCostId { get; set; }
        [DisplayName("Custo da Refeição")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string MealCost { get; set; }
        [DisplayName("Tempo de Preparação")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int PreparationTime { get; set; }
        [DisplayName("Tempo de Cozedura")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int CookTime { get; set; }
        [DisplayName("Doses")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int Doses { get; set; }
        public Nullable<decimal> Evaluation { get; set; }
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public byte idStatus { get; set; }
        public string Status { get; set; }

        public string RecipeRegErrorMessage { get; set; } 
    }
}
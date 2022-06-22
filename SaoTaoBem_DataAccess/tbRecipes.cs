//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaoTaoBem_DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbRecipes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRecipes()
        {
            this.tbComments = new HashSet<tbComments>();
            this.tbRecipeIngredient = new HashSet<tbRecipeIngredient>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbComments> tbComments { get; set; }
        public virtual tbRecipeCategory tbRecipeCategory { get; set; }
        public virtual tbRecipeDifficultyLevel tbRecipeDifficultyLevel { get; set; }
        public virtual tbRecipeFoodStyle tbRecipeFoodStyle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRecipeIngredient> tbRecipeIngredient { get; set; }
        public virtual tbRecipeMealCost tbRecipeMealCost { get; set; }
        public virtual tbStatus tbStatus { get; set; }
        public virtual tbUsers tbUsers { get; set; }
    }
}
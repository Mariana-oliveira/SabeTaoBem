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
    
    public partial class tbRecipeDifficultyLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRecipeDifficultyLevel()
        {
            this.tbRecipes = new HashSet<tbRecipes>();
        }
    
        public byte IdRecDiffLevel { get; set; }
        public string DifficultyLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRecipes> tbRecipes { get; set; }
    }
}

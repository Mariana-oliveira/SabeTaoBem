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
    
    public partial class tbIngredientCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbIngredientCategory()
        {
            this.tbIngredients = new HashSet<tbIngredients>();
        }
    
        public byte IdIngCategory { get; set; }
        public string Category { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIngredients> tbIngredients { get; set; }
    }
}

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
    
    public partial class spSelCommentDetail_Result
    {
        public int idComment { get; set; }
        public string Comment { get; set; }
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public int Userid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public Nullable<System.DateTime> commentdate { get; set; }
        public byte statusid { get; set; }
        public string status { get; set; }
    }
}
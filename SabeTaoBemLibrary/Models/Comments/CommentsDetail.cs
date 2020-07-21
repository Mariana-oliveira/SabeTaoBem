using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Comments
{
    public class CommentsDetail
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

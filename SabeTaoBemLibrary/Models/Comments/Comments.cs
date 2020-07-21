using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Comments
{
    public class Comments
    {
        public int IdComment { get; set; }
        public string Comment { get; set; }
        public int RecipeId { get; set; }
        public  int UserId { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public byte StatusID { get; set; }

    }
}

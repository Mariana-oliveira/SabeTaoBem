using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SabeTaoBem_MVC.Models.Users
{
    public class User
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public byte UserFunctionId { get; set; }
        public int LoginId { get; set; }
        public byte StatusId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Users
{
    public class UsersLogin
    {

        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public byte UserFunctionId { get; set; }
        public int LoginId { get; set; }
        public byte StatusId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

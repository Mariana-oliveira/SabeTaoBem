using System;
using System.Collections.Generic;
using System.Text;

namespace SabeTaoBemLibrary.Models.Users
{
    public class UsersDetail
    {
        public int iduser { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> registrationDate { get; set; }
        public byte userfunctionid { get; set; }
        public string userfunction { get; set; }
        public int loginid { get; set; }
        public string username { get; set; }
        public byte StatusId { get; set; }
        public string Status { get; set; }
    }
}

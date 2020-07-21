using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SabeTaoBem_MVC.Models.Users
{
    public class UserDetail
    {
        public int iduser { get; set; }
        [DisplayName("Primeiro Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string firstname { get; set; }
        [DisplayName("Apelido")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string lastname { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string email { get; set; }
        public Nullable<System.DateTime> registrationDate { get; set; }
        public byte userfunctionid { get; set; }
        public string userfunction { get; set; }
        public int loginid { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string username { get; set; }
        public byte StatusId { get; set; }
        public string Status { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string password { get; set; }

        public string UserRegErrorMessage { get; set; }
    }
}
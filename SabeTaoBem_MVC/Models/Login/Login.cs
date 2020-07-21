using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SabeTaoBem_MVC.Models.Login
{
    public class Login
    {
        public int IdLogin { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage="Este campo é obrigatório.")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}
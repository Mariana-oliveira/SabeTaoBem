using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using SabeTaoBem_MVC.Models.Users;

namespace SabeTaoBem_MVC.Controllers
{
    public class UserRegistrationController : Controller
    {
        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();
        // GET: UserRegistration
        public ActionResult RegisterUser()
        {
            return View();
        }

        public ActionResult RegisterForm(UserDetail newUser)
        {
            try
            {
                //Generic data for new user
                newUser.StatusId = 1;
                newUser.userfunctionid = 1;

                //IEnumerable<UserDetail> user = null;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.PostAsJsonAsync("api/users", newUser).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("SuccessUser", "Error");
                    }
                    else
                    {
                        newUser.UserRegErrorMessage = "Erro ao criar conta. Tente novamente.";
                        return View("Register User", newUser);
                    }

                }
            }
            catch
            {
                return RedirectToAction("Server", "Error");
            }


        }
    }
}
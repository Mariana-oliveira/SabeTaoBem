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
    public class UserController : Controller
    {

        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();
        // GET: User
        public ActionResult User(int userId)
        {
            try
            {
                IEnumerable<UserDetail> user = null;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("api/users?id=" + userId).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var readJob = response.Content.ReadAsAsync<IEnumerable<UserDetail>>();
                        readJob.Wait();
                        user = readJob.Result;
                    }
                    else
                    {
                        //Return the error 
                        user = Enumerable.Empty<UserDetail>();
                        ModelState.AddModelError(string.Empty, "Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.");
                    }

                    return View(user);
                }
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
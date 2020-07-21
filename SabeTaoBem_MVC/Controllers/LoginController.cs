using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using SabeTaoBem_MVC.Models.Login;

namespace SabeTaoBem_MVC.Controllers
{
    public class LoginController : Controller
    {
        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(Login login)
        {
            try
            {
                IEnumerable<Login> log = null;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.PostAsJsonAsync("api/login", login).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var readJob = response.Content.ReadAsAsync<IEnumerable<Login>>();
                        readJob.Wait();
                        log = readJob.Result;
                        if (log.Count() == 0)
                        {
                            login.LoginErrorMessage = "O username ou password estão errados.";
                            return View("Login", login);
                        }
                        else
                        {
                            Login user = log.ElementAt(0);
                            Session["UserID"] = user.IdLogin;
                            Session["Username"] = user.Username;
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    return View("Login", login);
                }
            }
            catch
            {
                return RedirectToAction("Server", "Error");
            }
            
        }


        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }


    }
    
}
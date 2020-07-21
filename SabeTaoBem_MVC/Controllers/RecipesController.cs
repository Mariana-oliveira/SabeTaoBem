using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SabeTaoBem_MVC.Models.Recipes;

namespace SabeTaoBem_MVC.Controllers
{
    public class RecipesController : Controller
    {
        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();
        // GET: Recipes
        public ActionResult Index()
        {
            try
            {
                IEnumerable<RecipeDetail> recipes = null;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("api/recipes").Result;
                    //response.Wait();

                    //var result = response.Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var readJob = response.Content.ReadAsAsync<IEnumerable<RecipeDetail>>();
                        readJob.Wait();
                        recipes = readJob.Result;
                    }
                    else
                    {
                        //Return the error 
                        recipes = Enumerable.Empty<RecipeDetail>();
                        ModelState.AddModelError(string.Empty, "Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.");
                    }

                    return View(recipes);
                }
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }

        }


        //[Route("Recipes/{name}")]
        public ActionResult RecipeByCategory(byte id)
        {
            IEnumerable<RecipeDetail> recipes = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("api/recipes/?recCategoryId=" + id).Result;
                    //response.Wait();

                    //var result = response.Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var readJob = response.Content.ReadAsAsync<IEnumerable<RecipeDetail>>();
                        readJob.Wait();
                        recipes = readJob.Result;
                    }
                    else
                    {
                        //Return the error 
                        recipes = Enumerable.Empty<RecipeDetail>();
                        ModelState.AddModelError(string.Empty, "Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.");
                    }

                    if(recipes.Count() == 0)
                    {
                        return RedirectToAction("NotFound", "Error");
                    }
                    else
                    {
                        return View(recipes);
                    }
                    
                }
            }
            catch
            {
                return RedirectToAction("Server", "Error");
            }
            
        }


        public ActionResult CreateRecipe()
        {
            return View();
        }
        public ActionResult CreateRecipeForm(RecipeDetail newRecipe)
        {
            try
            {
                //Generic data for new user
                newRecipe.idStatus = 1;
                newRecipe.userid = Convert.ToInt32(Session["UserID"]);


                //IEnumerable<UserDetail> user = null;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.PostAsJsonAsync("api/recipes", newRecipe).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("SuccessRecipe", "Error");
                    }
                    else
                    {
                        newRecipe.RecipeRegErrorMessage = "Erro ao criar conta. Tente novamente.";
                        return View("Register User", newRecipe);
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
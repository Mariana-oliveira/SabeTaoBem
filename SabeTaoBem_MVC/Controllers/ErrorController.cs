using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SabeTaoBem_MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult Server()
        {
            return View();
        }

        public ActionResult SuccessUser()
        {
            return View();
        }

        public ActionResult SuccessRecipe()
        {
            return View();
        }

    }
}

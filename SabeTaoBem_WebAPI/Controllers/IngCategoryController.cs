using SaoTaoBem_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SabeTaoBemLibrary.Models.Ingredients;

namespace SabeTaoBem_WebAPI.Controllers
{
    public class IngCategoryController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Get()
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<IngCategory> ingCatObj = entities.spSelIngredientCategory(null, null).Select(x => new IngCategory()
                {
                    Id = x.idIngCategory,
                    Category = x.Category,

                }).ToList();


                if (ingCatObj == null)
                {
                    return NotFound();
                }

                return Ok(ingCatObj);

            }
        }

    }
}

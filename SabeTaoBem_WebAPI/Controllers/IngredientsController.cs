using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SabeTaoBemLibrary.Models.Ingredients;
using SaoTaoBem_DataAccess;

namespace SabeTaoBem_WebAPI.Controllers
{
    public class IngredientsController : ApiController
    {
        //[HttpGet]
        //public IHttpActionResult Get()
        //{
        //    using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
        //    {
        //        IList<IngredientDetail> ingDetObj = entities.spSelIngredientDetail(null, null, null).Select(x => new IngredientDetail()
        //        {
        //            idIngredient = x.idIngredient,
        //            IngredientName = x.IngredientName,
        //            ingCategoryId = x.ingCategoryId,
        //            category = x.category

        //        }).ToList();


        //        if (ingDetObj == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(ingDetObj);

        //    }
        //}



        [HttpGet]
        public IHttpActionResult Get(Nullable<int> id=null, string ingName ="", Nullable<byte> ingCategory = null)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<IngredientDetail> ingDetObj = entities.spSelIngredientDetail(id, ingName, ingCategory).Select(x => new IngredientDetail()
                {
                    idIngredient = x.idIngredient,
                    IngredientName = x.IngredientName,
                    ingCategoryId = x.ingCategoryId,
                    category = x.category

                }).ToList();

                if (ingDetObj == null)
                {
                    return NotFound();
                }

                return Ok(ingDetObj);
            }
        }



        [HttpPost]
        public HttpResponseMessage Post([FromBody] Ingredient ingredient)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                entities.spInsIngredient(ingredient.IngredientName,ingredient.IngCategoryId);
                entities.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put([FromBody] Ingredient ingredient)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelIngredient(ingredient.IdIngredient, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Ingredient with ID = " + ingredient.IdIngredient.ToString() + "not found to update.");
                }
                else
                {
                    entities.spUpIngredient(ingredient.IdIngredient, ingredient.IngredientName, ingredient.IngCategoryId);

                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {

            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelIngredient(id, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Ingredient with ID = " + id.ToString() + "not found to delete.");
                }
                else
                {
                    entities.spDelIngredient(id);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }

    }
}

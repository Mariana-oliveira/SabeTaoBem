using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SabeTaoBemLibrary.Models.RecipeIngredients;
using SaoTaoBem_DataAccess;

namespace SabeTaoBem_WebAPI.Controllers
{
    public class RecipeIngredientController : ApiController
    {
        //[HttpGet]
        //public IHttpActionResult Get()
        //{
        //    using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
        //    {
        //        IList<RecipeIngredientDetail> recIngObj = entities.spSelRecipeIngredientDetails(null).Select(x => new RecipeIngredientDetail()
        //        {
        //            idrecipe = x.idrecipe,
        //            RecipeName = x.RecipeName,
        //            IdIngredient = x.IdIngredient,
        //            IngredientName = x.IngredientName,
        //            Quantity = x.Quantity,
        //            UnitId = x.UnitId,
        //            UnitName = x.UnitName
        //        }).ToList();

        //        return Ok(recIngObj);
        //    }
        //}


        [HttpGet]
        public IHttpActionResult Get(Nullable<int> idRecipe=null)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<RecipeIngredientDetail> recIngObj = entities.spSelRecipeIngredientDetails(idRecipe).Select(x => new RecipeIngredientDetail()
                {
                    idrecipe = x.idrecipe,
                    RecipeName = x.RecipeName,
                    IdIngredient = x.IdIngredient,
                    IngredientName = x.IngredientName,
                    Quantity = x.Quantity,
                    UnitId = x.UnitId,
                    UnitName = x.UnitName
                }).ToList();

                if (recIngObj == null)
                {
                    return NotFound();
                }

                return Ok(recIngObj);
            }
        }


        [HttpPost]
        public HttpResponseMessage Post([FromBody] List<RecipeIngredient> recIng)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                foreach(RecipeIngredient ing in recIng)
                {
                    entities.spInsRecipeIng(ing.IdRecipe, ing.IdIngredient, ing.UnitId, ing.Quantity);
                }
               
                entities.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }


        [HttpPut]
        public HttpResponseMessage Put([FromBody] RecipeIngredient recIng)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelRecipeIng(recIng.IdRecipe, recIng.IdIngredient).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "The ingredient with ID = " + recIng.IdIngredient.ToString() + 
                        " in the recipe = " + recIng.IdRecipe.ToString() +  " not found to update.");
                }
                else
                {
                    entities.spUpRecipeIng(recIng.IdRecipe, recIng.IdIngredient, recIng.UnitId, recIng.Quantity);
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }


        [HttpDelete]
        public HttpResponseMessage Delete(int idRec, int idIng)
        {

            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelRecipeIng(idRec, idIng).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "The ingredient with ID = " + idIng.ToString() +
                        " in the recipe = " + idRec.ToString() + " not found to update.");
                }
                else
                {
                    entities.spDelRecipeIng(idRec, idIng);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }


    }
}

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
    public class RecipeByIngredientController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(Nullable<int> idIngredient=null, string ingredientName="")
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<RecipeByIng> recIngObj = entities.spSelRecipeByIng(idIngredient, ingredientName).Select(x => new RecipeByIng()
                {
                    IdIngredient = x.IdIngredient,
                    IngredientName = x.IngredientName,
                    idRecipe = x.idRecipe,
                    RecipeName = x.RecipeName,
                    RecCategoryId = x.RecCategoryId,
                    Category = x.Category,
                    userid = x.userid,
                    Username = x.Username
                }).ToList();

                if (recIngObj == null)
                {
                    return NotFound();
                }

                return Ok(recIngObj);
            }
        }
    }
}

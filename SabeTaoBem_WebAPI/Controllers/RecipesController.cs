using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SabeTaoBemLibrary.Models.Recipes;
using SaoTaoBem_DataAccess;

namespace SabeTaoBem_WebAPI.Controllers
{
    public class RecipesController : ApiController
    {

        //[HttpGet]
        //public IHttpActionResult Get()
        //{
        //    using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
        //    {
        //        IList<RecipeDetail> recipeobj = entities.spSelRecipeDetails(null, null, null, null, null, null, null, null, null, null, null).Select(x => new RecipeDetail()
        //        {
        //            idrecipe = x.idrecipe,
        //            RecipeName = x.RecipeName,
        //            userid = x.userid,
        //            Username = x.Username,
        //            CreationDate = x.CreationDate,
        //            RecCategoryId = x.RecCategoryId,
        //            Category = x.Category,
        //            RecFoodStyleId = x.RecFoodStyleId,
        //            FoodStyle = x.FoodStyle,
        //            RecDifficultyLevelId = x.RecDifficultyLevelId,
        //            DifficultyLevel = x.DifficultyLevel,
        //            RecMealCostId = x.RecMealCostId,
        //            MealCost = x.MealCost,
        //            PreparationTime = x.PreparationTime,
        //            CookTime = x.CookTime,
        //            Doses = x.Doses,
        //            Evaluation = x.Evaluation,
        //            Description = x.Description,
        //            Picture = x.Picture,
        //            idStatus = x.idStatus,
        //            Status = x.Status


        //        }).ToList();

        //        return Ok(recipeobj);
        //    }
        //}


        [HttpGet]
        public IHttpActionResult Get(Nullable<int> idRecipe=null, string recipeName=null, Nullable<byte> recCategoryId=null, Nullable<byte> recFoodStyleId=null, 
            Nullable<byte> recDifficultyLevelId=null, Nullable<byte> recMealCostId =null, Nullable<int> preparationTime=null, Nullable<int> cookTime=null,
            Nullable<int> doses=null, Nullable<decimal> evaluation=null, Nullable<byte> statusId=null)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<RecipeDetail> recipeobj = entities.spSelRecipeDetails(idRecipe, recipeName, recCategoryId, recFoodStyleId, recDifficultyLevelId, recMealCostId,
                    preparationTime, cookTime, doses, evaluation, statusId).Select(x => new RecipeDetail()
                {
                    idrecipe = x.idrecipe,
                    RecipeName = x.RecipeName,
                    userid = x.userid,
                    Username = x.Username,
                    CreationDate = x.CreationDate,
                    RecCategoryId = x.RecCategoryId,
                    Category = x.Category,
                    RecFoodStyleId = x.RecFoodStyleId,
                    FoodStyle = x.FoodStyle,
                    RecDifficultyLevelId = x.RecDifficultyLevelId,
                    DifficultyLevel = x.DifficultyLevel,
                    RecMealCostId = x.RecMealCostId,
                    MealCost = x.MealCost,
                    PreparationTime = x.PreparationTime,
                    CookTime = x.CookTime,
                    Doses = x.Doses,
                    Evaluation = x.Evaluation,
                    Description = x.Description,
                    Picture = x.Picture,
                    idStatus = x.idStatus,
                    Status = x.Status


                }).ToList();

                if (recipeobj == null)
                {
                    return NotFound();
                }

                return Ok(recipeobj);
            }
        }


        [HttpPost]
        public HttpResponseMessage Post([FromBody] Recipes recipe)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                entities.spInsRecipes(recipe.RecipeName, recipe.UserId, recipe.RecCategoryId, recipe.RecFoodStyleId, recipe.RecDifficultyLevelId, recipe.RecMealCostId, recipe.PreparationTime,
                    recipe.CookTime, recipe.Doses, recipe.Description, recipe.idStatus, recipe.Evaluation, recipe.Picture);
                entities.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }


        [HttpPut]
        public HttpResponseMessage Put([FromBody] Recipes recipe)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelRecipes(recipe.IdRecipe, null, null, null, null, null, null, null, null, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Recipe with ID = " + recipe.IdRecipe.ToString() + "not found to update.");
                }
                else
                {
                    entities.spUpRecipes(recipe.IdRecipe, recipe.RecipeName, recipe.RecCategoryId, recipe.RecFoodStyleId, recipe.RecDifficultyLevelId, recipe.RecMealCostId, recipe.PreparationTime,
                    recipe.CookTime, recipe.Doses, recipe.Evaluation, recipe.Description, recipe.Picture, recipe.idStatus);
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
                var entity = entities.spSelRecipes(id, null, null, null, null, null, null, null, null, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Recipe with ID = " + id.ToString() + "not found to delete.");
                }
                else
                {
                    entities.spDelRecipe(id);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }


    }
}

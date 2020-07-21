using SabeTaoBemLibrary.Models.Units;
using SaoTaoBem_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SabeTaoBem_WebAPI.Controllers
{
    public class UnitCategoryController : ApiController
    {

        [HttpGet]
        public IHttpActionResult Get()
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<UnitCategory> unitCatObj = entities.spSelUnitCategory(null, null).Select(x => new UnitCategory()
                {
                    Id = x.IdUnitCategory,
                    Category = x.Category,

                }).ToList();


                if (unitCatObj == null)
                {
                    return NotFound();
                }

                return Ok(unitCatObj);

            }
        }

    }
}

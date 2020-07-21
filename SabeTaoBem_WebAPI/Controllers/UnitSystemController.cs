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
    public class UnitSystemController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<UnitSystem> sysCatObj = entities.spSelUnitSystem(null, null).Select(x => new UnitSystem()
                {
                    Id = x.IdUnitSystem,
                    System = x.System,

                }).ToList();


                if (sysCatObj == null)
                {
                    return NotFound();
                }

                return Ok(sysCatObj);

            }
        }
    }
}

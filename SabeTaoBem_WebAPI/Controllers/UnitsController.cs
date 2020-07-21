using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SaoTaoBem_DataAccess;
using SabeTaoBemLibrary.Models.Units;

namespace SabeTaoBem_WebAPI.Controllers
{
    public class UnitsController : ApiController
    {

        //[HttpGet]
        //public IHttpActionResult Get()
        //{
        //    using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
        //    {
        //        IList<UnitDetail> unitDetObj = entities.spSelUnitsDetails(null, null, null, null).Select(x => new UnitDetail()
        //        {
        //            IdUnit = x.IdUnit,
        //            UnitName = x.UnitName,
        //            UnitCategoryId = x.UnitCategoryId,
        //            Category = x.Category,
        //            UnitSystemId = x.UnitSystemId,
        //            System = x.System
        //         }).ToList();


        //        if (unitDetObj == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(unitDetObj);

        //    }
        //}


        [HttpGet]
        public IHttpActionResult Get(Nullable<byte> id=null, string unitName="", Nullable<byte> unitcategory=null, Nullable<byte> unitsystem=null)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<UnitDetail> unitDetObj = entities.spSelUnitsDetails(id, unitName, unitcategory, unitsystem).Select(x => new UnitDetail()
                {
                    IdUnit = x.IdUnit,
                    UnitName = x.UnitName,
                    UnitCategoryId = x.UnitCategoryId,
                    Category = x.Category,
                    UnitSystemId = x.UnitSystemId,
                    System = x.System
                }).ToList();

                if (unitDetObj == null)
                {
                    return NotFound();
                }

                return Ok(unitDetObj);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] UnitDetail unit)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                entities.spInsUnits(unit.UnitName, unit.UnitCategoryId, unit.UnitSystemId);
                entities.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }


        [HttpPut]
        public HttpResponseMessage Put([FromBody] Units unit)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelUnit(unit.IdUnit, null,null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Unit with ID = " + unit.IdUnit.ToString() + "not found to update.");
                }
                else
                {
                    entities.spUpUnits(unit.IdUnit, unit.UnitName, unit.UnitCategoryId, unit.UnitSystemId);
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }
        

        [HttpDelete]
        public HttpResponseMessage Delete(byte id)
        {

            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelUnit(id, null, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Unit with ID = " + id.ToString() + "not found to delete.");
                }
                else
                {
                    entities.spDelUnit(id);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }


    }
}

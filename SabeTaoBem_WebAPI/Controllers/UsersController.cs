using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SaoTaoBem_DataAccess;
using SabeTaoBemLibrary.Models.Users;
using Newtonsoft.Json.Linq;

namespace SabeTaoBem_WebAPI.Controllers
{

    public class UsersController : ApiController
    {
        //[HttpGet]
        //public IHttpActionResult Get()
        //{

        //    using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
        //    {
        //        IList<UsersDetail> userobj = entities.spSelUsersDetails(null, null, null).Select(x => new UsersDetail()
        //        {
        //            iduser = x.iduser,
        //            firstname = x.firstname,
        //            lastname = x.lastname,
        //            email = x.email,
        //            registrationDate = x.registrationDate,
        //            userfunctionid = x.userfunctionid,
        //            userfunction = x.userfunction,
        //            loginid = x.loginid,
        //            username = x.username,
        //            StatusId = x.StatusId,
        //            Status = x.Status

        //        }).ToList() ;

        //        return Ok(userobj);
        //    }
        //}

        [HttpGet]
        public IHttpActionResult Get(Nullable<int> id=null, Nullable<int> login=null, Nullable<byte> status=null)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<UsersDetail> userobj = entities.spSelUsersDetails(id, login, status).Select(x => new UsersDetail()
                {
                    iduser = x.iduser,
                    firstname = x.firstname,
                    lastname = x.lastname,
                    email = x.email,
                    registrationDate = x.registrationDate,
                    userfunctionid = x.userfunctionid,
                    userfunction = x.userfunction,
                    loginid = x.loginid,
                    username = x.username,
                    StatusId = x.StatusId,
                    Status = x.Status

                }).ToList();

                if(userobj ==null)
                {
                    return NotFound();
                }

                return Ok(userobj);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] UsersLogin user)
        {
            using(SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                entities.spInsUser(user.FirstName, user.LastName, user.Email, user.Username, user.Password, user.UserFunctionId, user.StatusId);
                entities.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put([FromBody] Users user)
        {
            using(SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelUsers(user.IdUser,null,null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User with ID = " + user.IdUser.ToString() + "not found to update.");
                }
                else
                {
                    entities.spUpUsers(user.IdUser, user.FirstName, user.LastName, user.Email, user.UserFunctionId, user.StatusId);
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
                var entity = entities.spSelUsers(id, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User with ID = " + id.ToString() + "not found to delete.");
                }
                else
                {
                    entities.spDelUser(id);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }


    }
}

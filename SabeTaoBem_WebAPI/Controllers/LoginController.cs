using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SaoTaoBem_DataAccess;
using SabeTaoBemLibrary.Models.Login;

namespace SabeTaoBem_WebAPI.Controllers
{
    public class LoginController : ApiController
    {

        [HttpPost]
        public IHttpActionResult Get([FromBody] Login login, Nullable<int> idlogin = null)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<Login> loginobj = entities.spSelLogin(idlogin, login.Username, login.Password).Select(x => new Login()
                {
                    IdLogin = x.IdLogin,
                    Username = x.Username

                }).ToList();

                if (loginobj == null)
                {
                    return NotFound();
                }

                return Ok(loginobj);
            }
        }


        [HttpPut]
        public HttpResponseMessage Put([FromBody] Login login)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelLogin(login.IdLogin, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Login with ID = " + login.IdLogin.ToString() + "not found to update.");
                }
                else
                {
                    entities.spUpLogin(login.IdLogin, login.Password);
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }

    }
}

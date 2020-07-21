using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SaoTaoBem_DataAccess;
using SabeTaoBemLibrary;
using Newtonsoft.Json.Linq;
using SabeTaoBemLibrary.Models.Comments;

namespace SabeTaoBem_WebAPI.Controllers
{
    public class CommentsController : ApiController
    {

        //[HttpGet]
        //public IHttpActionResult Get()
        //{
        //    using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
        //    {
        //        IList<CommentsDetail> commDetObj = entities.spSelCommentDetail(null, null, null, null).Select(x => new CommentsDetail()
        //        {
        //            idComment = x.idComment,
        //            Comment = x.Comment,
        //            RecipeId = x.RecipeId,
        //            RecipeName = x.RecipeName,
        //            Userid = x.Userid,
        //            FirstName = x.FirstName,
        //            LastName = x.LastName,
        //            Username = x.Username,
        //            commentdate = x.commentdate,
        //            statusid = x.statusid,
        //            status = x.status

        //        }).ToList();


        //        if (commDetObj == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(commDetObj);

        //    }
        //}


        [HttpGet]
        public IHttpActionResult Get(Nullable<int> id=null, Nullable<int> recid=null, Nullable<byte> userid=null, Nullable<byte> statusid=null)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                IList<CommentsDetail> commobj = entities.spSelCommentDetail(id, recid, userid,statusid).Select(x => new CommentsDetail()
                {
                    idComment = x.idComment,
                    Comment = x.Comment,
                    RecipeId = x.RecipeId,
                    RecipeName = x.RecipeName,
                    Userid = x.Userid,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Username = x.Username,
                    commentdate = x.commentdate,
                    statusid = x.statusid,
                    status = x.status

                }).ToList();

                if (commobj == null)
                {
                    return NotFound();
                }

                return Ok(commobj);
            }
        }


        [HttpPost]
        public HttpResponseMessage Post([FromBody] Comments comment)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                entities.spInsComment(comment.Comment, comment.RecipeId, comment.UserId, comment.StatusID);
                entities.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put([FromBody] Comments comment)
        {
            using (SabeTaoBemEntities entities = new SabeTaoBemEntities())
            {
                var entity = entities.spSelComment(comment.IdComment, null, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Comment with ID = " + comment.IdComment.ToString() + "not found to update.");
                }
                else
                {
                    entities.spUpComments(comment.IdComment, comment.Comment, comment.RecipeId, comment.UserId, comment.StatusID);
                   
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
                var entity = entities.spSelComment(id, null, null, null).ToList();

                if (entity == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Comment with ID = " + id.ToString() + "not found to delete.");
                }
                else
                {
                    entities.spDelComment(id);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }
        }



    }
}

namespace BlogSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Description;
    
    using Data.Repositories;
    using BlogSystem.Models;
    public class CommentsController : BaseController
    {
        private IRepository<Comment> repo;

        public CommentsController()
        {
            this.repo = this.Data.Comments;
        }

        // GET: api/Comments
        public IQueryable<Comment> GetComments()
        {
            return repo.All();
        }

        // GET: api/Comments/5
        [ResponseType(typeof(Comment))]
        public IHttpActionResult GetComment(int id)
        {
            Comment comment = repo.Find(c=>c.Id == id).FirstOrDefault();
            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment);
        }

        // PUT: api/Comments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComment(int id, Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comment.Id)
            {
                return BadRequest();
            }

            repo.Update(comment);
            repo.SaveChanges();

            return this.Ok(comment);
        }

        // POST: api/Comments
        [ResponseType(typeof(Comment))]
        public IHttpActionResult PostComment(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.Add(comment);
            repo.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = comment.Id }, comment);
        }

        // DELETE: api/Comments/5
        [ResponseType(typeof(Comment))]
        public IHttpActionResult DeleteComment(int id)
        {
            Comment comment = repo.Find(c=> c.Id == id).FirstOrDefault();
            if (comment == null)
            {
                return NotFound();
            }

            repo.Delete(comment);
            repo.SaveChanges();

            return Ok(comment);
        }
    }
}
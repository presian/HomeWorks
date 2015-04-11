namespace BlogSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Description;
    
    using Data.Repositories;
    using BlogSystem.Models;
    
    public class PostsController : BaseController
    {
        private IRepository<Post> repo;

        public PostsController() 
        {
            this.repo = this.Data.Posts;
        }

        // GET: api/Posts
        public IQueryable<Post> GetPosts()
        {
            return repo.All();
        }

        // GET: api/Posts/5
        [ResponseType(typeof(Post))]
        public IHttpActionResult GetPost(int id)
        {
            Post post = repo.Find(p=>p.Id == id).FirstOrDefault();
            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        // PUT: api/Posts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPost(int id, Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != post.Id)
            {
                return BadRequest();
            }

            repo.Update(post);
            repo.SaveChanges();

            return this.Ok(post);
        }

        // POST: api/Posts
        [ResponseType(typeof(Post))]
        public IHttpActionResult PostPost(Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.Add(post);
            repo.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = post.Id }, post);
        }

        // DELETE: api/Posts/5
        [ResponseType(typeof(Post))]
        public IHttpActionResult DeletePost(int id)
        {
            Post post = repo.Find(p=> p.Id == id).FirstOrDefault();
            if (post == null)
            {
                return NotFound();
            }

            repo.Delete(post);
            repo.SaveChanges();

            return Ok(post);
        }
    }
}
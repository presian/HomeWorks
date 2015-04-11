namespace BlogSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Description;
    
    using Data.Repositories;
    using BlogSystem.Models;
    public class TagsController : BaseController
    {
        private IRepository<Tag> repo;

        public TagsController()
        {
            this.repo = this.Data.Tags;
        }

        // GET: api/Tags
        public IQueryable<Tag> GetTags()
        {
            return repo.All();
        }

        // GET: api/Tags/5
        [ResponseType(typeof(Tag))]
        public IHttpActionResult GetTag(int id)
        {
            Tag tag = repo.Find(t=>t.Id == id).FirstOrDefault();
            if (tag == null)
            {
                return NotFound();
            }

            return Ok(tag);
        }

        // PUT: api/Tags/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTag(int id, Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tag.Id)
            {
                return BadRequest();
            }

            repo.Update(tag);
            repo.SaveChanges();

            return this.Ok(tag);
        }

        // POST: api/Tags
        [ResponseType(typeof(Tag))]
        public IHttpActionResult PostTag(Tag tag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.Add(tag);
            repo.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tag.Id }, tag);
        }

        // DELETE: api/Tags/5
        [ResponseType(typeof(Tag))]
        public IHttpActionResult DeleteTag(int id)
        {
            Tag tag = repo.Find(t=>t.Id == id).FirstOrDefault();
            if (tag == null)
            {
                return NotFound();
            }

            repo.Delete(tag);
            repo.SaveChanges();

            return Ok("Tag with id: " + id + " is deleted!");
        }
    }
}
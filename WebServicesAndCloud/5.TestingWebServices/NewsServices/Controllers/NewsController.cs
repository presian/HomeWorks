namespace NewsServices.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Web.Http;
    using System.Web.Http.Description;

    using News.Data.Repositories;
    using News.Models;
    
    public class NewsController : BaseController
    {
        private IRepository<NewsItem> repo;

        // GET: api/News
        public NewsController()
        {
            this.repo = this.Repository;
        }

        public NewsController(IRepository<NewsItem> newsRepository)
        {
            this.repo = newsRepository;
        }

        public IHttpActionResult GetNewsItems()
        {
            return this.Ok(repo.GetAll().AsQueryable());
        }

        // GET: api/News/5
        [ResponseType(typeof(NewsItem))]
        public IHttpActionResult GetNewsItem(int id)
        {
            NewsItem newsItem = repo.FindById(id);
            if (newsItem == null)
            {
                return NotFound();
            }

            return Ok(newsItem);
        }

        // PUT: api/News/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNewsItem(int id, NewsItem newsItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != newsItem.Id)
            {
                return BadRequest();
            }

            repo.Update(newsItem);
            repo.SaveChanges();
            return StatusCode(HttpStatusCode.OK);
        }

        // POST: api/News
        [ResponseType(typeof(NewsItem))]
        public IHttpActionResult PostNewsItem(NewsItem newsItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.Add(newsItem);
            repo.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = newsItem.Id }, newsItem);
        }

        // DELETE: api/News/5
        [ResponseType(typeof(NewsItem))]
        public IHttpActionResult DeleteNewsItem(int id)
        {
            NewsItem newsItem = repo.FindById(id);
            if (newsItem == null)
            {
                return NotFound();
            }

            repo.Delete(newsItem);
            repo.SaveChanges();

            return Ok(newsItem);
        }
    }
}
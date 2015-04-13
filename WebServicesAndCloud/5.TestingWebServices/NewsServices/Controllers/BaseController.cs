using News.Data.Repositories;

namespace NewsServices.Controllers
{
    using System.Web.Http;

    using News.Data;
    using News.Data.DataClasses;

    public abstract class BaseController : ApiController
    {
        private NewsRepository repository;

        protected BaseController()
        {
            this.repository = new NewsData(new ApplicationDbContext()).NewsRepository;
        }

        public NewsRepository Repository
        {
            get
            {
                return this.repository;
            }
        }
    }
}

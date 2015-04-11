namespace BlogSystem.Services.Controllers
{
    using System.Web.Http;
    
    using Data;

    public abstract class BaseController : ApiController
    {
        private IBlogSystemData data;

        protected BaseController()
        {
            this.data = new BlogSystemData(new BlogSystemDbContext());
        }

        public IBlogSystemData Data
        {
            get
            {
                return this.data;
            }
        }
    }
}

namespace Battleships.WebServices.Controllers
{
    using System.Web.Http;

    using Battleships.Data;

    public abstract class BaseApiController : ApiController
    {
        private IBattleshipsData data;
        
        protected BaseApiController()
        {
            this.data = new BattleshipsData(new ApplicationDbContext());
        }

        protected IBattleshipsData Data
        {
            get
            {
                return this.data;
            }
        }
    }
}
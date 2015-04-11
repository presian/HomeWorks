namespace CalcDistanceService.Controllers
{
    using System;
    using System.Web.Http;

    public class ValuesController : ApiController
    {
        [Route("dist")]
        public double ClalcDistance(int startPointX, int startPointY, int endPointX, int endPointY)
        {
            int deltaX = endPointX - startPointX;
            int deltaY = endPointY - startPointY;
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }
    }
}

﻿namespace Battleships.WebServices.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using Battleships.Data;

    public class UsersController : BaseApiController
    {
        public UsersController() 
        {
        }

        [HttpGet]
        public IHttpActionResult GetUsersCount()
        {
            var count = this.Data.Users.All().Count();
            return this.Ok(count);
        }
    }
}
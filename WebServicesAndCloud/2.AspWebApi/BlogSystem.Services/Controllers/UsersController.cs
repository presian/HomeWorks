using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BlogSystem.Data;
using BlogSystem.Data.Repositories;
using BlogSystem.Models;

namespace BlogSystem.Services.Controllers
{
    public class UsersController : BaseController
    {
        private IRepository<User> repo;

        public UsersController()
        {
            this.repo = this.Data.Users;
        }

        // GET: api/Users
        public IQueryable<User> GetUsers()
        {
            return repo.All();
        }

        // GET: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(int id)
        {
            User user = repo.Find(u=>u.Id == id).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int id, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }

            repo.Update(user);
            repo.SaveChanges();

            return this.Ok(user);
        }

        // POST: api/Users
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.Add(user);
            repo.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(int id)
        {
            User user = repo.Find(u=>u.Id == id).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            repo.Delete(user);
            repo.SaveChanges();

            return Ok(user);
        }
    }
}
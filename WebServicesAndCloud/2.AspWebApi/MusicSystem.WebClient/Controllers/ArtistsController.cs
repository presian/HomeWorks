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
using MusicSystem.Data;
using MusicSystem.Models;

namespace MusicSystem.WebClient.Controllers
{
    public class ArtistsController : ApiController
    {
        private MusicSystemEntities db = new MusicSystemEntities();

        [HttpGet]
        public IQueryable<Artist> AllArtists()
        {
            return db.Artists;
        }

        [HttpGet]
        public IHttpActionResult GetArtist(int id)
        {
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return NotFound();
            }

            return Ok(artist);
        }

        [HttpPut]
        public IHttpActionResult UpdateArtist(int id, Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != artist.Id)
            {
                return BadRequest();
            }

            db.Entry(artist).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);

            }

            return this.Ok(string.Format("Artist with Id({0}) is updated!", id));
        }

        [HttpPost]
        public IHttpActionResult AddArtist(Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Artists.Add(artist);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = artist.Id }, artist);
        }

        [HttpDelete]
        public IHttpActionResult DeleteArtist(int id)
        {
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return NotFound();
            }

            db.Artists.Remove(artist);
            db.SaveChanges();

            return this.Ok(string.Format("Artist with Id({0}) is removed from database!", id));
        }
    }
}
namespace MusicSystem.WebClient.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Models;

    public class AlbumsController : ApiController
    {
        private MusicSystemEntities db = new MusicSystemEntities();

        [HttpGet]
        public IQueryable<Album> ReturnAllAlbums()
        {
            return db.Albums;
        }

        [HttpGet]
        public IHttpActionResult ReturnAlbumById(int id)
        {
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return NotFound();
            }

            return Ok(album);
        }

        [HttpPut]
        public IHttpActionResult UpdateAlbum(int id, Album album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != album.Id)
            {
                return BadRequest();
            }

            db.Entry(album).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }

            return this.Ok(string.Format("Album with Id({0}) is updated!", id));
        }

        [HttpPost]
        public IHttpActionResult AddAlbum(Album album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                db.Albums.Add(album);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new { id = album.Id }, album);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteAlbum(int id)
        {
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return NotFound();
            }

            db.Albums.Remove(album);
            db.SaveChanges();

            return this.Ok(string.Format("Album with Id({0}) is removed from database!", id));
        }
    }
}
namespace MusicSystem.WebClient.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Http;

    using Data;
    using Models;

    public class SongsController : ApiController
    {
        private MusicSystemEntities db = new MusicSystemEntities();

        [HttpGet]
        public IHttpActionResult ReturnAllSongs()
        {
            var songs = db.Songs.ToList();
            return this.Ok(songs);
        }

        [HttpGet]
        public IHttpActionResult ReturnSongById(int id)
        {
            var song = db.Songs.Find(id);
            if (song != null)
            {
                return this.Ok(song);
            }

            return this.NotFound();
        }

        [HttpDelete]
        public IHttpActionResult DeleteSongById(int id)
        {
            var song = db.Songs.Find(id);
            if (song == null)
            {
                return this.NotFound();
            }

            db.Songs.Remove(song);
            db.SaveChanges();

            return this.Ok(string.Format("Song with Id({0}) is removed from database!", id));
        }

        [HttpPut]
        public IHttpActionResult UpdateSongById(int id, Song song)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (id != song.Id)
            {
                return this.BadRequest();
            }

            db.Entry(song).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
                catch (Exception ex)
                {
                    return this.BadRequest(ex.Message);
                }

                return this.Ok(string.Format("Song with Id({0}) is updated!", id));
        }

        [HttpPost]
        public IHttpActionResult AddSong(Song song)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            try
            {
                db.Songs.Add(song);
                db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = song.Id }, song);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
    }
}
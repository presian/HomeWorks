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
    public class ProducersController : ApiController
    {
        private MusicSystemEntities db = new MusicSystemEntities();

        [HttpGet]
        public IQueryable<Producer> ReturnAllProducers()
        {
            return db.Producers;
        }

        [HttpGet]
        public IHttpActionResult ReturnProducerById(int id)
        {
            Producer producer = db.Producers.Find(id);
            if (producer == null)
            {
                return NotFound();
            }

            return Ok(producer);
        }

        [HttpPut]
        public IHttpActionResult UpdateProducer(int id, Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producer.Id)
            {
                return BadRequest();
            }

            db.Entry(producer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }

            return this.Ok(string.Format("Producer with Id({0}) is updated!", id));
        }

        [HttpPost]
        public IHttpActionResult AddProducer(Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                db.Producers.Add(producer);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new { id = producer.Id }, producer);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteProducer(int id)
        {
            Producer producer = db.Producers.Find(id);
            if (producer == null)
            {
                return NotFound();
            }

            db.Producers.Remove(producer);
            db.SaveChanges();

            return this.Ok(string.Format("Producer with Id({0}) is removed from database!", id));
        }
    }
}
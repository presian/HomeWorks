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
    public class CountriesController : ApiController
    {
        private MusicSystemEntities db = new MusicSystemEntities();

        [HttpGet]
        public IQueryable<Country> ReturnAllCountries()
        {
            return db.Countries;
        }

        [HttpGet]
        public IHttpActionResult ReturnCountryById(int id)
        {
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        [HttpPut]
        public IHttpActionResult UpdateCountry(int id, Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != country.Id)
            {
                return BadRequest();
            }

            db.Entry(country).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }

            return this.Ok(string.Format("County with Id({0}) is updated!", id));
        }

        [HttpPost]
        public IHttpActionResult AddCountry(Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                db.Countries.Add(country);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new { id = country.Id }, country);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteCountryById(int id)
        {
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return NotFound();
            }

            db.Countries.Remove(country);
            db.SaveChanges();

            return this.Ok(string.Format("Country with Id({0}) is removed from database!", id));
        }
    }
}
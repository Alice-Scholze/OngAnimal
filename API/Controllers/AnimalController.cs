using ONG.Domain;
using ONG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AnimalController : ApiController
    {
        AnimalService animalService;
        AnimalController()
        {
            animalService = new AnimalService();
        }
        // GET: api/City
        public IHttpActionResult Get()
        {
            return Ok(animalService.GetAll());
        }

        // GET: api/City/5
        public IHttpActionResult Get(int id)
        {
            return Ok(animalService.GetById(id));
        }

        // POST: api/City
        public IHttpActionResult Post([FromBody]Animal animal)
        {
            animalService.Insert(animal);
            return Ok();
        }

        // PUT: api/City/5
        public IHttpActionResult Put(int id, [FromBody]Animal animal)
        {
            animalService.Update(animal);
            return Ok();
        }

        // DELETE: api/City/5
        public IHttpActionResult Delete(int id)
        {
            animalService.Delete(id);
            return Ok();
        }
    }
}

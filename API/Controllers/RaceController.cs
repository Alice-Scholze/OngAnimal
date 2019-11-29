using ONG.Domain;
using ONG.Services;
using System;
using System.Net;
using System.Web.Http;

namespace API.Controllers
{
    public class RaceController : ApiController
    {
        private RaceService raceService;

        public RaceController()
        {
            raceService = new RaceService();
        }

        // GET: api/Race
        public IHttpActionResult Get()
        {
            return Ok(raceService.GetAll());
        }

        // GET: api/Race/5
        public IHttpActionResult Get(int id)
        {
            return Ok(raceService.GetById(id));
        }

        // POST: api/Race
        public IHttpActionResult Post([FromBody]Race race)
        {
            try
            {
                raceService.Insert(race);
                return Ok();
            } catch(Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT: api/Race/5
        public IHttpActionResult Put(int id, [FromBody]Race race)
        {
            raceService.Update(race);
            return Ok();
        }

        // DELETE: api/Race/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                raceService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}

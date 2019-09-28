using ONG.Domain;
using ONG.Services;
using System.Net;
using System.Web.Http;

namespace API.Controllers
{
    public class CityController : ApiController
    {
        CityService cityService;
        CityController()
        {
            cityService = new CityService();
        }
        // GET: api/City
        public IHttpActionResult Get()
        {
            return Ok(cityService.GetAll());
        }

        // GET: api/City/5
        public IHttpActionResult Get(int id)
        {
            return Ok(cityService.GetById(id));
        }

        // POST: api/City
        public IHttpActionResult Post([FromBody]City city)
        {
            cityService.Insert(city);
            return Ok();
        }

        // PUT: api/City/5
        public IHttpActionResult Put(int id, [FromBody]City city)
        {
            //TO DO
            //cityService.Update(city);
            return Content(HttpStatusCode.NotImplemented, city);
        }

        // DELETE: api/City/5
        public IHttpActionResult Delete(int id)
        {
            cityService.Delete(id);
            return Ok();
        }
    }
}

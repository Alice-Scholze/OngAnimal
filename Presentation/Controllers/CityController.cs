using Presentation.ViewModel;
using System.Web.Mvc;
using Util.EndPoint;
using Util.WebApi;

namespace Presentation.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult List()
        {
            CityVM cityVM = WebApiClient.Build().Get<CityVM>(EndPoints.Cities, new CityVM());
            return View();
        }

        public ActionResult Create()
        {
            return View(new CityVM());
        }

        [HttpPost]
        public ActionResult Create(CityVM cityVM)
        {
            WebApiClient.Build().Post(EndPoints.Cities, new CityVM(), cityVM);
            return List();
        }
    }
}
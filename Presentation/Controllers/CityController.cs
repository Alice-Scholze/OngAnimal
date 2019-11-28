using Presentation.ViewModel;
using System.Collections.Generic;
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
            List<CityVM> cities = WebApiClient.Build().Get<List<CityVM>>(EndPoints.Cities, null);
            return View(cities);
        }

        public ActionResult Create(int? id)
        {
            CityVM city = new CityVM();

            if (id != null)
            {
                city = WebApiClient.Build().Get<CityVM>(EndPoints.Cities, id);
            }
                
            return View(city);
        }

        public ActionResult Delete(int id)
        {
            WebApiClient.Build().Delete<CityVM>(EndPoints.Cities, id);

            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Create(CityVM cityVM)
        {
            if (cityVM.Id > 0)
                WebApiClient.Build().Put(EndPoints.Cities, cityVM.Id, cityVM);
            else
                WebApiClient.Build().Post(EndPoints.Cities, cityVM);

            return RedirectToAction("List");
        }
    }
}
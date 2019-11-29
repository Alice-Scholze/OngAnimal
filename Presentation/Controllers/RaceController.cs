using Presentation.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;
using Util.EndPoint;
using Util.WebApi;

namespace Presentation.Controllers
{
    public class RaceController : Controller
    {
        // GET: Race
        public ActionResult List()
        {
            List<RaceVM> races = WebApiClient.Build().Get<List<RaceVM>>(EndPoints.Races, null);
            return View(races);
        }

        public ActionResult Create(int? id)
        {
            RaceVM race = new RaceVM();

            if (id != null)
            {
                race = WebApiClient.Build().Get<RaceVM>(EndPoints.Races, id);
            }

            return View(race);
        }

        public ActionResult Delete(int id)
        {
            WebApiClient.Build().Delete<RaceVM>(EndPoints.Races, id);

            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Create(RaceVM raceVM)
        {
            if (raceVM.Id > 0)
                WebApiClient.Build().Put(EndPoints.Races, raceVM.Id, raceVM);
            else
                WebApiClient.Build().Post(EndPoints.Races, raceVM);

            return RedirectToAction("List");
        }
    }
}
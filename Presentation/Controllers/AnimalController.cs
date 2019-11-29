using Presentation.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;
using Util.EndPoint;
using Util.WebApi;

namespace Presentation.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        public ActionResult List()
        {
            List<AnimalVM> animalVMs = WebApiClient.Build().Get<List<AnimalVM>>(EndPoints.Animals, null);
            return View(animalVMs);
        }

        public ActionResult Create(int? id)
        {
            AnimalVM animal = new AnimalVM();
            animal.Races = WebApiClient.Build().Get<List<RaceVM>>(EndPoints.Races, null);

            if (id != null)
            {
                animal = WebApiClient.Build().Get<AnimalVM>(EndPoints.Animals, id);
            }

            return View(animal);
        }

        public ActionResult Delete(int id)
        {
            WebApiClient.Build().Delete<AnimalVM>(EndPoints.Animals, id);

            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Create(AnimalVM animalVM)
        {
            if (animalVM.Id > 0)
                WebApiClient.Build().Put(EndPoints.Animals, animalVM.Id, animalVM);
            else
                WebApiClient.Build().Post(EndPoints.Animals, animalVM);

            return RedirectToAction("List");
        }
    }
}
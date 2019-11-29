using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class CityRepository : BaseRepository
    {
        public List<City> GetAll()
        {
            return db.Cities.ToList();
        }

        public City GetById(long id)
        {
            return db.Cities
                       .Where(city => city.Id == id)
                       .FirstOrDefault();
        }

        public void Insert(City city)
        {
            db.Cities.Add(city);
            Save();
        }

        public void Edit(City city)
        {
            City cityOld = GetById(city.Id);
            cityOld.Name = city.Name;
            cityOld.MunicipalCode = city.MunicipalCode;
            cityOld.UF = city.UF;
            cityOld.Country = city.Country;

            Save();
        }

        public void Delete(City city)
        {
            db.Cities.Remove(city);
            Save();
        }
    }
}

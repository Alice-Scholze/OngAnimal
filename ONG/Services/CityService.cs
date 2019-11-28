using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class CityService
    {
        private CityRepository cityRepository;

        public CityService()
        {
            cityRepository = new CityRepository();
        }

        public List<City> GetAll()
        {
            return cityRepository.GetAll();
        }

        public City GetById(long id)
        {
            return cityRepository.GetById(id);
        }

        public void Insert(City city)
        {
            if (city == null)
                throw new Exception("A cidade não pode ser nula");

            if (string.IsNullOrEmpty(city.Name))
                throw new Exception("A cidade precisa ter Name");

            if (string.IsNullOrEmpty(city.Country))
                throw new Exception("A cidade precisa ter País");

            cityRepository.Insert(city);
        }

        public void Update(City city)
        {
            cityRepository.Edit(city);
        }

        public void Delete(long id)
        {
            City city = cityRepository.GetById(id);
            if (city == null)
                throw new Exception("City não encontrada");

            cityRepository.Delete(city);
        }
    }
}

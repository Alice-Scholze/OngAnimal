using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class RaceService
    {
        private RaceRepository raceRepository;

        public RaceService()
        {
            raceRepository = new RaceRepository();
        }

        public List<Race> GetAll()
        {
            return raceRepository.GetAll();
        }

        public Race GetById(long id)
        {
            return raceRepository.GetById(id);
        }

        public void Insert(Race race)
        {
            if (race == null)
                throw new Exception("A raça não pode ser nula");

            if (string.IsNullOrEmpty(race.Name))
                throw new Exception("A raça precisa ter Name");

            if (string.IsNullOrEmpty(race.Specie))
                throw new Exception("A raça precisa ter Espécie");

            raceRepository.Insert(race);
        }

        public void Update(Race race)
        {
            raceRepository.Edit(race);
        }

        public void Delete(long id)
        {
            Race raca = raceRepository.GetById(id);

            if (raca == null)
                throw new Exception("Raça não encontrada");

            raceRepository.ApagarRaca(raca);
        }
    }
}

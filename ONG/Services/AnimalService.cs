using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class AnimalService
    {
        private AnimalRepository animalRepository;
        private RaceService raceService;

        public AnimalService()
        {
            animalRepository = new AnimalRepository();
            raceService = new RaceService();
        }

        public List<Animal> GetAll()
        {
            return animalRepository.GetAll();
        }

        public Animal GetById(long id)
        {
            Animal animal = animalRepository.GetById(id);
            animal.Race = raceService.GetById(animal.Race.Id);
            return animal;
        }

        public void Insert(Animal animal)
        {
            if (animal == null)
                throw new Exception("O animal não pode ser nulo");

            if (string.IsNullOrEmpty(animal.Name))
                throw new Exception("O animal precisa ter Name");

            animal.DateEntry = DateTime.Now;

            animalRepository.Insert(animal);
        }

        public void Update(Animal animal)
        {
            animalRepository.Edit(animal);
        }

        public void Delete(long id)
        {
            Animal animal = animalRepository.GetById(id);
            if (animal == null)
                throw new Exception("Animal não encontrado");

            animalRepository.Delete(animal);
        }
    }
}

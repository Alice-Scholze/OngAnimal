using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class AnimalService
    {
        private AnimalRepository animalRepository;

        public AnimalService()
        {
            animalRepository = new AnimalRepository();
        }

        public List<Animal> GetAll()
        {
            return animalRepository.GetAll();
        }

        public Animal BuscarAnimalPorCodigo(long id)
        {
            return animalRepository.GetById(id);
        }

        public void AdicionarAnimal(Animal animal)
        {
            if (animal == null)
                throw new Exception("O animal não pode ser nulo");

            if (string.IsNullOrEmpty(animal.Name))
                throw new Exception("O adotante precisa ter Name");

            if (animal.DateEntry == null || animal.DateEntry == DateTime.MinValue)
                throw new Exception("Informe a data de entrada do animal");

            animalRepository.Insert(animal);
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

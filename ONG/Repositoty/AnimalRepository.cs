using ONG.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class AnimalRepository : BaseRepository
    {
        public List<Animal> GetAll()
        {
            return db.Animals.ToList();
        }

        public Animal GetById(long codigo)
        {
            return db.Animals
                       .Where(animal => animal.Id == codigo)
                       .FirstOrDefault();
        }

        public void Insert(Animal animal)
        {
            db.Animals.Add(animal);
            Save();
        }

        public void Delete(Animal animal)
        {
            db.Animals.Remove(animal);
            Save();
        }
    }
}

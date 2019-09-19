using ONG.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class AnimalRepositorio : BaseRepositorio
    {
        public List<Animal> AnimaisCadastrados()
        {
            return db.Animais.ToList();
        }

        public Animal BuscarAnimalPorCodigo(long codigo)
        {
            return db.Animais
                       .Where(animal => animal.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarAnimal(Animal animal)
        {
            db.Animais.Add(animal);
            Salvar();
        }

        public void ApagarAnimal(Animal animal)
        {
            db.Animais.Remove(animal);
            Salvar();
        }
    }
}

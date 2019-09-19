using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class AnimalServico
    {
        private AnimalRepositorio animalRepositorio;

        public AnimalServico()
        {
            animalRepositorio = new AnimalRepositorio();
        }

        public List<Animal> AnimaisCadastrados()
        {
            return animalRepositorio.AnimaisCadastrados();
        }

        public Animal BuscarAnimalPorCodigo(long codigo)
        {
            return animalRepositorio.BuscarAnimalPorCodigo(codigo);
        }

        public void AdicionarAnimal(Animal animal)
        {
            if (animal == null)
                throw new Exception("O animal não pode ser nulo");

            if (string.IsNullOrEmpty(animal.Nome))
                throw new Exception("O adotante precisa ter Nome");

            if (animal.DataEntrada == null || animal.DataEntrada == DateTime.MinValue)
                throw new Exception("Informe a data de entrada do animal");

            animalRepositorio.AdicionarAnimal(animal);
        }

        public void ApagarAnimal(long id)
        {
            Animal animal = animalRepositorio.BuscarAnimalPorCodigo(id);
            if (animal == null)
                throw new Exception("Animal não encontrado");

            animalRepositorio.ApagarAnimal(animal);
        }
    }
}

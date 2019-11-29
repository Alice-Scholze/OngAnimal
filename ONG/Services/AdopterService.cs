using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class AdopterService
    {
        AdopterRepository adopterRepository;

        public AdopterService()
        {
            adopterRepository = new AdopterRepository();
        }

        public List<Adopter> GetAll()
        {
            return adopterRepository.GetAll();
        }

        public Adopter GetById(int id)
        {
            return adopterRepository.GetById(id);
        }

        public void Insert(Adopter adopter)
        {
            if (adopter == null)
                throw new Exception("O adotante não pode ser nulo");

            if (string.IsNullOrEmpty(adopter.CPF))
                throw new Exception("O adotante precisa ter CPF");

            if (string.IsNullOrEmpty(adopter.Name))
                throw new Exception("O adotante precisa ter Name");

            if (string.IsNullOrEmpty(adopter.Address))
                throw new Exception("O adotante precsa ter Endereço");

            if (string.IsNullOrEmpty(adopter.Email))
                throw new Exception("O andotante precisa ter Email");

            if (string.IsNullOrEmpty(adopter.Phone))
                throw new Exception("O adotante precisa ter Telefone");

            adopterRepository.Insert(adopter);
        }

        public void Update(Adopter adopter)
        {
            if (adopter == null)
                throw new Exception("O adotante não pode ser nulo");

            if (string.IsNullOrEmpty(adopter.CPF))
                throw new Exception("O adotante precisa ter CPF");

            if (string.IsNullOrEmpty(adopter.Name))
                throw new Exception("O adotante precisa ter Name");

            if (string.IsNullOrEmpty(adopter.Address))
                throw new Exception("O adotante precsa ter Endereço");

            if (string.IsNullOrEmpty(adopter.Email))
                throw new Exception("O andotante precisa ter Email");

            if (string.IsNullOrEmpty(adopter.Phone))
                throw new Exception("O adotante precisa ter Telefone");

            adopterRepository.Edit(adopter);
        }

        public void Delete(long id)
        {
            Adopter adopter = adopterRepository.GetById(id);
            if (adopter == null)
                throw new Exception("Adopter não encontrado");

            adopterRepository.Delete(adopter);
        }
    }
}

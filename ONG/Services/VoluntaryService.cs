using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class VoluntaryService
    {
        private VoluntaryRepository voluntaryRepository;

        public VoluntaryService()
        {
            voluntaryRepository = new VoluntaryRepository();
        }

        public List<Voluntary> GetAll()
        {
            return voluntaryRepository.GetAll();
        }

        public Voluntary GetById(long id)
        {
            return voluntaryRepository.GetById(id);
        }

        public void Insert(Voluntary volutary)
        {
            if (volutary == null)
                throw new Exception("O voluntario não pode ser nulo");

            if (string.IsNullOrEmpty(volutary.CPF))
                throw new Exception("O voluntario precisa ter CPF");

            if (string.IsNullOrEmpty(volutary.Name))
                throw new Exception("O voluntario precisa ter Name");

            if (volutary.Function.Procedure == "Sim")
            {
                if (string.IsNullOrEmpty(volutary.CRM))
                    throw new Exception("Função com procedimento médico, preencha o CRM");
            }

            if (string.IsNullOrEmpty(volutary.Address))
                throw new Exception("O voluntario precsa ter Endereço");

            if (string.IsNullOrEmpty(volutary.Email))
                throw new Exception("O voluntario precisa ter Email");

            if (string.IsNullOrEmpty(volutary.Phone))
                throw new Exception("O voluntario precisa ter Telefone");

            if (string.IsNullOrEmpty(volutary.Address))
                throw new Exception("O voluntario precsa ter Endereço");

            if (string.IsNullOrEmpty(volutary.Email))
                throw new Exception("O voluntario precisa ter Email");

            if (volutary.DateEntry == null || volutary.DateEntry == DateTime.MinValue)
                throw new Exception("Informe a data de entrada do voluntário");

            voluntaryRepository.Insert(volutary);
        }

        public void InsertDateDeparture(Voluntary voluntario, DateTime saida)
        {
            voluntario.DateDeparture = saida;

            voluntaryRepository.InsertDateDeparture(voluntario);
        }

        public void Delete(long id)
        {
            Voluntary voluntary = voluntaryRepository.GetById(id);

            if (voluntary == null)
                throw new Exception("Voluntary não encontrado");

            voluntaryRepository.Delete(voluntary);
        }
    }
}

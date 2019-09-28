using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class FunctionService
    {
        private FunctionRepository functionRepository;

        public FunctionService()
        {
            functionRepository = new FunctionRepository();
        }

        public List<Function> GetAll()
        {
            return functionRepository.GetAll();
        }

        public Function GetById(long id)
        {
            return functionRepository.GetById(id);
        }

        public void Insert(Function id)
        {
            if (id == null)
                throw new Exception("A função não pode ser nula");

            if (string.IsNullOrEmpty(id.Name))
                throw new Exception("A função precisa ter Name");

            if (string.IsNullOrEmpty(id.Area))
                throw new Exception("A função precisa ter área");

            functionRepository.Insert(id);
        }

        public void Delete(long id)
        {
            Function function = functionRepository.GetById(id);

            if (function == null)
                throw new Exception("Função não encontrado");

            functionRepository.Delete(function);
        }
    }
}

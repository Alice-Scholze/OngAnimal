using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class ServiceService
    {
        private ServiceRepository serviceRepository;

        public ServiceService()
        {
            serviceRepository = new ServiceRepository();
        }

        public List<Service> GetAll()
        {
            return serviceRepository.GetAll();
        }

        public Service GetById(long id)
        {
            return serviceRepository.GetById(id);
        }

        public void Insert(Service service)
        {
            if (service == null)
                throw new Exception("O serviço não pode ser nulo");

            if (string.IsNullOrEmpty(service.Description))
                throw new Exception("O serviço precisa ter Name");

            serviceRepository.Insert(service);
        }

        public void Update(Service service)
        {
            if (service == null)
                throw new Exception("O serviço não pode ser nulo");

            if (string.IsNullOrEmpty(service.Description))
                throw new Exception("O serviço precisa ter Name");

            serviceRepository.Edit(service);
        }

        public void Delete(long id)
        {
            Service service = serviceRepository.GetById(id);

            if (service == null)
                throw new Exception("Serviço não encontrado");

            serviceRepository.Delete(service);
        }
    }
}

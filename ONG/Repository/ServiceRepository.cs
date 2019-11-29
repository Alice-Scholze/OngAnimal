using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class ServiceRepository : BaseRepository
    {
        public List<Service> GetAll()
        {
            return db.Services.ToList();
        }

        public Service GetById(long id)
        {
            return db.Services
                       .Where(services => services.Id == id)
                       .FirstOrDefault();
        }

        public void Insert(Service service)
        {
            db.Services.Add(service);
            Save();
        }

        public void Edit(Service service)
        {
            Service serviceOld = GetById(service.Id);
            serviceOld = service;

            Save();
        }

        public void Delete(Service service)
        {
            db.Services.Remove(service);
            Save();
        }
    }
}

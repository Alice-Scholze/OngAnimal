using ONG.Domain;
using ONG.Repository;
using System.Collections.Generic;

namespace ONG.Services
{
    public class AdoptionService
    {
        private AdoptionRepository adoptionRepository;

        public AdoptionService()
        {
            adoptionRepository = new AdoptionRepository();
        }

        public List<Adoption> GetAll()
        {
            return adoptionRepository.GetAll();
        }
    }
}

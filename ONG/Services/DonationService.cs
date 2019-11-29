using ONG.Domain;
using ONG.Repository;
using System.Collections.Generic;

namespace ONG.Services
{
    public class DonationService
    {
        private DonationRepository donationRepository;

        public DonationService()
        {
            donationRepository = new DonationRepository();
        }

        public List<Donation> GetAll()
        {
            return donationRepository.GetAll();
        }
    }
}

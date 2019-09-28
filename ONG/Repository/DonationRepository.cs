using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class DonationRepository : BaseRepository
    {
        public List<Donation> GetAll()
        {
            return db.Donations.ToList();
        }
    }
}

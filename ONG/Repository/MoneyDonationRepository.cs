using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class MoneyDonationRepository : BaseRepository
    {
        public List<MoneyDonation> GetAll()
        {
            return db.MoneyDonations.ToList();
        }

        public void Insert(MoneyDonation donation)
        {
            db.MoneyDonations.Add(donation);
            Save();
        }
    }
}

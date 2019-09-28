using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class ProductDonationRepository : BaseRepository
    {
        public List<ProductDonation> GetAll()
        {
            return db.ProductDonations.ToList();
        }

        public void Insert(ProductDonation donation)
        {
            db.ProductDonations.Add(donation);
            Save();
        }
    }
}

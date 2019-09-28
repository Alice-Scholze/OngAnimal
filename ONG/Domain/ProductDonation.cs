using System.Collections.Generic;

namespace ONG.Domain
{
    public class ProductDonation : Donation
    {
        public List<Product> Products { get; set; }

        public List<Donation> Donations { get; set; }

        public ProductDonation()
        {
            Donations = new List<Donation>();
        }
        public override string Description()
        {
            return Id + " - " + Date + " - " + Donor + " - " + Type + " - " + Note + " - " + Products;
        }
    }
}

using System.Collections.Generic;

namespace ONG.Domain
{
    public class MoneyDonation : Donation
    {
        public decimal Value { get; set; }

        public List<Donation> Donations { get; set; }

        public MoneyDonation()
        {
            Donations = new List<Donation>();
        }
        public override string Description()
        {
            return Id + " - " + Date + " - " + Donor + " - " + Type + " - " + Note + " - " + Value;
        }
    }
}

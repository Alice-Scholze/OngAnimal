using System;

namespace ONG.Domain
{
    public class Donation
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public virtual Donor Donor { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }

        public virtual string Description()
        {
            return Id + " - " + Date + " - " + Donor + " - " + Type + " - " + Note;
        }

    }
}

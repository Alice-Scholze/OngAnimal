using System;

namespace ONG.Domain
{
    public class Adoption
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Adopter Adopter { get; set; }

    }
}

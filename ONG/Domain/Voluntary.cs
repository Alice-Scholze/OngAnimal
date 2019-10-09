using System;

namespace ONG.Domain
{
    public class Voluntary : Person
    {
        public virtual Function Function { get; set; }
        public string CRM { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime DateDeparture { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

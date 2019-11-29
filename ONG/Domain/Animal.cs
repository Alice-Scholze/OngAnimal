using System;

namespace ONG.Domain
{
    public class Animal
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual Race Race { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateDeparture { get; set; }
        public string Gender { get; set; }
        public string Note { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

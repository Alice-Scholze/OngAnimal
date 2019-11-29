using System;
using System.Collections.Generic;

namespace Presentation.ViewModel
{
    public class AnimalVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual RaceVM Race { get; set; }
        public List<RaceVM> Races { get; set; }
        public DateTime? DateEntry { get; set; }
        public DateTime? DateDeparture { get; set; }
        public string Gender { get; set; }
        public string Note { get; set; }

        public AnimalVM()
        {
            this.Races = new List<RaceVM>();
            this.Race = new RaceVM();
        }
    }
}
using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class RaceRepository : BaseRepository
    {
        public List<Race> GetAll()
        {
            return db.Races.ToList();
        }

        public Race GetById(long id)
        {
            return db.Races
                       .Where(races => races.Id == id)
                       .FirstOrDefault();
        }

        public void Insert(Race raca)
        {
            db.Races.Add(raca);
            Save();
        }

        public void Edit(Race race)
        {
            Race raceOld = GetById(race.Id);
            raceOld.Name = race.Name;
            raceOld.Size = race.Size;
            raceOld.Specie = race.Specie;
            raceOld.Note = race.Note;

            Save();
        }

        public void ApagarRaca(Race raca)
        {
            db.Races.Remove(raca);
            Save();
        }
    }
}

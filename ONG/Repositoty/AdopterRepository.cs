using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class AdopterRepository : BaseRepository
    {
        public List<Adopter> GetAll()
        {
            return db.Adopters.ToList();
        }

        public Adopter GetById(long id)
        {
            return db.Adopters
                       .Where(adopter => adopter.Id == id)
                       .FirstOrDefault();
        }

        public void Insert(Adopter adotante)
        {
            db.Adopters.Add(adotante);
            Save();
        }

        public void Delete(Adopter adopter)
        {
            db.Adopters.Remove(adopter);
            Save();
        }
    }
}

using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class AdoptionRepository : BaseRepository
    {
        public List<Adoption> GetAll()
        {
            return db.Adoptions.ToList();
        }

        public void Insert(Adoption adoption)
        {
            db.Adoptions.Add(adoption);
            Save();
        }
    }
}

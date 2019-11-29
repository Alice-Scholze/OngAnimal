using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class VoluntaryRepository : BaseRepository
    {
        public List<Voluntary> GetAll()
        {
            return db.Voluntaries.ToList();
        }

        public Voluntary GetById(long id)
        {
            return db.Voluntaries
                       .Where(volutary => volutary.Id == id)
                       .FirstOrDefault();
        }

        public void Insert(Voluntary volutary)
        {
            db.Voluntaries.Add(volutary);
            Save();
        }

        public void Edit(Voluntary volutary)
        {
            Voluntary voluntarioOld = GetById(volutary.Id);
            voluntarioOld = volutary;
            Save();
        }

        public void InsertDateDeparture(Voluntary voluntary)
        {
            Voluntary voluntarioOld = GetById(voluntary.Id);

            voluntarioOld.DateDeparture = voluntary.DateDeparture;

            Save();
        }

        public void Delete(Voluntary voluntario)
        {
            db.Voluntaries.Remove(voluntario);
            Save();
        }
    }
}

using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class ProcedureRepository : BaseRepository
    {
        public List<Procedure> GetAll()
        {
            return db.Procedures.ToList();
        }

        public void Insert(Procedure procedure)
        {
            db.Procedures.Add(procedure);
            Save();
        }
    }
}

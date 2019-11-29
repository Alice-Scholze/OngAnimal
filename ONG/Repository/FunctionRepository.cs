using ONG.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class FunctionRepository : BaseRepository
    {
        public List<Function> GetAll()
        {
            return db.Functions.ToList();
        }

        public Function GetById(long id)
        {
            return db.Functions
                       .Where(function => function.Id == id)
                       .FirstOrDefault();
        }

        public void Insert(Function function)
        {
            db.Functions.Add(function);
            Save();
        }

        public void Edit(Function function)
        {
            Function functionOld = GetById(function.Id);
            functionOld.Area = function.Area;
            functionOld.Name = function.Name;
            functionOld.Procedure = function.Procedure;

            Save();
        }
        public void Delete(Function function)
        {
            db.Functions.Remove(function);
            Save();
        }
    }
}

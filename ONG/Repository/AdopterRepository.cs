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

        public void Edit(Adopter adotante)
        {
            Adopter adopterOld = GetById(adotante.Id);
            adopterOld.Name = adotante.Name;
            adopterOld.Note = adotante.Note;
            adopterOld.Phone = adotante.Phone;
            adopterOld.Address = adotante.Address;
            adopterOld.City = adotante.City;
            adopterOld.CPF = adotante.CPF;
            adopterOld.Email = adotante.Email;

            Save();
        }

        public void Delete(Adopter adopter)
        {
            db.Adopters.Remove(adopter);
            Save();
        }
    }
}

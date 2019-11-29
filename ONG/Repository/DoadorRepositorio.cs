using ONG.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class DoadorRepositorio : BaseRepository
    {
        public List<Donor> GetAll()
        {
            return db.Donors.ToList();
        }

        public Donor GetById(long codigo)
        {
            return db.Donors
                       .Where(doador => doador.Id == codigo)
                       .FirstOrDefault();
        }

        public void Insert(Donor doador)
        {
            db.Donors.Add(doador);
            Save();
        }

        public void Edit(Donor doador)
        {
            Donor donorOld = GetById(doador.Id);
            donorOld.Name = doador.Name;
            donorOld.Note = doador.Note;
            donorOld.Pessoa = doador.Pessoa;
            donorOld.Phone = doador.Phone;
            donorOld.Address = doador.Address;
            donorOld.City = doador.City;
            donorOld.CPF = doador.Email;
            donorOld.Email = doador.Email;

            Save();
        }

        public void Delete(Donor doador)
        {
            db.Donors.Remove(doador);
            Save();
        }
    }
}

using ONG.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repository
{
    public class DoadorRepositorio : BaseRepository
    {
        public List<Donor> DoadoresCadastrados()
        {
            return db.Donors.ToList();
        }

        public Donor BuscarDoadorPorCodigo(long codigo)
        {
            return db.Donors
                       .Where(doador => doador.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarDoador(Donor doador)
        {
            db.Donors.Add(doador);
            Save();
        }

        public void ApagarDoador(Donor doador)
        {
            db.Donors.Remove(doador);
            Save();
        }
    }
}

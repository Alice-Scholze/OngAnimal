using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class RacaRepositorio : BaseRepositorio
    {
        public List<Raca> RacasCadastradas()
        {
            return db.Racas.ToList();
        }

        public Raca BuscarRacaPorCodigo(long codigo)
        {
            return db.Racas
                       .Where(racas => racas.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarRaca(Raca raca)
        {
            db.Racas.Add(raca);
            Salvar();
        }

        public void ApagarRaca(Raca raca)
        {
            db.Racas.Remove(raca);
            Salvar();
        }
    }
}

using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class AdotanteRepositorio : BaseRepositorio
    {
        public List<Adotante> AdotantesCadastrados()
        {
            return db.Adotantes.ToList();
        }

        public Adotante BuscarAdotatePorCodigo(long codigo)
        {
            return db.Adotantes
                       .Where(adotante => adotante.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarAdotante(Adotante adotante)
        {
            db.Adotantes.Add(adotante);
            Salvar();
        }

        public void ApagarAdotante(Adotante adotante)
        {
            db.Adotantes.Remove(adotante);
            Salvar();
        }
    }
}

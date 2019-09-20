using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class DoacaoRepositorio : BaseRepositorio
    {
        public List<Doacao> DoacoesCadastradas()
        {
            return db.Docaoes.ToList();
        }
    }
}

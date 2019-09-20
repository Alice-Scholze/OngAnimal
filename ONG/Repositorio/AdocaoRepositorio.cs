using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class AdocaoRepositorio : BaseRepositorio
    {
        public List<Adocao> AdocoesCadastradas()
        {
            return db.Adocoes.ToList();
        }
    }
}

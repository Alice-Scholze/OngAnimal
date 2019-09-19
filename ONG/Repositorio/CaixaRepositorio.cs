using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class CaixaRepositorio : BaseRepositorio
    {
        public List<Caixa> CaixaCadastrada()
        {
            return db.Caixa.ToList();
        }

        public void AdicionarCaixa(Caixa caixa)
        {
            db.Caixa.Add(caixa);
            Salvar();
        }

        public decimal BuscarTotalCaixa()
        {
            return db.Caixa.Select(c => c.Total).Sum();
        }
    }
}

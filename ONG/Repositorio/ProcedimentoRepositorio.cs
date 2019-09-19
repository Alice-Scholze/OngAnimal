using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class ProcedimentoRepositorio : BaseRepositorio
    {
        public List<Procedimento> ProcedimentosCadastrados()
        {
            return db.Procedimento.ToList();
        }

        public void AdicionarProcedimento(Procedimento Procedimento)
        {
            db.Procedimento.Add(Procedimento);
            Salvar();
        }
    }
}

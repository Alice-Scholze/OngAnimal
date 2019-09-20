using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class DoacaoDinheiroRepositorio : BaseRepositorio
    {
        public List<DoacaoDinheiro> DoacoesDinheiroCadastrados()
        {
            return db.DoacoesDinheiro.ToList();
        }

        public void AdicionarDoacaoDinheiro(DoacaoDinheiro doacao)
        {
            db.DoacoesDinheiro.Add(doacao);
            Salvar();
        }
    }
}

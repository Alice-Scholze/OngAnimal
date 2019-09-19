using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class DoacaoProdutoRepositorio : BaseRepositorio
    {
        public List<DoacaoProduto> DoacoesProdutoCadastrados()
        {
            return db.DoacoesProduto.ToList();
        }

        public void AdicionarDoacaoProduto(DoacaoProduto doacao)
        {
            db.DoacoesProduto.Add(doacao);
            Salvar();
        }
    }
}

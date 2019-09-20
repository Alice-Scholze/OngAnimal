using ONG.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio
    {
        public List<Produto> ProdutosCadastrados()
        {
            return db.Produtos.ToList();
        }

        public Produto BuscarProdutoPorCodigo(long codigo)
        {
            return db.Produtos
                       .Where(produto => produto.Id == codigo)
                       .FirstOrDefault();
        }

        public void AdicionarProduto(Produto produto)
        {
            db.Produtos.Add(produto);
            Salvar();
        }

        public void ApagarProduto(Produto produto)
        {
            db.Produtos.Remove(produto);
            Salvar();
        }

        public void AtualizarProduto(Produto produto)
        {
            Produto produtoOld = BuscarProdutoPorCodigo(produto.Id);
            produtoOld.Nome = produto.Nome;
            produtoOld.Observacao = produto.Observacao;
            produtoOld.Outro = produto.Outro;
            produtoOld.QuantCompra = produto.QuantCompra;
            produtoOld.Quantidade = produto.Quantidade;
            produtoOld.Tamanho = produto.Tamanho;
            produtoOld.Tipo = produto.Tipo;
            produtoOld.Total = produto.Total;
            produtoOld.ValorUnitario = produto.ValorUnitario;

            Salvar();
        }
    }
}

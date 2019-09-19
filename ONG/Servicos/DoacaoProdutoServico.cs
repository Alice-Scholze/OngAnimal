using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Servicos
{
    public class DoacaoProdutoServico
    {
        private DoacaoProdutoRepositorio doacaoProdutoRepositorio;

        public DoacaoProdutoServico()
        {
            doacaoProdutoRepositorio = new DoacaoProdutoRepositorio();
        }

        public List<DoacaoProduto> DoacoesProdutoCadastrados()
        {
            return doacaoProdutoRepositorio.DoacoesProdutoCadastrados();
        }

        public void AdicionarDoacaoProduto(DoacaoProduto doacao)
        {
            ProdutoServico produtoServico = new ProdutoServico();

            if (doacao == null)
                throw new Exception("A doação não pode ser nula");

            if (doacao.Produtos == null)
                throw new Exception("A doação precisa ter um produto");

            if (doacao.Data == null || doacao.Data == DateTime.MinValue)
                throw new Exception("Informe a data da doação");

            doacaoProdutoRepositorio.AdicionarDoacaoProduto(doacao);

            //atualiza o estoque
            foreach (Produto produtoDaDoacao in doacao.Produtos.ToList())
            {
                Produto produto = produtoServico.BuscarProdutoPorCodigo(produtoDaDoacao.Id);

                if (produto != null)
                {
                    produto.Quantidade = produtoDaDoacao.Quantidade + produtoDaDoacao.QuantCompra;
                    produto.Observacao = produto.Observacao + Environment.NewLine + " Quantidade atualizada para "
                    + produto.Quantidade + " atraves da doacao " + doacao.Id;

                    produtoServico.AtualizarProduto(produto);
                }
            }
        }
    }
}

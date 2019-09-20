using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class ProdutoServico
    {
        private ProdutoRepositorio produtoRepositorio;

        public ProdutoServico()
        {
            produtoRepositorio = new ProdutoRepositorio();
        }

        public List<Produto> ProdutosCadastrados()
        {
            return produtoRepositorio.ProdutosCadastrados();
        }

        public Produto BuscarProdutoPorCodigo(long codigo)
        {
            return produtoRepositorio.BuscarProdutoPorCodigo(codigo);
        }

        public void AdicionarProduto(Produto produto)
        {
            if (produto == null)
                throw new Exception("O produto não pode ser nulo");

            if (string.IsNullOrEmpty(produto.Nome))
                throw new Exception("O produto precisa ter Nome");

            if (produto.Tipo == "Outro")
            {
                if (string.IsNullOrEmpty(produto.Outro))
                    throw new Exception("Preencha o campo outro");
            }

            produtoRepositorio.AdicionarProduto(produto);
        }

        public void ApagarProduto(long id)
        {
            Produto produto = produtoRepositorio.BuscarProdutoPorCodigo(id);

            if (produto == null)
                throw new Exception("Produto não encontrado");

            produtoRepositorio.ApagarProduto(produto);
        }

        public void AtualizarProduto(Produto produto)
        {
            produtoRepositorio.AtualizarProduto(produto);
        }
    }
}

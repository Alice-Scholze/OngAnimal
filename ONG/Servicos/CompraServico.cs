using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Linq;

namespace ONG.Servicos
{
    public class CompraServico
    {
        private CompraRepositorio compraRepositorio;

        public CompraServico()
        {
            compraRepositorio = new CompraRepositorio();
        }

        public void AdicionarCompra(Compra compra)
        {
            CaixaServico caixaServico = new CaixaServico();
            ProdutoServico produtoServico = new ProdutoServico();

            if (compra == null)
                throw new Exception("A compra não pode ser nulo");

            if (compra.Produtos == null)
                throw new Exception("A compra precisa ter um produto");

            if (compra.Data == null || compra.Data == DateTime.MinValue)
                throw new Exception("Informe a data da compra");


            //verifica se há dinheiro em caixa suficiente
            decimal totalCaixa = caixaServico.BuscarTotalCaixa();

            if (compra.Total > totalCaixa)
                throw new Exception("Não há valor em caixa para realizar a compra. Valor disponível R$ " + totalCaixa);

            compraRepositorio.AdicionarCompra(compra);

            Caixa caixa = new Caixa();
            //atualiza o caixa
            caixa.Data = compra.Data;
            caixa.Descricao = "Caixa atualizado atravez da compra " + compra.Id;
            caixa.Valor = 0 - compra.Total;

            caixaServico.AdicionarCaixa(caixa);

            //atualiza o estoque
            foreach (Produto produtoDaCompra in compra.Produtos.ToList())
            {
                Produto produto = produtoServico.BuscarProdutoPorCodigo(produtoDaCompra.Id);

                if (produto != null)
                {
                    produto.Quantidade = produtoDaCompra.Quantidade + produtoDaCompra.QuantCompra;
                    produto.Observacao = produto.Observacao + Environment.NewLine + " Quantidade atualizada para "
                    + produto.Quantidade + " atraves da compra " + compra.Id;

                    produtoServico.AtualizarProduto(produto);
                }
            }
        }
    }
}

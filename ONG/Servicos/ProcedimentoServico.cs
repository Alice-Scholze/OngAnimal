using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ONG.Servicos
{
    public class ProcedimentoServico
    {
        private ProcedimentoRepositorio procedimentoRepositorio;
        public ProcedimentoServico()
        {
            procedimentoRepositorio = new ProcedimentoRepositorio();
        }

        public List<Procedimento> ProcedimentosCadastrados()
        {
            return procedimentoRepositorio.ProcedimentosCadastrados();
        }

        public void AdicionarProcedimento(Procedimento procedimento)
        {
            ProdutoServico produtoServico = new ProdutoServico();

            if (procedimento == null)
                throw new Exception("O procedimento não pode ser nulo");

            if (procedimento.Data == null || procedimento.Data == DateTime.MinValue)
                throw new Exception("Informe a data do procedimento");
            if (procedimento.Animal == null)
                throw new Exception("Selecione um animal");

            if (procedimento.Servico.Veterinario != "Não")
            {
                if (string.IsNullOrEmpty(procedimento.Voluntario.CRM) || procedimento.Voluntario.Funcao.Procedimento == "Não")
                {
                    throw new Exception("Este serviço só deve ser realizado por um profissional. Necessário CRM e marcação na função.");

                }
            }

            if (procedimento.Produtos == null || procedimento.Servico == null)
            {
                throw new Exception("Selecione um produto ou um serviço ao procedimento");
            }

            procedimentoRepositorio.AdicionarProcedimento(procedimento);

            //atualiza o estoque
            foreach (Produto produtoDoProcedimento in procedimento.Produtos.ToList())
            {
                Produto produto = produtoServico.BuscarProdutoPorCodigo(produtoDoProcedimento.Id);

                if (produto != null)
                {
                    produto.Quantidade = produtoDoProcedimento.Quantidade + produtoDoProcedimento.QuantCompra;
                    produto.Observacao = produto.Observacao + Environment.NewLine + " Quantidade atualizada para "
                    + produto.Quantidade + " atraves do procedimento " + procedimento.Id;

                    produtoServico.AtualizarProduto(produto);
                }
            }
        }
    }
}

using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class CaixaServico
    {
        private CaixaRepositorio caixaRepositorio;

        public CaixaServico()
        {
            caixaRepositorio = new CaixaRepositorio();
        }

        public List<Caixa> CaixaCadastrada()
        {
            return caixaRepositorio.CaixaCadastrada();
        }

        public void AdicionarCaixa(Caixa caixa)
        {
            if (caixa == null)
                throw new Exception("O caixa não pode ser nulo");

            if (string.IsNullOrEmpty(caixa.Descricao))
                throw new Exception("É necessário adicionar uma descrição para entrada de dinheiro no caixa");

            caixa.Total = caixaRepositorio.BuscarTotalCaixa() + caixa.Valor;

            caixaRepositorio.AdicionarCaixa(caixa);
        }

        public decimal BuscarTotalCaixa()
        {
            return caixaRepositorio.BuscarTotalCaixa();
        }
    }
}

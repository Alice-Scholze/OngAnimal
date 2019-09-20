using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class CidadeServico
    {
        private CidadeRepositorio cidadeRepositorio;

        public CidadeServico()
        {
            cidadeRepositorio = new CidadeRepositorio();
        }

        public List<Cidade> CidadesCadastradas()
        {
            return cidadeRepositorio.CidadesCadastradas();
        }

        public Cidade BuscarCidadePorCodigo(long codigo)
        {
            return cidadeRepositorio.BuscarCidadePorCodigo(codigo);
        }

        public void AdicionarCidade(Cidade cidade)
        {
            if (cidade == null)
                throw new Exception("A cidade não pode ser nula");

            if (string.IsNullOrEmpty(cidade.nome))
                throw new Exception("A cidade precisa ter Nome");

            if (string.IsNullOrEmpty(cidade.Pais))
                throw new Exception("A cidade precisa ter País");

            cidadeRepositorio.AdicionarCidade(cidade);
        }

        public void ApagarCidade(long id)
        {
            Cidade cidade = cidadeRepositorio.BuscarCidadePorCodigo(id);
            if (cidade == null)
                throw new Exception("Cidade não encontrada");

            cidadeRepositorio.ApagarCidade(cidade);
        }
    }
}

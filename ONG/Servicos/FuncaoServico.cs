using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class FuncaoServico
    {
        private FuncaoRepositorio funcaoRepositorio;

        public FuncaoServico()
        {
            funcaoRepositorio = new FuncaoRepositorio();
        }

        public List<Funcao> FuncoesCadastradas()
        {
            return funcaoRepositorio.FuncoesCadastradas();
        }

        public Funcao BuscarFuncaoPorCodigo(long codigo)
        {
            return funcaoRepositorio.BuscarFuncaoPorCodigo(codigo);
        }

        public void AdicionarFuncao(Funcao funcao)
        {
            if (funcao == null)
                throw new Exception("A função não pode ser nula");

            if (string.IsNullOrEmpty(funcao.Nome))
                throw new Exception("A função precisa ter Nome");

            if (string.IsNullOrEmpty(funcao.Area))
                throw new Exception("A função precisa ter área");

            funcaoRepositorio.AdicionarFuncao(funcao);
        }

        public void ApagarFuncao(long id)
        {
            Funcao funcao = funcaoRepositorio.BuscarFuncaoPorCodigo(id);

            if (funcao == null)
                throw new Exception("Função não encontrado");

            funcaoRepositorio.ApagarFuncao(funcao);
        }
    }
}

using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class DoadorServico
    {
        private DoadorRepositorio doadorRepositorio;

        public DoadorServico()
        {
            doadorRepositorio = new DoadorRepositorio();
        }

        public List<Doador> DoadoresCadastrados()
        {
            return doadorRepositorio.DoadoresCadastrados();
        }

        public Doador BuscarDoadorPorCodigo(long codigo)
        {
            return doadorRepositorio.BuscarDoadorPorCodigo(codigo);
        }

        public void AdicionarDoador(Doador doador)
        {
            if (doador == null)
                throw new Exception("O doador não pode ser nulo");

            if (string.IsNullOrEmpty(doador.CPF))
                throw new Exception("O adotante precisa ter CPF");

            if (string.IsNullOrEmpty(doador.Nome))
                throw new Exception("O adotante precisa ter Nome");

            if (string.IsNullOrEmpty(doador.Endereco))
                throw new Exception("O adotante precsa ter Endereço");

            if (string.IsNullOrEmpty(doador.Email))
                throw new Exception("O andotante precisa ter Email");

            if (string.IsNullOrEmpty(doador.Telefone))
                throw new Exception("O adotante precisa ter Telefone");

            doadorRepositorio.AdicionarDoador(doador);
        }

        public void ApagarDoador(long id)
        {
            Doador doador = doadorRepositorio.BuscarDoadorPorCodigo(id);

            if (doador == null)
                throw new Exception("Doador não encontrado");

            doadorRepositorio.ApagarDoador(doador);
        }
    }
}

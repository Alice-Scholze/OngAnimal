using ONG.Domain;
using ONG.Repository;
using System;
using System.Collections.Generic;

namespace ONG.Services
{
    public class DoadorServico
    {
        private DoadorRepositorio doadorRepositorio;

        public DoadorServico()
        {
            doadorRepositorio = new DoadorRepositorio();
        }

        public List<Donor> DoadoresCadastrados()
        {
            return doadorRepositorio.DoadoresCadastrados();
        }

        public Donor BuscarDoadorPorCodigo(long codigo)
        {
            return doadorRepositorio.BuscarDoadorPorCodigo(codigo);
        }

        public void AdicionarDoador(Donor doador)
        {
            if (doador == null)
                throw new Exception("O doador não pode ser nulo");

            if (string.IsNullOrEmpty(doador.CPF))
                throw new Exception("O adotante precisa ter CPF");

            if (string.IsNullOrEmpty(doador.Name))
                throw new Exception("O adotante precisa ter Name");

            if (string.IsNullOrEmpty(doador.Address))
                throw new Exception("O adotante precsa ter Endereço");

            if (string.IsNullOrEmpty(doador.Email))
                throw new Exception("O andotante precisa ter Email");

            if (string.IsNullOrEmpty(doador.Phone))
                throw new Exception("O adotante precisa ter Telefone");

            doadorRepositorio.AdicionarDoador(doador);
        }

        public void ApagarDoador(long id)
        {
            Donor doador = doadorRepositorio.BuscarDoadorPorCodigo(id);

            if (doador == null)
                throw new Exception("Donor não encontrado");

            doadorRepositorio.ApagarDoador(doador);
        }
    }
}

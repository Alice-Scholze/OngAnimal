using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class AdotanteServico
    {
        AdotanteRepositorio adotanteRepositorio;

        public AdotanteServico()
        {
            adotanteRepositorio = new AdotanteRepositorio();
        }

        public List<Adotante> AdotantesCadastrados()
        {
            return adotanteRepositorio.AdotantesCadastrados();
        }

        public void AdicionarAdotante(Adotante adotante)
        {
            if (adotante == null)
                throw new Exception("O adotante não pode ser nulo");

            if (string.IsNullOrEmpty(adotante.CPF))
                throw new Exception("O adotante precisa ter CPF");

            if (string.IsNullOrEmpty(adotante.Nome))
                throw new Exception("O adotante precisa ter Nome");

            if (string.IsNullOrEmpty(adotante.Endereco))
                throw new Exception("O adotante precsa ter Endereço");

            if (string.IsNullOrEmpty(adotante.Email))
                throw new Exception("O andotante precisa ter Email");

            if (string.IsNullOrEmpty(adotante.Telefone))
                throw new Exception("O adotante precisa ter Telefone");

            adotanteRepositorio.AdicionarAdotante(adotante);
        }

        public void ApagarAdotante(long id)
        {
            Adotante adotante = adotanteRepositorio.BuscarAdotatePorCodigo(id);
            if (adotante == null)
                throw new Exception("Adotante não encontrado");

            adotanteRepositorio.ApagarAdotante(adotante);
        }
    }
}

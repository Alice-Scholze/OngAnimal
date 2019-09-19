using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class RacaServico
    {
        private RacaRepositorio racaRepositorio;

        public RacaServico()
        {
            racaRepositorio = new RacaRepositorio();
        }

        public List<Raca> RacasCadastradas()
        {
            return racaRepositorio.RacasCadastradas();
        }

        public Raca BuscarRacaPorCodigo(long codigo)
        {
            return racaRepositorio.BuscarRacaPorCodigo(codigo);
        }

        public void AdicionarRaca(Raca raca)
        {
            if (raca == null)
                throw new Exception("A raça não pode ser nula");

            if (string.IsNullOrEmpty(raca.Nome))
                throw new Exception("A raça precisa ter Nome");

            if (string.IsNullOrEmpty(raca.Especie))
                throw new Exception("A raça precisa ter Espécie");

            racaRepositorio.AdicionarRaca(raca);
        }

        public void ApagarRaca(long id)
        {
            Raca raca = racaRepositorio.BuscarRacaPorCodigo(id);

            if (raca == null)
                throw new Exception("Raça não encontrada");

            racaRepositorio.ApagarRaca(raca);
        }
    }
}

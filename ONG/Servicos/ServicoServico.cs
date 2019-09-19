using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class ServicoServico
    {
        private ServicoRepositorio servicoRepositorio;

        public ServicoServico()
        {
            servicoRepositorio = new ServicoRepositorio();
        }

        public List<Servico> ServicosCadastrados()
        {
            return servicoRepositorio.ServicosCadastrados();
        }

        public Servico BuscarServicoPorCodigo(long codigo)
        {
            return servicoRepositorio.BuscarServicoPorCodigo(codigo);
        }

        public void AdicionarServico(Servico servico)
        {
            if (servico == null)
                throw new Exception("O serviço não pode ser nulo");

            if (string.IsNullOrEmpty(servico.Descricao))
                throw new Exception("O serviço precisa ter Nome");

            servicoRepositorio.AdicionarServico(servico);
        }

        public void ApagarServico(long id)
        {
            Servico servico = servicoRepositorio.BuscarServicoPorCodigo(id);

            if (servico == null)
                throw new Exception("Serviço não encontrado");

            servicoRepositorio.ApagarServico(servico);
        }
    }
}

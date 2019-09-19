using ONG.Dominio;
using ONG.Repositorio;
using System;
using System.Collections.Generic;

namespace ONG.Servicos
{
    public class VoluntarioServico
    {
        private VoluntarioRepositorio voluntarioRepositorio;

        public VoluntarioServico()
        {
            voluntarioRepositorio = new VoluntarioRepositorio();
        }

        public List<Voluntario> VoluntariosCadastrados()
        {
            return voluntarioRepositorio.VoluntariosCadastrados();
        }

        public Voluntario BuscarVoluntarioPorCodigo(long codigo)
        {
            return voluntarioRepositorio.BuscarVoluntarioPorCodigo(codigo);
        }

        public void AdicionarVoluntario(Voluntario voluntario)
        {
            if (voluntario == null)
                throw new Exception("O voluntario não pode ser nulo");

            if (string.IsNullOrEmpty(voluntario.CPF))
                throw new Exception("O voluntario precisa ter CPF");

            if (string.IsNullOrEmpty(voluntario.Nome))
                throw new Exception("O voluntario precisa ter Nome");

            if (voluntario.Funcao.Procedimento == "Sim")
            {
                if (string.IsNullOrEmpty(voluntario.CRM))
                    throw new Exception("Função com procedimento médico, preencha o CRM");
            }

            if (string.IsNullOrEmpty(voluntario.Endereco))
                throw new Exception("O voluntario precsa ter Endereço");

            if (string.IsNullOrEmpty(voluntario.Email))
                throw new Exception("O voluntario precisa ter Email");

            if (string.IsNullOrEmpty(voluntario.Telefone))
                throw new Exception("O voluntario precisa ter Telefone");

            if (string.IsNullOrEmpty(voluntario.Endereco))
                throw new Exception("O voluntario precsa ter Endereço");

            if (string.IsNullOrEmpty(voluntario.Email))
                throw new Exception("O voluntario precisa ter Email");

            if (voluntario.DataEntrada == null || voluntario.DataEntrada == DateTime.MinValue)
                throw new Exception("Informe a data de entrada do voluntário");

            voluntarioRepositorio.AdicionarVoluntario(voluntario);
        }

        public void AdicionarSaidaVoluntario(Voluntario voluntario, DateTime saida)
        {
            voluntario.DataSaida = saida;

            voluntarioRepositorio.AdicionarSaidaVoluntario(voluntario);
        }

        public void ApagarVoluntario(long id)
        {
            Voluntario voluntario = voluntarioRepositorio.BuscarVoluntarioPorCodigo(id);

            if (voluntario == null)
                throw new Exception("Voluntario não encontrado");

            voluntarioRepositorio.ApagarVoluntario(voluntario);
        }
    }
}

using ONG.Dominio;
using ONG.Repositorio;
using System;

namespace ONG.Servicos
{
    public class DoacaoDinheiroServico
    {
        private DoacaoDinheiroRepositorio doacaoDinheiroRepositorio;

        public DoacaoDinheiroServico()
        {
            doacaoDinheiroRepositorio = new DoacaoDinheiroRepositorio();
        }

        public void AdicionarDoacaoDinheiro(DoacaoDinheiro doacao)
        {
            CaixaRepositorio caixaRepositorio = new CaixaRepositorio();

            if (doacao == null)
                throw new Exception("A doação não pode ser nulo");

            if (doacao.Valor <= 0)
                throw new Exception("A doação deve ser maior que 0");

            if (string.IsNullOrEmpty(doacao.Doador.Nome))
                throw new Exception("O doador precisa ter Nome");

            if (doacao.Data == null || doacao.Data == DateTime.MinValue)
                throw new Exception("Informe a data da doação");

            doacaoDinheiroRepositorio.AdicionarDoacaoDinheiro(doacao);

            Caixa caixa = new Caixa();
            caixa.Data = doacao.Data;
            caixa.Descricao = "Caixa atualizado atraves da doação " + doacao.Id;
            caixa.Valor = doacao.Valor;

            caixaRepositorio.AdicionarCaixa(caixa);
        }
    }
}

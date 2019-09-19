using System.Collections.Generic;

namespace ONG.Dominio
{
    public class DoacaoDinheiro : Doacao
    {
        public decimal Valor { get; set; }

        public List<Doacao> Doacoes { get; set; }

        public DoacaoDinheiro()
        {
            Doacoes = new List<Doacao>();
        }
        public override string Descricao()
        {
            return Id + " - " + Data + " - " + Doador + " - " + Tipo + " - " + Observacao + " - " + Valor;
        }
    }
}

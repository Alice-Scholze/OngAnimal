using System.Collections.Generic;

namespace ONG.Dominio
{
    public class DoacaoProduto : Doacao
    {
        public List<Produto> Produtos { get; set; }

        public List<Doacao> Doacoes { get; set; }

        public DoacaoProduto()
        {
            Doacoes = new List<Doacao>();
        }
        public override string Descricao()
        {
            return Id + " - " + Data + " - " + Doador + " - " + Tipo + " - " + Observacao + " - " + Produtos;
        }
    }
}

using System;

namespace ONG.Dominio
{
    public class Doacao
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public virtual Doador Doador { get; set; }
        public string Tipo { get; set; }
        public string Observacao { get; set; }

        public virtual string Descricao()
        {
            return Id + " - " + Data + " - " + Doador + " - " + Tipo + " - " + Observacao;
        }

    }
}

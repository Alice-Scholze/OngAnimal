using System;

namespace ONG.Dominio
{
    public class Animal
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public virtual Raca Raca { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string Sexo { get; set; }
        public string Observacao { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}

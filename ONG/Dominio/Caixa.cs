using System;

namespace ONG.Dominio
{
    public class Caixa
    {
        public long Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        public string Descricao { get; set; }

    }
}

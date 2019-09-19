using System;
using System.Collections.Generic;

namespace ONG.Dominio
{
    public class Compra
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public virtual List<Produto> Produtos { get; set; }
        public decimal Total { get; set; }

    }
}

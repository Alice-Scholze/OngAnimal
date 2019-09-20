using System;
using System.Collections.Generic;

namespace ONG.Dominio
{
    public class Procedimento
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Voluntario Voluntario { get; set; }
        public virtual List<Produto> Produtos { get; set; }
        public virtual Servico Servico { get; set; }
    }
}

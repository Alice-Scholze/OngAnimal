using System;

namespace ONG.Dominio
{
    public class Adocao
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Adotante Adotante { get; set; }

    }
}

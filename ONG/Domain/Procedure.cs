using System;
using System.Collections.Generic;

namespace ONG.Domain
{
    public class Procedure
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Voluntary Voluntary { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual Service Services { get; set; }
    }
}

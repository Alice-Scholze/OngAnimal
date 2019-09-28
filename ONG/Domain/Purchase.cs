using System;
using System.Collections.Generic;

namespace ONG.Domain
{
    public class Purchase
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Product> Products { get; set; }
        public decimal Total { get; set; }

    }
}

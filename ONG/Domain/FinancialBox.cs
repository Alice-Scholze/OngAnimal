using System;

namespace ONG.Domain
{
    public class FinancialBox
    {
        public long Id { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string Description { get; set; }

    }
}

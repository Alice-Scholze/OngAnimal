namespace ONG.Domain
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Other { get; set; }
        public decimal Quantity { get; set; }
        public string Note { get; set; }


        //propriedades abaixo são pra Alice ver que gambiarra vai ter que fazer na compra de produto
        public decimal QuantBuy { get; set; }
        public decimal UnitaryValue { get; set; }
        public decimal Total { get; set; }

    }
}

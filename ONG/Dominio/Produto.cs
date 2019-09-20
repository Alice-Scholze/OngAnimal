namespace ONG.Dominio
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public string Tipo { get; set; }
        public string Outro { get; set; }
        public decimal Quantidade { get; set; }
        public string Observacao { get; set; }


        //propriedades abaixo são pra Alice ver que gambiarra vai ter que fazer na compra de produto
        public decimal QuantCompra { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Total { get; set; }

    }
}

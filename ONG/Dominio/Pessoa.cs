namespace ONG.Dominio
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public virtual Cidade Cidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }

        public virtual string Descricao()
        {
            return Id + " - " + CPF + " - " + Nome + " - " + Endereco + " - " + Cidade + " - " + Email + " - " + Telefone + " - " + Observacao;
        }
    }
}

namespace ONG.Dominio
{

    public class Cidade
    {
        public long Id { get; set; }
        public string nome { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public long CodigoFiscal { get; set; }

        public override string ToString()
        {
            return nome;
        }
    }
}

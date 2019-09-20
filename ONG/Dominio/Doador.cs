namespace ONG.Dominio
{
    public class Doador : Pessoa
    {
        public string Pessoa { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}

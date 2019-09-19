namespace ONG.Dominio
{
    public class Funcao
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
        public string Procedimento { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}

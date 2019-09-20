namespace ONG.Dominio
{
    public class Servico
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Veterinario { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}

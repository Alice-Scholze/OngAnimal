namespace ONG.Dominio
{
    public class Raca
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Porte { get; set; }
        public string Classe { get; set; }
        public string Observacao { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}

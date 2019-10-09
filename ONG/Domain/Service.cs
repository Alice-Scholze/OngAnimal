namespace ONG.Domain
{
    public class Service
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Vet { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}

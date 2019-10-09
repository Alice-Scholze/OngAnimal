namespace ONG.Domain
{
    public class City
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UF { get; set; }
        public string Country { get; set; }
        public long MunicipalCode { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

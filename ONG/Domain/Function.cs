namespace ONG.Domain
{
    public class Function
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Procedure { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

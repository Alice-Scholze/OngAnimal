namespace ONG.Domain
{
    public class Donor : Person
    {
        public string Pessoa { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

namespace ONG.Domain
{
    public class Person
    {
        public long Id { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual City City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }

        public virtual string Descricao()
        {
            return Id + " - " + CPF + " - " + Name + " - " + Address + " - " + City + " - " + Email + " - " + Phone + " - " + Note;
        }
    }
}

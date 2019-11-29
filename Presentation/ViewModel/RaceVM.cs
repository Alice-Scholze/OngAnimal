namespace Presentation.ViewModel
{
    public class RaceVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Specie { get; set; }
        public string Size { get; set; }
        public string Class { get; set; }
        public string Note { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
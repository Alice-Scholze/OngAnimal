using ONG.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ONG.Repository.EFConfiguration
{
    public class OngContext : DbContext
    {
        public OngContext() : base("OngContext") { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Adopter> Adopters { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Voluntary> Voluntaries { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<MoneyDonation> MoneyDonations { get; set; }
        public DbSet<ProductDonation> ProductDonations { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<FinancialBox> FinancialBox { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

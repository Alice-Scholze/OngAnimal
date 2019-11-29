namespace ONG.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CPF = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Note = c.String(),
                        Pessoa = c.String(),
                        CRM = c.String(),
                        DateEntry = c.DateTime(),
                        DateDeparture = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        City_Id = c.Long(),
                        Function_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.City_Id)
                .ForeignKey("dbo.Function", t => t.Function_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Function_Id);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        UF = c.String(),
                        Country = c.String(),
                        MunicipalCode = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Adoption",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Adopter_Id = c.Long(),
                        Animal_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Adopter_Id)
                .ForeignKey("dbo.Animal", t => t.Animal_Id)
                .Index(t => t.Adopter_Id)
                .Index(t => t.Animal_Id);
            
            CreateTable(
                "dbo.Animal",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        DateEntry = c.DateTime(nullable: false),
                        DateDeparture = c.DateTime(nullable: false),
                        Gender = c.String(),
                        Note = c.String(),
                        Race_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Race", t => t.Race_Id)
                .Index(t => t.Race_Id);
            
            CreateTable(
                "dbo.Race",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Specie = c.String(),
                        Size = c.String(),
                        Class = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Donation",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Type = c.String(),
                        Note = c.String(),
                        Value = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Donor_Id = c.Long(),
                        MoneyDonation_Id = c.Long(),
                        ProductDonation_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Donor_Id)
                .ForeignKey("dbo.Donation", t => t.MoneyDonation_Id)
                .ForeignKey("dbo.Donation", t => t.ProductDonation_Id)
                .Index(t => t.Donor_Id)
                .Index(t => t.MoneyDonation_Id)
                .Index(t => t.ProductDonation_Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.String(),
                        Type = c.String(),
                        Other = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Note = c.String(),
                        QuantBuy = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitaryValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductDonation_Id = c.Long(),
                        Procedure_Id = c.Long(),
                        Purchase_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donation", t => t.ProductDonation_Id)
                .ForeignKey("dbo.Procedure", t => t.Procedure_Id)
                .ForeignKey("dbo.Purchase", t => t.Purchase_Id)
                .Index(t => t.ProductDonation_Id)
                .Index(t => t.Procedure_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.FinancialBox",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Function",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Area = c.String(),
                        Procedure = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Procedure",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Animal_Id = c.Long(),
                        Services_Id = c.Long(),
                        Voluntary_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animal", t => t.Animal_Id)
                .ForeignKey("dbo.Service", t => t.Services_Id)
                .ForeignKey("dbo.Person", t => t.Voluntary_Id)
                .Index(t => t.Animal_Id)
                .Index(t => t.Services_Id)
                .Index(t => t.Voluntary_Id);
            
            CreateTable(
                "dbo.Service",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        Type = c.String(),
                        Vet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchase",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Purchase_Id", "dbo.Purchase");
            DropForeignKey("dbo.Procedure", "Voluntary_Id", "dbo.Person");
            DropForeignKey("dbo.Procedure", "Services_Id", "dbo.Service");
            DropForeignKey("dbo.Product", "Procedure_Id", "dbo.Procedure");
            DropForeignKey("dbo.Procedure", "Animal_Id", "dbo.Animal");
            DropForeignKey("dbo.Person", "Function_Id", "dbo.Function");
            DropForeignKey("dbo.Person", "City_Id", "dbo.City");
            DropForeignKey("dbo.Product", "ProductDonation_Id", "dbo.Donation");
            DropForeignKey("dbo.Donation", "ProductDonation_Id", "dbo.Donation");
            DropForeignKey("dbo.Donation", "MoneyDonation_Id", "dbo.Donation");
            DropForeignKey("dbo.Donation", "Donor_Id", "dbo.Person");
            DropForeignKey("dbo.Adoption", "Animal_Id", "dbo.Animal");
            DropForeignKey("dbo.Animal", "Race_Id", "dbo.Race");
            DropForeignKey("dbo.Adoption", "Adopter_Id", "dbo.Person");
            DropIndex("dbo.Procedure", new[] { "Voluntary_Id" });
            DropIndex("dbo.Procedure", new[] { "Services_Id" });
            DropIndex("dbo.Procedure", new[] { "Animal_Id" });
            DropIndex("dbo.Product", new[] { "Purchase_Id" });
            DropIndex("dbo.Product", new[] { "Procedure_Id" });
            DropIndex("dbo.Product", new[] { "ProductDonation_Id" });
            DropIndex("dbo.Donation", new[] { "ProductDonation_Id" });
            DropIndex("dbo.Donation", new[] { "MoneyDonation_Id" });
            DropIndex("dbo.Donation", new[] { "Donor_Id" });
            DropIndex("dbo.Animal", new[] { "Race_Id" });
            DropIndex("dbo.Adoption", new[] { "Animal_Id" });
            DropIndex("dbo.Adoption", new[] { "Adopter_Id" });
            DropIndex("dbo.Person", new[] { "Function_Id" });
            DropIndex("dbo.Person", new[] { "City_Id" });
            DropTable("dbo.Purchase");
            DropTable("dbo.Service");
            DropTable("dbo.Procedure");
            DropTable("dbo.Function");
            DropTable("dbo.FinancialBox");
            DropTable("dbo.Product");
            DropTable("dbo.Donation");
            DropTable("dbo.Race");
            DropTable("dbo.Animal");
            DropTable("dbo.Adoption");
            DropTable("dbo.City");
            DropTable("dbo.Person");
        }
    }
}

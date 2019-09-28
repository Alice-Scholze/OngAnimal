namespace ONG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
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
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .ForeignKey("dbo.Functions", t => t.Function_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Function_Id);
            
            CreateTable(
                "dbo.Cities",
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
                "dbo.Adoptions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Adopter_Id = c.Long(),
                        Animal_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Adopter_Id)
                .ForeignKey("dbo.Animals", t => t.Animal_Id)
                .Index(t => t.Adopter_Id)
                .Index(t => t.Animal_Id);
            
            CreateTable(
                "dbo.Animals",
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
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .Index(t => t.Race_Id);
            
            CreateTable(
                "dbo.Races",
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
                "dbo.Donations",
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
                .ForeignKey("dbo.People", t => t.Donor_Id)
                .ForeignKey("dbo.Donations", t => t.MoneyDonation_Id)
                .ForeignKey("dbo.Donations", t => t.ProductDonation_Id)
                .Index(t => t.Donor_Id)
                .Index(t => t.MoneyDonation_Id)
                .Index(t => t.ProductDonation_Id);
            
            CreateTable(
                "dbo.Products",
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
                .ForeignKey("dbo.Donations", t => t.ProductDonation_Id)
                .ForeignKey("dbo.Procedures", t => t.Procedure_Id)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id)
                .Index(t => t.ProductDonation_Id)
                .Index(t => t.Procedure_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.FinancialBoxes",
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
                "dbo.Functions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Area = c.String(),
                        Procedure = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Procedures",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Animal_Id = c.Long(),
                        Services_Id = c.Long(),
                        Voluntary_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animals", t => t.Animal_Id)
                .ForeignKey("dbo.Services", t => t.Services_Id)
                .ForeignKey("dbo.People", t => t.Voluntary_Id)
                .Index(t => t.Animal_Id)
                .Index(t => t.Services_Id)
                .Index(t => t.Voluntary_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        Type = c.String(),
                        Vet = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchases",
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
            DropForeignKey("dbo.Products", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.Procedures", "Voluntary_Id", "dbo.People");
            DropForeignKey("dbo.Procedures", "Services_Id", "dbo.Services");
            DropForeignKey("dbo.Products", "Procedure_Id", "dbo.Procedures");
            DropForeignKey("dbo.Procedures", "Animal_Id", "dbo.Animals");
            DropForeignKey("dbo.People", "Function_Id", "dbo.Functions");
            DropForeignKey("dbo.People", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Products", "ProductDonation_Id", "dbo.Donations");
            DropForeignKey("dbo.Donations", "ProductDonation_Id", "dbo.Donations");
            DropForeignKey("dbo.Donations", "MoneyDonation_Id", "dbo.Donations");
            DropForeignKey("dbo.Donations", "Donor_Id", "dbo.People");
            DropForeignKey("dbo.Adoptions", "Animal_Id", "dbo.Animals");
            DropForeignKey("dbo.Animals", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Adoptions", "Adopter_Id", "dbo.People");
            DropIndex("dbo.Procedures", new[] { "Voluntary_Id" });
            DropIndex("dbo.Procedures", new[] { "Services_Id" });
            DropIndex("dbo.Procedures", new[] { "Animal_Id" });
            DropIndex("dbo.Products", new[] { "Purchase_Id" });
            DropIndex("dbo.Products", new[] { "Procedure_Id" });
            DropIndex("dbo.Products", new[] { "ProductDonation_Id" });
            DropIndex("dbo.Donations", new[] { "ProductDonation_Id" });
            DropIndex("dbo.Donations", new[] { "MoneyDonation_Id" });
            DropIndex("dbo.Donations", new[] { "Donor_Id" });
            DropIndex("dbo.Animals", new[] { "Race_Id" });
            DropIndex("dbo.Adoptions", new[] { "Animal_Id" });
            DropIndex("dbo.Adoptions", new[] { "Adopter_Id" });
            DropIndex("dbo.People", new[] { "Function_Id" });
            DropIndex("dbo.People", new[] { "City_Id" });
            DropTable("dbo.Purchases");
            DropTable("dbo.Services");
            DropTable("dbo.Procedures");
            DropTable("dbo.Functions");
            DropTable("dbo.FinancialBoxes");
            DropTable("dbo.Products");
            DropTable("dbo.Donations");
            DropTable("dbo.Races");
            DropTable("dbo.Animals");
            DropTable("dbo.Adoptions");
            DropTable("dbo.Cities");
            DropTable("dbo.People");
        }
    }
}

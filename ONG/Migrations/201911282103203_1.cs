namespace ONG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animal", "DateDeparture", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animal", "DateDeparture", c => c.DateTime(nullable: false));
        }
    }
}

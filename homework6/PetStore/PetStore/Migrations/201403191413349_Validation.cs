namespace PetStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "DateReceived", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pets", "DateReceieved");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "DateReceieved", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pets", "DateReceived");
        }
    }
}

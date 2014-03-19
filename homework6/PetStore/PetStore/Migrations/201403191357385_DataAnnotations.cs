namespace PetStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pets", "Animal", c => c.String(nullable: false));
            AlterColumn("dbo.Pets", "ShortDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Pets", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "Description", c => c.String());
            AlterColumn("dbo.Pets", "ShortDescription", c => c.String());
            AlterColumn("dbo.Pets", "Animal", c => c.String());
        }
    }
}

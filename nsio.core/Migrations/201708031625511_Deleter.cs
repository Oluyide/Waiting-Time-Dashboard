namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deleter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Permissions", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Permissions", "IsActive");
        }
    }
}

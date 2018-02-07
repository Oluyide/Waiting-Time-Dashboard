namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleIsactive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "IsActive", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "IsActive");
        }
    }
}

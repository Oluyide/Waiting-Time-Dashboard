namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Isactive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClusterProcessReports", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClusterProcessReports", "IsActive");
        }
    }
}

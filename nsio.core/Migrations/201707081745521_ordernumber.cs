namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ordernumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClusterProcessReportFieldTypes", "OrderNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClusterProcessReportFieldTypes", "OrderNumber");
        }
    }
}

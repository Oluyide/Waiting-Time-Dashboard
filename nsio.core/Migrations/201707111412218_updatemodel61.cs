namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodel61 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ClusterProcessReports", "Fieldlabel");
            DropColumn("dbo.ClusterProcessReports", "displayString");
            DropColumn("dbo.ClusterProcessReports", "dataType");
            DropColumn("dbo.ClusterProcessReports", "OrderNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClusterProcessReports", "OrderNumber", c => c.Int(nullable: false));
            AddColumn("dbo.ClusterProcessReports", "dataType", c => c.String());
            AddColumn("dbo.ClusterProcessReports", "displayString", c => c.String());
            AddColumn("dbo.ClusterProcessReports", "Fieldlabel", c => c.String());
        }
    }
}

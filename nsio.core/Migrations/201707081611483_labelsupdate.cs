namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class labelsupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClusterProcessReportFieldTypes", "dataType", c => c.String());
            AddColumn("dbo.ClusterProcessReportFieldTypes", "Datadate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClusterProcessReportFieldTypes", "Datadate");
            DropColumn("dbo.ClusterProcessReportFieldTypes", "dataType");
        }
    }
}

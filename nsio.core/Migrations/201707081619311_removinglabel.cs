namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removinglabel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ClusterProcessReportFieldTypes", "Datadate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClusterProcessReportFieldTypes", "Datadate", c => c.DateTime(nullable: false));
        }
    }
}

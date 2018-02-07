namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClusterProcessReportEntries", "ClusterProcessReportInstance_Id", "dbo.ClusterProcessReportInstances");
            DropIndex("dbo.ClusterProcessReportEntries", new[] { "ClusterProcessReportInstance_Id" });
            DropColumn("dbo.ClusterProcessReportEntries", "ClusterProcessReportInstance_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClusterProcessReportEntries", "ClusterProcessReportInstance_Id", c => c.Int());
            CreateIndex("dbo.ClusterProcessReportEntries", "ClusterProcessReportInstance_Id");
            AddForeignKey("dbo.ClusterProcessReportEntries", "ClusterProcessReportInstance_Id", "dbo.ClusterProcessReportInstances", "Id");
        }
    }
}

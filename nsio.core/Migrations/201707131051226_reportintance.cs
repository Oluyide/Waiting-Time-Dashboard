namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reportintance : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClusterProcessReportInstances", "ClusterProcessReportTypeId", "dbo.ClusterProcessReportTypes");
            DropIndex("dbo.ClusterProcessReportInstances", new[] { "ClusterProcessReportTypeId" });
            DropTable("dbo.ClusterProcessReportInstances");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ClusterProcessReportInstances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClusterProcessReportTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ClusterProcessReportInstances", "ClusterProcessReportTypeId");
            AddForeignKey("dbo.ClusterProcessReportInstances", "ClusterProcessReportTypeId", "dbo.ClusterProcessReportTypes", "Id", cascadeDelete: true);
        }
    }
}

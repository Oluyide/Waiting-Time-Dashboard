namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClusterProcessReportTypeProjectClusters", "ClusterProcessReportType_Id", "dbo.ClusterProcessReportTypes");
            DropForeignKey("dbo.ClusterProcessReportTypeProjectClusters", "ProjectCluster_Id", "dbo.ProjectClusters");
            DropIndex("dbo.ClusterProcessReportTypeProjectClusters", new[] { "ClusterProcessReportType_Id" });
            DropIndex("dbo.ClusterProcessReportTypeProjectClusters", new[] { "ProjectCluster_Id" });
            CreateTable(
                "dbo.ClusterProcessReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fieldlabel = c.String(),
                        displayString = c.String(),
                        dataType = c.String(),
                        OrderNumber = c.Int(nullable: false),
                        ClusterProcessReportType_Id = c.Int(),
                        ClusterReportFieldCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClusterProcessReportTypes", t => t.ClusterProcessReportType_Id)
                .ForeignKey("dbo.ClusterReportFieldCategories", t => t.ClusterReportFieldCategory_Id)
                .Index(t => t.ClusterProcessReportType_Id)
                .Index(t => t.ClusterReportFieldCategory_Id);
            
            CreateTable(
                "dbo.ProjectClusterTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ProjectClusters", "ProjectClusterType_Id", c => c.Int());
            AddColumn("dbo.ClusterProcessReportTypes", "ProjectClusters_Id", c => c.Int());
            AddColumn("dbo.ClusterProcessReportEntries", "ClusterProcessReport_Id", c => c.Int());
            CreateIndex("dbo.ProjectClusters", "ProjectClusterType_Id");
            CreateIndex("dbo.ClusterProcessReportTypes", "ProjectClusters_Id");
            CreateIndex("dbo.ClusterProcessReportEntries", "ClusterProcessReport_Id");
            AddForeignKey("dbo.ClusterProcessReportEntries", "ClusterProcessReport_Id", "dbo.ClusterProcessReports", "Id");
            AddForeignKey("dbo.ClusterProcessReportTypes", "ProjectClusters_Id", "dbo.ProjectClusters", "Id");
            AddForeignKey("dbo.ProjectClusters", "ProjectClusterType_Id", "dbo.ProjectClusterTypes", "Id");
            DropTable("dbo.ClusterProcessReportTypeProjectClusters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ClusterProcessReportTypeProjectClusters",
                c => new
                    {
                        ClusterProcessReportType_Id = c.Int(nullable: false),
                        ProjectCluster_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClusterProcessReportType_Id, t.ProjectCluster_Id });
            
            DropForeignKey("dbo.ProjectClusters", "ProjectClusterType_Id", "dbo.ProjectClusterTypes");
            DropForeignKey("dbo.ClusterProcessReportTypes", "ProjectClusters_Id", "dbo.ProjectClusters");
            DropForeignKey("dbo.ClusterProcessReports", "ClusterReportFieldCategory_Id", "dbo.ClusterReportFieldCategories");
            DropForeignKey("dbo.ClusterProcessReports", "ClusterProcessReportType_Id", "dbo.ClusterProcessReportTypes");
            DropForeignKey("dbo.ClusterProcessReportEntries", "ClusterProcessReport_Id", "dbo.ClusterProcessReports");
            DropIndex("dbo.ClusterProcessReportEntries", new[] { "ClusterProcessReport_Id" });
            DropIndex("dbo.ClusterProcessReports", new[] { "ClusterReportFieldCategory_Id" });
            DropIndex("dbo.ClusterProcessReports", new[] { "ClusterProcessReportType_Id" });
            DropIndex("dbo.ClusterProcessReportTypes", new[] { "ProjectClusters_Id" });
            DropIndex("dbo.ProjectClusters", new[] { "ProjectClusterType_Id" });
            DropColumn("dbo.ClusterProcessReportEntries", "ClusterProcessReport_Id");
            DropColumn("dbo.ClusterProcessReportTypes", "ProjectClusters_Id");
            DropColumn("dbo.ProjectClusters", "ProjectClusterType_Id");
            DropTable("dbo.ProjectClusterTypes");
            DropTable("dbo.ClusterProcessReports");
            CreateIndex("dbo.ClusterProcessReportTypeProjectClusters", "ProjectCluster_Id");
            CreateIndex("dbo.ClusterProcessReportTypeProjectClusters", "ClusterProcessReportType_Id");
            AddForeignKey("dbo.ClusterProcessReportTypeProjectClusters", "ProjectCluster_Id", "dbo.ProjectClusters", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ClusterProcessReportTypeProjectClusters", "ClusterProcessReportType_Id", "dbo.ClusterProcessReportTypes", "Id", cascadeDelete: true);
        }
    }
}

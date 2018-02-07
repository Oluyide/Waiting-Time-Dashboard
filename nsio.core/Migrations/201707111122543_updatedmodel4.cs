namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodel4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClusterProcessReports", "ClusterReportFieldCategory_Id", "dbo.ClusterReportFieldCategories");
            DropIndex("dbo.ClusterProcessReports", new[] { "ClusterReportFieldCategory_Id" });
            DropColumn("dbo.ClusterProcessReports", "ClusterReportFieldCategory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClusterProcessReports", "ClusterReportFieldCategory_Id", c => c.Int());
            CreateIndex("dbo.ClusterProcessReports", "ClusterReportFieldCategory_Id");
            AddForeignKey("dbo.ClusterProcessReports", "ClusterReportFieldCategory_Id", "dbo.ClusterReportFieldCategories", "Id");
        }
    }
}

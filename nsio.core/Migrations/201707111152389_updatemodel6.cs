namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodel6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClusterProcessReportEntries", "FieldValue", c => c.String());
            AddColumn("dbo.ClusterProcessReportEntries", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.ClusterProcessReportEntries", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.ClusterProcessReportFieldTypes", "Required", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClusterProcessReportFieldTypes", "Required");
            DropColumn("dbo.ClusterProcessReportEntries", "DateModified");
            DropColumn("dbo.ClusterProcessReportEntries", "DateCreated");
            DropColumn("dbo.ClusterProcessReportEntries", "FieldValue");
        }
    }
}

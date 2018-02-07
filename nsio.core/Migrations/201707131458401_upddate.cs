namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upddate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClusterProcessReports", "SubmittedBy", c => c.String());
            AddColumn("dbo.ClusterProcessReports", "DateModified", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClusterProcessReports", "DateModified");
            DropColumn("dbo.ClusterProcessReports", "SubmittedBy");
        }
    }
}

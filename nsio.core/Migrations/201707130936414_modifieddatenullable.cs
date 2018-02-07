namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifieddatenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClusterProcessReportEntries", "DateModified", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClusterProcessReportEntries", "DateModified", c => c.DateTime(nullable: false));
        }
    }
}

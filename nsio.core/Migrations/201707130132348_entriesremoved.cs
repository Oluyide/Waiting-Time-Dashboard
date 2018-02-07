namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entriesremoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ClusterProcessReportEntries", "ClusterReportFiledId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClusterProcessReportEntries", "ClusterReportFiledId", c => c.Int(nullable: false));
        }
    }
}

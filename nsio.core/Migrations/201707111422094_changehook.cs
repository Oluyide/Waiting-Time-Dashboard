namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changehook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClusterProcessReportFieldTypes", "Hook", c => c.String());
            DropColumn("dbo.ClusterProcessReportFieldTypes", "displayString");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClusterProcessReportFieldTypes", "displayString", c => c.String());
            DropColumn("dbo.ClusterProcessReportFieldTypes", "Hook");
        }
    }
}

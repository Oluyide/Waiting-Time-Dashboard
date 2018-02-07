namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clusterreportdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClusterProcessReports", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClusterProcessReports", "DateCreated");
        }
    }
}

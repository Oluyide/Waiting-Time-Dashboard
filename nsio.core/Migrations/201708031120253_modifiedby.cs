namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedby : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClusterProcessReports", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClusterProcessReports", "ModifiedBy");
        }
    }
}

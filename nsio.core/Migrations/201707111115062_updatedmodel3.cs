namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodel3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataTypeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ClusterProcessReportFieldTypes", "DataTypeTable_Id", c => c.Int());
            CreateIndex("dbo.ClusterProcessReportFieldTypes", "DataTypeTable_Id");
            AddForeignKey("dbo.ClusterProcessReportFieldTypes", "DataTypeTable_Id", "dbo.DataTypeTables", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClusterProcessReportFieldTypes", "DataTypeTable_Id", "dbo.DataTypeTables");
            DropIndex("dbo.ClusterProcessReportFieldTypes", new[] { "DataTypeTable_Id" });
            DropColumn("dbo.ClusterProcessReportFieldTypes", "DataTypeTable_Id");
            DropTable("dbo.DataTypeTables");
        }
    }
}

namespace DUCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newone : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(),
                        Discriminator1 = c.String(nullable: false, maxLength: 128),
                        ProjectCluster_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectClusters", t => t.ProjectCluster_Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex")
                .Index(t => t.ProjectCluster_Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Permissions = c.String(),
                        PermissionsName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectClusters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectClusterName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.ClusterProcessReportTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProcessName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClusterProcessReportFieldTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fieldlabel = c.String(),
                        displayString = c.String(),
                        ClusterProcessReportType_Id = c.Int(),
                        ClusterReportFieldCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClusterProcessReportTypes", t => t.ClusterProcessReportType_Id)
                .ForeignKey("dbo.ClusterReportFieldCategories", t => t.ClusterReportFieldCategory_Id)
                .Index(t => t.ClusterProcessReportType_Id)
                .Index(t => t.ClusterReportFieldCategory_Id);
            
            CreateTable(
                "dbo.ClusterProcessReportEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClusterReportFiledId = c.Int(nullable: false),
                        ClusterProcessReportFieldType_Id = c.Int(),
                        ClusterProcessReportInstance_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClusterProcessReportFieldTypes", t => t.ClusterProcessReportFieldType_Id)
                .ForeignKey("dbo.ClusterProcessReportInstances", t => t.ClusterProcessReportInstance_Id)
                .Index(t => t.ClusterProcessReportFieldType_Id)
                .Index(t => t.ClusterProcessReportInstance_Id);
            
            CreateTable(
                "dbo.ClusterProcessReportInstances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClusterProcessReportTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClusterProcessReportTypes", t => t.ClusterProcessReportTypeId, cascadeDelete: true)
                .Index(t => t.ClusterProcessReportTypeId);
            
            CreateTable(
                "dbo.ClusterReportFieldCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        label = c.String(),
                        ClusterProcessReportType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClusterProcessReportTypes", t => t.ClusterProcessReportType_Id)
                .Index(t => t.ClusterProcessReportType_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectsName = c.String(),
                        ProjectDescription = c.String(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserLogins1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        AspNetUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUser_Id)
                .Index(t => t.AspNetUser_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.PermissionGRoles",
                c => new
                    {
                        Permission_Id = c.Int(nullable: false),
                        GRole_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Permission_Id, t.GRole_Id })
                .ForeignKey("dbo.Permissions", t => t.Permission_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.GRole_Id, cascadeDelete: true)
                .Index(t => t.Permission_Id)
                .Index(t => t.GRole_Id);
            
            CreateTable(
                "dbo.ClusterProcessReportTypeProjectClusters",
                c => new
                    {
                        ClusterProcessReportType_Id = c.Int(nullable: false),
                        ProjectCluster_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClusterProcessReportType_Id, t.ProjectCluster_Id })
                .ForeignKey("dbo.ClusterProcessReportTypes", t => t.ClusterProcessReportType_Id, cascadeDelete: true)
                .ForeignKey("dbo.ProjectClusters", t => t.ProjectCluster_Id, cascadeDelete: true)
                .Index(t => t.ClusterProcessReportType_Id)
                .Index(t => t.ProjectCluster_Id);
            
            CreateTable(
                "dbo.AspNetUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        AspNetUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUserClaims", t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUser_Id)
                .Index(t => t.Id)
                .Index(t => t.AspNetUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserClaim", "AspNetUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaim", "Id", "dbo.AspNetUserClaims");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins1", "AspNetUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ProjectClusters", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.ClusterProcessReportTypeProjectClusters", "ProjectCluster_Id", "dbo.ProjectClusters");
            DropForeignKey("dbo.ClusterProcessReportTypeProjectClusters", "ClusterProcessReportType_Id", "dbo.ClusterProcessReportTypes");
            DropForeignKey("dbo.ClusterReportFieldCategories", "ClusterProcessReportType_Id", "dbo.ClusterProcessReportTypes");
            DropForeignKey("dbo.ClusterProcessReportFieldTypes", "ClusterReportFieldCategory_Id", "dbo.ClusterReportFieldCategories");
            DropForeignKey("dbo.ClusterProcessReportFieldTypes", "ClusterProcessReportType_Id", "dbo.ClusterProcessReportTypes");
            DropForeignKey("dbo.ClusterProcessReportInstances", "ClusterProcessReportTypeId", "dbo.ClusterProcessReportTypes");
            DropForeignKey("dbo.ClusterProcessReportEntries", "ClusterProcessReportInstance_Id", "dbo.ClusterProcessReportInstances");
            DropForeignKey("dbo.ClusterProcessReportEntries", "ClusterProcessReportFieldType_Id", "dbo.ClusterProcessReportFieldTypes");
            DropForeignKey("dbo.AspNetRoles", "ProjectCluster_Id", "dbo.ProjectClusters");
            DropForeignKey("dbo.PermissionGRoles", "GRole_Id", "dbo.AspNetRoles");
            DropForeignKey("dbo.PermissionGRoles", "Permission_Id", "dbo.Permissions");
            DropIndex("dbo.AspNetUserClaim", new[] { "AspNetUser_Id" });
            DropIndex("dbo.AspNetUserClaim", new[] { "Id" });
            DropIndex("dbo.ClusterProcessReportTypeProjectClusters", new[] { "ProjectCluster_Id" });
            DropIndex("dbo.ClusterProcessReportTypeProjectClusters", new[] { "ClusterProcessReportType_Id" });
            DropIndex("dbo.PermissionGRoles", new[] { "GRole_Id" });
            DropIndex("dbo.PermissionGRoles", new[] { "Permission_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins1", new[] { "AspNetUser_Id" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.ClusterReportFieldCategories", new[] { "ClusterProcessReportType_Id" });
            DropIndex("dbo.ClusterProcessReportInstances", new[] { "ClusterProcessReportTypeId" });
            DropIndex("dbo.ClusterProcessReportEntries", new[] { "ClusterProcessReportInstance_Id" });
            DropIndex("dbo.ClusterProcessReportEntries", new[] { "ClusterProcessReportFieldType_Id" });
            DropIndex("dbo.ClusterProcessReportFieldTypes", new[] { "ClusterReportFieldCategory_Id" });
            DropIndex("dbo.ClusterProcessReportFieldTypes", new[] { "ClusterProcessReportType_Id" });
            DropIndex("dbo.ProjectClusters", new[] { "Project_Id" });
            DropIndex("dbo.AspNetRoles", new[] { "ProjectCluster_Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserClaim");
            DropTable("dbo.ClusterProcessReportTypeProjectClusters");
            DropTable("dbo.PermissionGRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserLogins1");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Projects");
            DropTable("dbo.ClusterReportFieldCategories");
            DropTable("dbo.ClusterProcessReportInstances");
            DropTable("dbo.ClusterProcessReportEntries");
            DropTable("dbo.ClusterProcessReportFieldTypes");
            DropTable("dbo.ClusterProcessReportTypes");
            DropTable("dbo.ProjectClusters");
            DropTable("dbo.Permissions");
            DropTable("dbo.AspNetRoles");
        }
    }
}

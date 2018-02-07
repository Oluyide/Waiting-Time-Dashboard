using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace DUCore.Models
{
    public partial class NSIOContext : IdentityDbContext<AppUser>
    {
       

        public NSIOContext()
            : base("Name=NSIOContext2")
        {
            Database.SetInitializer<NSIOContext>(new CreateDatabaseIfNotExists<NSIOContext>());

        }

        public virtual DbSet<GRole> AspNetRoles { get; set; }
        public virtual DbSet<UserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
       
        public virtual DbSet<ClusterProcessReportEntry> ClusterProcessReportEntries { get; set; }
        public virtual DbSet<ClusterProcessReportFieldType> ClusterProcessReportFieldTypes { get; set; }
        public virtual DbSet<ClusterProcessReport> ClusterProcessReports { get; set; }
        public virtual DbSet<ClusterProcessReportType> ClusterProcessReportTypes { get; set; }
        public virtual DbSet<ClusterReportFieldCategory> ClusterReportFieldCategories { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<ProjectCluster> ProjectClusters { get; set; }
        public virtual DbSet<Project> ProjectsNames { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<GRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            //modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Configurations.Add(new AspNetRoleMap());
            //modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            //modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            //modelBuilder.Configurations.Add(new AspNetUserMap());
            //modelBuilder.Configurations.Add(new ClusterProcessReportEntryMap());
            //modelBuilder.Configurations.Add(new ClusterProcessReportFieldTypeMap());
            //modelBuilder.Configurations.Add(new ClusterProcessReportInstanceMap());
            //modelBuilder.Configurations.Add(new ClusterProcessReportTypeMap());
            //modelBuilder.Configurations.Add(new ClusterReportFieldCategoryMap());
            //modelBuilder.Configurations.Add(new FileMap());
            //modelBuilder.Configurations.Add(new PermissionMap());
            //modelBuilder.Configurations.Add(new ProjectClusterMap());
            //modelBuilder.Configurations.Add(new ProjectRoleMap());
            //modelBuilder.Configurations.Add(new ProjectsNameMap());
        }
    }
}

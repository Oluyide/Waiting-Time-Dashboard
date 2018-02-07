using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FormCore.Models.Mapping;

namespace FormCore.Models
{
    public partial class HappinessFormContext : DbContext
    {
        static HappinessFormContext()
        {
            Database.SetInitializer<HappinessFormContext>(null);
        }

        public HappinessFormContext()
            : base("Name=HappinessFormContext")
        {
        }

        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<ClinicName> ClinicNames { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<DisplayAppointment> DisplayAppointments { get; set; }
        public DbSet<Happiness> Happinesses { get; set; }
        public DbSet<HealthPlancategory> HealthPlancategories { get; set; }
        public DbSet<Specialization> Specializations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new ClinicNameMap());
            modelBuilder.Configurations.Add(new DayMap());
            modelBuilder.Configurations.Add(new DisplayAppointmentMap());
            modelBuilder.Configurations.Add(new HappinessMap());
            modelBuilder.Configurations.Add(new HealthPlancategoryMap());
            modelBuilder.Configurations.Add(new SpecializationMap());
        }
    }
}

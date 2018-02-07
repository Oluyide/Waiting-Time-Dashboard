using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FormCore.Models.Mapping
{
    public class HealthPlancategoryMap : EntityTypeConfiguration<HealthPlancategory>
    {
        public HealthPlancategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.HealthPlan)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HealthPlancategory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HealthPlan).HasColumnName("HealthPlan");
        }
    }
}

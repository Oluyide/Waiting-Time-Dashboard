using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FormCore.Models.Mapping
{
    public class ClinicNameMap : EntityTypeConfiguration<ClinicName>
    {
        public ClinicNameMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Clinic)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ClinicName");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Clinic).HasColumnName("Clinic");
        }
    }
}

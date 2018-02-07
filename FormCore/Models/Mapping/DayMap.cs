using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FormCore.Models.Mapping
{
    public class DayMap : EntityTypeConfiguration<Day>
    {
        public DayMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Days)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Days");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}

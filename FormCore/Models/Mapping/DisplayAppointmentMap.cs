using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FormCore.Models.Mapping
{
    public class DisplayAppointmentMap : EntityTypeConfiguration<DisplayAppointment>
    {
        public DisplayAppointmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.StartAppointmentTime)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EndAppointmentDate)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DisplayAppointment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StartAppointmentTime).HasColumnName("StartAppointmentTime");
            this.Property(t => t.EndAppointmentDate).HasColumnName("EndAppointmentDate");
            this.Property(t => t.ClinicId).HasColumnName("ClinicId");
            this.Property(t => t.DoctorID).HasColumnName("DoctorID");
            this.Property(t => t.DayID).HasColumnName("DayID");

            // Relationships
            this.HasRequired(t => t.Specialization)
                .WithMany(t => t.DisplayAppointments)
                .HasForeignKey(d => d.ClinicId);

        }
    }
}

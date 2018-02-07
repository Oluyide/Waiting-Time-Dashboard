using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FormCore.Models.Mapping
{
    public class HappinessMap : EntityTypeConfiguration<Happiness>
    {
        public HappinessMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.PatientId)
                .HasMaxLength(50);

            this.Property(t => t.ContactNumber)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(50);

            this.Property(t => t.BestStaff)
                .HasMaxLength(50);

            this.Property(t => t.RoomNumber)
                .HasMaxLength(50);

            this.Property(t => t.AdmittingDoctor)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Happiness");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DataCollectionDate).HasColumnName("DataCollectionDate");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PatientId).HasColumnName("PatientId");
            this.Property(t => t.ContactNumber).HasColumnName("ContactNumber");
            this.Property(t => t.DateOfVisit).HasColumnName("DateOfVisit");
            this.Property(t => t.AppointConvenience).HasColumnName("AppointConvenience");
            this.Property(t => t.AppointAbility).HasColumnName("AppointAbility");
            this.Property(t => t.AppointCourtesy).HasColumnName("AppointCourtesy");
            this.Property(t => t.DocWaiting).HasColumnName("DocWaiting");
            this.Property(t => t.DocExplanation).HasColumnName("DocExplanation");
            this.Property(t => t.DocResponse).HasColumnName("DocResponse");
            this.Property(t => t.DocCourtesy).HasColumnName("DocCourtesy");
            this.Property(t => t.BillAbiltiy).HasColumnName("BillAbiltiy");
            this.Property(t => t.BillCourtesy).HasColumnName("BillCourtesy");
            this.Property(t => t.BillTime).HasColumnName("BillTime");
            this.Property(t => t.LabWaiting).HasColumnName("LabWaiting");
            this.Property(t => t.LabAbility).HasColumnName("LabAbility");
            this.Property(t => t.LabCourtesy).HasColumnName("LabCourtesy");
            this.Property(t => t.RadInfo).HasColumnName("RadInfo");
            this.Property(t => t.RadWaiting).HasColumnName("RadWaiting");
            this.Property(t => t.RadExplanation).HasColumnName("RadExplanation");
            this.Property(t => t.RadCourtesy).HasColumnName("RadCourtesy");
            this.Property(t => t.RadTimeliness).HasColumnName("RadTimeliness");
            this.Property(t => t.pharmAvail).HasColumnName("pharmAvail");
            this.Property(t => t.PharmWaiting).HasColumnName("PharmWaiting");
            this.Property(t => t.PharmCourtesy).HasColumnName("PharmCourtesy");
            this.Property(t => t.OverallHow).HasColumnName("OverallHow");
            this.Property(t => t.OverallWere).HasColumnName("OverallWere");
            this.Property(t => t.OverallEase).HasColumnName("OverallEase");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BestStaff).HasColumnName("BestStaff");
            this.Property(t => t.IsRecommend).HasColumnName("IsRecommend");
            this.Property(t => t.FormTypeID).HasColumnName("FormTypeID");
            this.Property(t => t.RoomNumber).HasColumnName("RoomNumber");
            this.Property(t => t.AdmittingDoctor).HasColumnName("AdmittingDoctor");
            this.Property(t => t.EmergencyContact).HasColumnName("EmergencyContact");
            this.Property(t => t.EmergencyImmediate).HasColumnName("EmergencyImmediate");
            this.Property(t => t.EmergencyOverall).HasColumnName("EmergencyOverall");
            this.Property(t => t.EmergencyLagoon).HasColumnName("EmergencyLagoon");
            this.Property(t => t.AdmissionExplanation).HasColumnName("AdmissionExplanation");
            this.Property(t => t.AdmissionQuality).HasColumnName("AdmissionQuality");
            this.Property(t => t.AdmissionCounselling).HasColumnName("AdmissionCounselling");
            this.Property(t => t.AdmissionCourtesy).HasColumnName("AdmissionCourtesy");
            this.Property(t => t.InPatDocAttentiveness).HasColumnName("InPatDocAttentiveness");
            this.Property(t => t.InPatInvolment).HasColumnName("InPatInvolment");
            this.Property(t => t.InPatDocExplanation).HasColumnName("InPatDocExplanation");
            this.Property(t => t.InPatDocRegVisit).HasColumnName("InPatDocRegVisit");
            this.Property(t => t.InPatDocCourtesy).HasColumnName("InPatDocCourtesy");
            this.Property(t => t.NursingTimeliness).HasColumnName("NursingTimeliness");
            this.Property(t => t.NursingInfo).HasColumnName("NursingInfo");
            this.Property(t => t.NursingQuality).HasColumnName("NursingQuality");
            this.Property(t => t.NursingCourtesy).HasColumnName("NursingCourtesy");
            this.Property(t => t.AccoCleaniness).HasColumnName("AccoCleaniness");
            this.Property(t => t.AccoBehaviour).HasColumnName("AccoBehaviour");
            this.Property(t => t.OpPunctuality).HasColumnName("OpPunctuality");
            this.Property(t => t.OpTimeliness).HasColumnName("OpTimeliness");
            this.Property(t => t.OpCourtesy).HasColumnName("OpCourtesy");
            this.Property(t => t.ICUAttentive).HasColumnName("ICUAttentive");
            this.Property(t => t.ICUTimeliness).HasColumnName("ICUTimeliness");
            this.Property(t => t.ICUExpalnation).HasColumnName("ICUExpalnation");
            this.Property(t => t.DischargeEOD).HasColumnName("DischargeEOD");
            this.Property(t => t.DischargeETD).HasColumnName("DischargeETD");
            this.Property(t => t.DsichargeTimeliness).HasColumnName("DsichargeTimeliness");
            this.Property(t => t.DischargeTimeTPA).HasColumnName("DischargeTimeTPA");
        }
    }
}

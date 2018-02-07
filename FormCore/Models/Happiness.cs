using System;
using System.Collections.Generic;

namespace FormCore.Models
{
    public partial class Happiness
    {
        public int Id { get; set; }
        public System.DateTime DataCollectionDate { get; set; }
        public string Name { get; set; }
        public string PatientId { get; set; }
        public string ContactNumber { get; set; }
        public System.DateTime DateOfVisit { get; set; }
        public Nullable<int> AppointConvenience { get; set; }
        public Nullable<int> AppointAbility { get; set; }
        public Nullable<int> AppointCourtesy { get; set; }
        public Nullable<int> DocWaiting { get; set; }
        public Nullable<int> DocExplanation { get; set; }
        public Nullable<int> DocResponse { get; set; }
        public Nullable<int> DocCourtesy { get; set; }
        public Nullable<int> BillAbiltiy { get; set; }
        public Nullable<int> BillCourtesy { get; set; }
        public Nullable<int> BillTime { get; set; }
        public Nullable<int> LabWaiting { get; set; }
        public Nullable<int> LabAbility { get; set; }
        public Nullable<int> LabCourtesy { get; set; }
        public Nullable<int> RadInfo { get; set; }
        public Nullable<int> RadWaiting { get; set; }
        public Nullable<int> RadExplanation { get; set; }
        public Nullable<int> RadCourtesy { get; set; }
        public Nullable<int> RadTimeliness { get; set; }
        public Nullable<int> pharmAvail { get; set; }
        public Nullable<int> PharmWaiting { get; set; }
        public Nullable<int> PharmCourtesy { get; set; }
        public Nullable<int> OverallHow { get; set; }
        public Nullable<int> OverallWere { get; set; }
        public Nullable<int> OverallEase { get; set; }
        public string Comment { get; set; }
        public string BestStaff { get; set; }
        public Nullable<int> IsRecommend { get; set; }
        public Nullable<int> FormTypeID { get; set; }
        public string RoomNumber { get; set; }
        public string AdmittingDoctor { get; set; }
        public Nullable<int> EmergencyContact { get; set; }
        public Nullable<int> EmergencyImmediate { get; set; }
        public Nullable<int> EmergencyOverall { get; set; }
        public Nullable<int> EmergencyLagoon { get; set; }
        public Nullable<int> AdmissionExplanation { get; set; }
        public Nullable<int> AdmissionQuality { get; set; }
        public Nullable<int> AdmissionCounselling { get; set; }
        public Nullable<int> AdmissionCourtesy { get; set; }
        public Nullable<int> InPatDocAttentiveness { get; set; }
        public Nullable<int> InPatInvolment { get; set; }
        public Nullable<int> InPatDocExplanation { get; set; }
        public Nullable<int> InPatDocRegVisit { get; set; }
        public Nullable<int> InPatDocCourtesy { get; set; }
        public Nullable<int> NursingTimeliness { get; set; }
        public Nullable<int> NursingInfo { get; set; }
        public Nullable<int> NursingQuality { get; set; }
        public Nullable<int> NursingCourtesy { get; set; }
        public Nullable<int> AccoCleaniness { get; set; }
        public Nullable<int> AccoBehaviour { get; set; }
        public Nullable<int> OpPunctuality { get; set; }
        public Nullable<int> OpTimeliness { get; set; }
        public Nullable<int> OpCourtesy { get; set; }
        public Nullable<int> ICUAttentive { get; set; }
        public Nullable<int> ICUTimeliness { get; set; }
        public Nullable<int> ICUExpalnation { get; set; }
        public Nullable<int> DischargeEOD { get; set; }
        public Nullable<int> DischargeETD { get; set; }
        public Nullable<int> DsichargeTimeliness { get; set; }
        public Nullable<int> DischargeTimeTPA { get; set; }
    }
}

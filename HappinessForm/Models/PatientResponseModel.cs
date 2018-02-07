using FormCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HappinessForm.Models
{
    public class PatientResponseModel
    {
        public PatientResponseModel()
        {

           RecommendList = new List<SelectListItem>();

            AppointConvenienceList = new List<SelectListItem>();
            AppointAbilityList = new List<SelectListItem>();
            AppointCourtesyList = new List<SelectListItem>();


            DocWaitingList = new List<SelectListItem>();
            DocExplanationList = new List<SelectListItem>();
            DocResponseList = new List<SelectListItem>();


            DocCourtesyList = new List<SelectListItem>();
            BillAbiltiyList= new List<SelectListItem>();
            BillCourtesyList = new List<SelectListItem>();
            BillCourtesyList = new List<SelectListItem>();


            BillTimeList = new List<SelectListItem>();
            LabWaitingList = new List<SelectListItem>();
            LabAbilityList = new List<SelectListItem>();


            LabCourtesyList = new List<SelectListItem>();
            RadInfoList = new List<SelectListItem>();
            RadWaitingList = new List<SelectListItem>();

            RadExplanationList = new List<SelectListItem>();
            RadCourtesyList = new List<SelectListItem>();
            RadTimelinessList = new List<SelectListItem>();


            pharmAvailList = new List<SelectListItem>();
            PharmWaitingList = new List<SelectListItem>();
            PharmCourtesyList = new List<SelectListItem>();


            OverallHowList = new List<SelectListItem>();
            OverallWereList = new List<SelectListItem>();
            OverallEaseList = new List<SelectListItem>();


            EmergencyContactList = new List<SelectListItem>();
            EmergencyImmediateList = new List<SelectListItem>();
            EmergencyOverallList = new List<SelectListItem>();

            EmergencyLagoonList = new List<SelectListItem>();
            AdmissionExplanationList = new List<SelectListItem>();
            AdmissionQualityList = new List<SelectListItem>();

            AdmissionCounsellingList = new List<SelectListItem>();
            AdmissionCourtesyList = new List<SelectListItem>();
            InPatDocAttentivenessList = new List<SelectListItem>();

            InPatInvolmentList = new List<SelectListItem>();
            InPatDocExplanationList = new List<SelectListItem>();
            InPatDocRegVisitList = new List<SelectListItem>();

            InPatDocCourtesyList = new List<SelectListItem>();
            NursingTimelinessList = new List<SelectListItem>();
            NursingInfoList= new List<SelectListItem>();

            NursingQualityList = new List<SelectListItem>();
            NursingCourtesyList = new List<SelectListItem>();
            AccoCleaninessList = new List<SelectListItem>();

            AccoBehaviourList = new List<SelectListItem>();
            OpPunctualityList = new List<SelectListItem>();
            OpTimelinessList = new List<SelectListItem>();


            OpCourtesyList = new List<SelectListItem>();
            ICUAttentiveList = new List<SelectListItem>();
            ICUTimelinessList = new List<SelectListItem>();

            ICUExpalnationList = new List<SelectListItem>();
            DischargeEODList = new List<SelectListItem>();
            DischargeETDList = new List<SelectListItem>();


            DsichargeTimelinessList = new List<SelectListItem>();
            DischargeTimeTPAList = new List<SelectListItem>();



        



    }

        public List<SelectListItem> RecommendList { get; set; }

        [DisplayName("Plan Categotry")]
        public List<SelectListItem> AppointConvenienceList { get; set; }

        [DisplayName("Clinic")]
        public List<SelectListItem> AppointAbilityList { get; set; }

        public List<SelectListItem> AppointCourtesyList { get; set; }
        public List<SelectListItem> DocWaitingList { get; set; }
        public List<SelectListItem> DocExplanationList { get; set; }
        public List<SelectListItem> DocResponseList { get; set; }
        public List<SelectListItem> DocCourtesyList { get; set; }

        public List<SelectListItem> BillAbiltiyList { get; set; }

        public List<SelectListItem> BillCourtesyList { get; set; }

        public List<SelectListItem> BillTimeList { get; set; }

        public List<SelectListItem> LabWaitingList { get; set; }
        public List<SelectListItem> LabAbilityList { get; set; }
        public List<SelectListItem> LabCourtesyList { get; set; }
        public List<SelectListItem> RadInfoList { get; set; }

        public List<SelectListItem> RadWaitingList { get; set; }

        public List<SelectListItem> RadExplanationList { get; set; }

        public List<SelectListItem> RadCourtesyList { get; set; }
        public List<SelectListItem> RadTimelinessList { get; set; }

        public List<SelectListItem> pharmAvailList { get; set; }

        public List<SelectListItem> PharmWaitingList { get; set; }
        public List<SelectListItem> PharmCourtesyList { get; set; }

        public List<SelectListItem> OverallHowList { get; set; }

        public List<SelectListItem> OverallWereList { get; set; }
        public List<SelectListItem> OverallEaseList { get; set; }





        public List<SelectListItem> EmergencyContactList { get; set; }
        public List<SelectListItem> EmergencyImmediateList { get; set; }
        public List<SelectListItem> EmergencyOverallList { get; set; }
        public List<SelectListItem> EmergencyLagoonList { get; set; }
        public List<SelectListItem> AdmissionExplanationList { get; set; }
        public List<SelectListItem> AdmissionQualityList { get; set; }
        public List<SelectListItem> AdmissionCounsellingList { get; set; }
        public List<SelectListItem> AdmissionCourtesyList { get; set; }
        public List<SelectListItem> InPatDocAttentivenessList { get; set; }
        public List<SelectListItem> InPatInvolmentList { get; set; }
        public List<SelectListItem> InPatDocExplanationList { get; set; }
        public List<SelectListItem> InPatDocRegVisitList { get; set; }
        public List<SelectListItem> InPatDocCourtesyList { get; set; }
        public List<SelectListItem> NursingTimelinessList { get; set; }
        public List<SelectListItem> NursingInfoList { get; set; }
        public List<SelectListItem> NursingQualityList { get; set; }
        public List<SelectListItem> NursingCourtesyList { get; set; }
        public List<SelectListItem> AccoCleaninessList { get; set; }
        public List<SelectListItem> AccoBehaviourList { get; set; }
        public List<SelectListItem> OpPunctualityList { get; set; }
        public List<SelectListItem> OpTimelinessList { get; set; }
        public List<SelectListItem> OpCourtesyList { get; set; }
        public List<SelectListItem> ICUAttentiveList { get; set; }
        public List<SelectListItem> ICUTimelinessList { get; set; }
        public List<SelectListItem> ICUExpalnationList { get; set; }
        public List<SelectListItem> DischargeEODList { get; set; }
        public List<SelectListItem> DischargeETDList { get; set; }
        public List<SelectListItem> DsichargeTimelinessList { get; set; }
        public List<SelectListItem> DischargeTimeTPAList { get; set; }


        public int Recommend { get; set; }
        public int Id { get; set; }
        public System.DateTime DataCollectionDate { get; set; }
        public string Name { get; set; }
        public string PatientId { get; set; }
        public string ContactNumber { get; set; }
        public System.DateTime DateOfVisit { get; set; }
        public int AppointConvenience { get; set; }
        public int AppointAbility { get; set; }
        public int AppointCourtesy { get; set; }
        public int DocWaiting { get; set; }
        public int DocExplanation { get; set; }
        public int DocResponse { get; set; }
        public int DocCourtesy { get; set; }
        public int BillAbiltiy { get; set; }
        public int BillCourtesy { get; set; }
        public int BillTime { get; set; }
        public int LabWaiting { get; set; }
        public int LabAbility { get; set; }
        public int LabCourtesy { get; set; }
        public int RadInfo { get; set; }
        public int RadWaiting { get; set; }
        public int RadExplanation { get; set; }
        public int RadCourtesy { get; set; }
        public int RadTimeliness { get; set; }
        public int pharmAvail { get; set; }
        public int PharmWaiting { get; set; }
        public int PharmCourtesy { get; set; }
        public int OverallHow { get; set; }
        public int OverallWere { get; set; }
        public int OverallEase { get; set; }
        public string Comment { get; set; }
        public string BestStaff { get; set; }



        public int FormTypeID { get; set; }
        public string RoomNumber { get; set; }
        public string AdmittingDoctor { get; set; }
        public int EmergencyContact { get; set; }
        public int EmergencyImmediate { get; set; }
        public int EmergencyOverall { get; set; }
        public int EmergencyLagoon { get; set; }
        public int AdmissionExplanation { get; set; }
        public int AdmissionQuality { get; set; }
        public int AdmissionCounselling { get; set; }
        public int AdmissionCourtesy { get; set; }
        public int InPatDocAttentiveness { get; set; }
        public int InPatInvolment { get; set; }
        public int InPatDocExplanation { get; set; }
        public int InPatDocRegVisit { get; set; }
        public int InPatDocCourtesy { get; set; }
        public int NursingTimeliness { get; set; }
        public int NursingInfo { get; set; }
        public int NursingQuality { get; set; }
        public int NursingCourtesy { get; set; }
        public int AccoCleaniness { get; set; }
        public int AccoBehaviour { get; set; }
        public int OpPunctuality { get; set; }
        public int OpTimeliness { get; set; }
        public int OpCourtesy { get; set; }
        public int ICUAttentive { get; set; }
        public int ICUTimeliness { get; set; }
        public int ICUExpalnation { get; set; }
        public int DischargeEOD { get; set; }
        public int DischargeETD { get; set; }
        public int DsichargeTimeliness { get; set; }
        public int DischargeTimeTPA { get; set; }







    }



        public class SwitchingModel
        {

        public SwitchingModel()
         {
           AvailableForms = new List<SelectListItem>();
         }

        public List<SelectListItem> AvailableForms { get; set; }
        public int Forms { get; set; } 
    }

}

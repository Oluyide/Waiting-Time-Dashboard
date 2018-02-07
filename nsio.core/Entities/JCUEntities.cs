using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Entities
{
    public class JCUEntities
    {
        
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("reportingdate")]
            public DateTime? ReportingDate { get; set; }
        [JsonProperty("implementationid")]
        public int? ImpId { get; set; }
        [JsonProperty("programid")]

            public int ProgramId { get; set; }
            [JsonProperty("stateid")]
            public int StateId { get; set; }
            [JsonProperty("statename")]
            public string StateName { get; set; }

            [JsonProperty("zoneid")]
            public int ZoneId { get; set; }

            [JsonProperty("statetarget")]
            public int StateTarget { get; set; }
            [JsonProperty("stateactual")]
            public int? StateActual { get; set; }
            [JsonProperty("PlannedBeneficiaries")]
            public double? PlannedBeneficiaries { get; set; }
            [JsonProperty("appliedbeneficiaries")]
            public double? AppliedBeneficiaries { get; set; }
        [JsonProperty("selectedbeneficiaries")]
        public double? SelectedBeneficiaries { get; set; }
        [JsonProperty("beneficiariesdeployed")]
        public double? BeneficiariesDeployed{ get; set; }
        [JsonProperty("verifiedbeneficiaries")]
            public double? VerifiedBeneficiaries { get; set; }
            [JsonProperty("existingbeneficiaries")]
            public double? ExistingBeneficiaries { get; set; }
            [JsonProperty("employedbeneficiaries")]
            public double? EmployedBeneficiaries { get; set; }
            [JsonProperty("trainingcentre")]
            public int? TrainingCentre { get; set; }
            [JsonProperty("paidbeneficiaries")]
            public int? PaidBeneficiaries { get; set; }
            [JsonProperty("amountpaid")]
            public int? AmountPaid { get; set; }
        

         
        public int? Complaints { get; set; }
    }


    public class JCUProgramme
    {
       


        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("monthid")]
        public int monthId { get; set; }

        [JsonProperty("month")]
        public string month { get; set; }
        [JsonProperty("year")]
        public int Year { get; set; }
        [JsonProperty("programid")]
        public int ProgramId { get; set; }
        [JsonProperty("stateactual")]
        public int StateActual { get; set; }

        [JsonProperty("statetarget")]
        public int StateTarget { get; set; }
        //MonthID Month   Year ProgramId   StateActual StateTarget ActualBeneficiariesSelected TargetBeneficiariesSelected ActualBeneficiariesPaid 
        //TargetBeneficiariesPaid ActualBeneficiariesVerified TargetBeneficiariesVerified     Complaint

        [JsonProperty("actualbeneficiariesselected")]
        public double ActualBeneficiariesSelected { get; set; }

        [JsonProperty("targetbeneficiariesselected")]
        public double? TargetBeneficiariesSelected { get; set; }
        [JsonProperty("actualbeneficiariespaid")]
        public double? ActualBeneficiariesPaid { get; set; }

        [JsonProperty("targetbeneficiariespaid")]
        public double? TargetBeneficiariesPaid { get; set; }

        [JsonProperty("actualbeneficiariesverified")]
        public int? ActualBeneficiariesVerified { get; set; }
        [JsonProperty("targetbeneficiariesverified")]
        public int? TargetBeneficiariesVerified { get; set; }
        //ActualBeneficiariesDeloyedToPPA TargetBeneficiariesDeloyedToPPA

        [JsonProperty("actualbeneficiariesdeloyedtoppa")]
        public string ActualBeneficiariesDeloyedToPPA { get; set; }
        [JsonProperty("targetbeneficiariesdeloyedtoppa")]
        public int? TargetBeneficiariesDeloyedToPPA { get; set; }
        [JsonProperty("startedthismonth")]
        public int? StartedThisMonth { get; set; }



        [JsonProperty("complaint")]
        public double? Complaint { get; set; }
    }

}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Entities
{
    public class GEEPEntities
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("reportingdate")]
        public DateTime? ReportingDate { get; set; }
        [JsonProperty("programid")]
        public int ProgramId { get; set; }
        [JsonProperty("stateid")]
        public int StateId { get; set; }
        [JsonProperty("statename")]
        public string StateName { get; set; }
        [JsonProperty("implementationid")]
        public int? ImpId { get; set; }

        [JsonProperty("zoneid")]
        public int ZoneId { get; set; }

        [JsonProperty("statetarget")]
        public int StateTarget { get; set; }
        [JsonProperty("stateactual")]
        public int? StateActual { get; set; }
        [JsonProperty("plannedBeneficiaries")]
        public double? PlannedBeneficiaries { get; set; }

        [JsonProperty("registeredbeneficiaries")]
        public double? RegisteredBeneficiaries { get; set; }

        [JsonProperty("actualbeneficiaries")]
        public double? ActualBeneficiaries { get; set; }

        [JsonProperty("targetbeneficiarieswithbvn")]
        public double? TargetBeneficiariesWithBVN { get; set; }
        [JsonProperty("actualbeneficiarieswithbvn")]
        public double? ActualBeneficiariesWithBVN { get; set; }
        [JsonProperty("loansapplied")]
        public double? LoansApplied { get; set; }

        [JsonProperty("loansapproved")]
        public double? LoansApproved { get; set; }

        [JsonProperty("loanapprovedtarget")]
        public double? LoanApprovedTarget { get; set; }

        [JsonProperty("amountpaid")]
        public double? AmountPaid { get; set; }
        [JsonProperty("cooperatives")]
        public double? Cooperatives { get; set; }
        [JsonProperty("complaints")]
        public double? Complaints { get; set; }
    }



    public class GEEPStatusEntities
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

        [JsonProperty("actualgeepdisbursements")]
        public double ActualGeepDisbursements { get; set; }

        [JsonProperty("targetgeepdisbursements")]
        public double? TargetGeepDisbursements { get; set; }
        [JsonProperty("targetdisbursementyearly")]
        public double? TargetDisbursementYearly { get; set; }

        [JsonProperty("beneficiariesregistered")]
        public double? BeneficiariesRegistered { get; set; }

        [JsonProperty("statestartedthismonth")]
        public int? StateStartedThisMonth { get; set; }
        
        [JsonProperty("complaint")]
        public double? Complaint { get; set; }

        //MonthID Month   Year ProgramId   StateActual StateTarget ActualGeepDisbursements TargetGeepDisbursements TargetDisbursementYearly 
        //BeneficiariesRegistered StateStartedThisMonth Complaint

    }


}

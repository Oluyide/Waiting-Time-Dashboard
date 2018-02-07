using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Entities
{
    public class CCTEntities
    {
        

           [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("monthid")]
            public int monthId  { get; set; }

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

            [JsonProperty("actualregisteredbenhouseHold")]
            public double ActualRegisteredBenHouseHold { get; set; }

            [JsonProperty("targetregisteredbenhousehold")]
            public double? TargetRegisteredBenHouseHold { get; set; }
            [JsonProperty("actualbeneficiarieshousholdpaid")]
            public double? ActualBeneficiariesHousholdPaid { get; set; }

            [JsonProperty("targetbeneficiarieshousholdpaid")]
            public double? TargetBeneficiariesHousholdPaid { get; set; }


        [JsonProperty("actualbeneficiarieshouseholderolled")]
        public double? ActualBeneficiariesHouseHoldErolled { get; set; }
        [JsonProperty("targetbeneficiarieshouseholderolled")]
        public double? TargetBeneficiariesHouseHoldErolled { get; set; }

        [JsonProperty("stateStartedthismonth")]
        public double? StateStartedThisMonth { get; set; }
        [JsonProperty("targetpayment")]
        public double? TargetPayment { get; set; }
        [JsonProperty("complaint")]
        public double? Complaint { get; set; }

    }

    public class CCTStatusEntities
    {
       

            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("reportingdate")]
            public DateTime? ReportingDate { get; set; }
            [JsonProperty("programid")]
            public int? ProgramId { get; set; }
            [JsonProperty("stateid")]
            public int? StateId { get; set; }
            [JsonProperty("statename")]
            public string StateName { get; set; }

            [JsonProperty("zoneid")]
            public int? ZoneId { get; set; }
        [JsonProperty("implementationid")]
        public int? ImpId { get; set; }

        [JsonProperty("statetarget")]
            public int? StateTarget { get; set; }
            [JsonProperty("stateactual")]
            public int? StateActual { get; set; }
            [JsonProperty("targetbeneficiaries")]
            public double? TargetBeneficiaries { get; set; }

            [JsonProperty("appliedbeneficiaries")]
            public double? AppliedBeneficiaries { get; set; }

            [JsonProperty("selectedbeneficiaries")]
            public double? SelectedBeneficiaries { get; set; }
            [JsonProperty("targetpaidbeneficiaries")]
            public double? TargetPaidBeneficiaries { get; set; }
            [JsonProperty("actualpaidbeneficiaries")]
            public double? ActualPaidBenefiaciaries { get; set; }

            [JsonProperty("amountpaid")]
            public double? AmountPaid { get; set; }

            [JsonProperty("complaint")]
            public double? Complaints { get; set; }

        [JsonProperty("actualregisteredbenhouseHold")]
        public double? ActualRegisteredBenHouseHold { get; set; }

        [JsonProperty("actualbeneficiarieshouseholderolled")]
        public double? ActualBeneficiariesHouseHoldErolled { get; set; }


        [JsonProperty("actualbeneficiarieshousholdpaid")]
        public double? ActualBeneficiariesHousholdPaid { get; set; }


    }



    }


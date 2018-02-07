using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Entities
{
    public class DashboardEntities
    {
        public class HGSFProgramme
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("reportingdate")]
            public DateTime? ReportingDate { get; set; }
            [JsonProperty("programid")]
            public int ProgramId { get; set; }
            [JsonProperty("implementationid")]
            public int? ImpId { get; set; }
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
            [JsonProperty("studenttarget")]
            public double? StudentTarget { get; set; }
            [JsonProperty("studentactual")]
            public double? StudentActual { get; set; }
            [JsonProperty("jobcreation")]
            public double? JobCreation { get; set; }
            [JsonProperty("schoolsstarted")]
            public double? SchoolsStarted { get; set; }
            [JsonProperty("schoolstargeted")]
            public double? SchoolsTargeted { get; set; }
            [JsonProperty("complaint")]
            public int? Complaint { get; set; }
            [JsonProperty("catererapplications")]
            public int? CatererApplications { get; set; }
            [JsonProperty("successfulcaterers")]
            public int? SuccessfulCaterers { get; set; }
        }


        public class HGSFEntities
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
            //MonthID Month   Year ProgramId   StateActual StateTarget ActualSchoolStarted TargetSchoolStarted ActualPupilsFedDaily TargetPupilsFedDaily
            //ActualJobsCreated StateStartedThisMonth   Complaint

            [JsonProperty("actualschoolstarted")]
            public double ActualSchoolStarted { get; set; }

            [JsonProperty("targetschoolstarted")]
            public double? TargetSchoolStarted { get; set; }
            [JsonProperty("actualpupilsfeddaily")]
            public double? ActualPupilsFedDaily { get; set; }

            [JsonProperty("targetpupilsfeddaily")]
            public double? TargetPupilsFedDaily { get; set; }

            [JsonProperty("ActualJobsCreated")]
            public double? ActualJobsCreated { get; set; }


            [JsonProperty("StateStartedThisMonth")]
            public double? StateStartedThisMonth { get; set; }
            [JsonProperty("Complaint")]
            public int? Complaint { get; set; }

            

        }
    }
}

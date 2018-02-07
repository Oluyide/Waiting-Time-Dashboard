using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Entities
{
    public class GraphEntities
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("month")]
        public string Month { get; set; }
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("statetarget")]
        public  int? StateTargert { get; set; }
        [JsonProperty("stateactual")]
        public int? StateActual { get; set; }
        [JsonProperty("programid")]
        public int? ProgramId { get; set; }
        [JsonProperty("programname")]
        public string ProgramName { get; set; }

        //[JsonProperty("targetbeneficiaries")]
        //public int? targetBeneficiaries { get; set; }
        //[JsonProperty("actualbanefaciaries")]
        //public int? ActualBeneficiaries { get; set; }

        [JsonProperty("beneficiariestarget")]
        public double? beneficiariesTarget { get; set; }
        [JsonProperty("beneficiariesactual")]
        public double? beneficiariesActual { get; set; }
    }
}

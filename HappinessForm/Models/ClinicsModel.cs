using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappinessForm.Models
{
    public class ClinicsModel

    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ClinicsName { get; set; }
        public double AverageTime { get; set; }

        //public List<ClinicsModel> Clinics { get; set; }
    }

    public class ManageModel
    {
        public List<string> Specialization { get; set; }
        public List<SelectListItem> Specializations { get; set; }
        public List<SelectListItem> Days { get; set; }
        public string Day { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get;  set;}
    }
}
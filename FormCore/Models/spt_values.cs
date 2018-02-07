using System;
using System.Collections.Generic;

namespace FormCore.Models
{
    public partial class spt_values
    {
        public string name { get; set; }
        public int number { get; set; }
        public string type { get; set; }
        public Nullable<int> low { get; set; }
        public Nullable<int> high { get; set; }
        public Nullable<int> status { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DUCore.Models
{
    public partial class ClusterProcessReportInstance
    {
        public ClusterProcessReportInstance()
        {
            //this.ClusterProcessReportEntries = new List<ClusterProcessReportEntry>();
        }

        public int Id { get; set; }
        public int ClusterProcessReportTypeId { get; set; }
        //public virtual ICollection<ClusterProcessReportEntry> ClusterProcessReportEntries { get; set; }
        public virtual ClusterProcessReportType ClusterProcessReportType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DUCore.Models
{
    public partial class ClusterReportFieldCategory
    {
        public ClusterReportFieldCategory()
        {
            this.ClusterProcessReportFieldTypes = new List<ClusterProcessReportFieldType>();
        }

        public int Id { get; set; }
        public string label { get; set; }
        
        public virtual ICollection<ClusterProcessReportFieldType> ClusterProcessReportFieldTypes { get; set; }
        public virtual ClusterProcessReportType ClusterProcessReportType { get; set; }
    }
}

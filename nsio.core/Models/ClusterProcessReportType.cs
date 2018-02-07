using System;
using System.Collections.Generic;

namespace DUCore.Models
{
    public partial class ClusterProcessReportType
    {
        public ClusterProcessReportType()
        {
            this.ClusterProcessReportFieldTypes = new List<ClusterProcessReportFieldType>();
            this.ClusterReportFieldCategories = new List<ClusterReportFieldCategory>();
            this.ClusterProcessReport = new List<ClusterProcessReport>();
        }

        public int Id { get; set; }
        public string ProcessName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<ClusterProcessReportFieldType> ClusterProcessReportFieldTypes { get; set; }
        public virtual ICollection<ClusterReportFieldCategory> ClusterReportFieldCategories { get; set; }
        public virtual ICollection<ClusterProcessReport> ClusterProcessReport { get; set; }
        public virtual ProjectCluster ProjectClusters { get; set; }
    }
}

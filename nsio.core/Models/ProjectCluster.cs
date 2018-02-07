using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DUCore.Models
{
    public partial class ProjectCluster
    {
        public ProjectCluster()
        {
            this.AspNetRoles = new List<GRole>();
            this.ClusterProcessReportType = new List<ClusterProcessReportType>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProjectClusterName { get; set; }
        public Project Project { get; set; }
        public ProjectClusterType ProjectClusterType { get;  set;}
        public bool IsActive { get; set; }
        public virtual ICollection<GRole> AspNetRoles { get; set; }
        public virtual ICollection<ClusterProcessReportType> ClusterProcessReportType { get; set; }

       
    }
}

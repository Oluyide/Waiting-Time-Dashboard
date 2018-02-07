using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DUCore.Models
{
    public partial class Project
    {
        public Project()
        {
            this.ProjectClusters = new List<ProjectCluster>();  
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProjectsName { get; set; }
        public string ProjectDescription { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public virtual ICollection<ProjectCluster> ProjectClusters { get; set; }
       
    }
}
